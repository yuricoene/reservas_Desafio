using Microsoft.EntityFrameworkCore;
using ReservasCoworking.Application.Features.Reservations.DTOs;
using ReservasCoworking.Application.Features.Reservations.Interfaces;
using ReservasCoworking.Domain.Entities;
using ReservasCoworking.Infrastructure.Persistence;

namespace ReservasCoworking.Application.Features.Reservations.Services;

public class ReservationService : IReservationService
{
    private readonly AppDbContext _context;

    public ReservationService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ReservationResponse>> ListAllAsync()
    {
        return await _context.Reservations
            .Include(r => r.Room)
            .Where(r => r.CancelledAt == null)
            .OrderBy(r => r.Start)
            .Select(r => new ReservationResponse
            {
                Id = r.Id,
                Title = r.Title,
                Start = r.Start,
                End = r.End,
                RoomId = r.RoomId,
                RoomName = r.Room.Name,
                Cancelled = r.CancelledAt != null
            })
            .ToListAsync();
    }

    public async Task<ReservationResponse> CreateAsync(CreateReservationRequest request)
    {
        // 1. Validação: fim deve ser depois do início
        if (request.End <= request.Start)
        {
            throw new BadHttpRequestException("O horário de fim deve ser depois do horário de início");
        }

        // 2. Verificar se a sala existe
        var room = await _context.Rooms.FindAsync(request.RoomId);
        if (room == null)
        {
            throw new KeyNotFoundException("Sala não encontrada");
        }

        // 3. Validação de SOBREPOSIÇÃO (regra principal)
        bool hasOverlap = await _context.Reservations
            .AnyAsync(r =>
                r.RoomId == request.RoomId &&
                r.CancelledAt == null &&
                r.Start < request.End &&
                r.End > request.Start
            );

        if (hasOverlap)
        {
            throw new InvalidOperationException("Já existe uma reserva nesta sala neste horário");
        }

        // 4. Criar e salvar
        var reservation = new Reservation
        {
            Title = request.Title,
            Start = request.Start,
            End = request.End,
            RoomId = request.RoomId
        };

        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();

        return new ReservationResponse
        {
            Id = reservation.Id,
            Title = reservation.Title,
            Start = reservation.Start,
            End = reservation.End,
            RoomId = reservation.RoomId,
            RoomName = room.Name,
            Cancelled = false
        };
    }

    public async Task CancelAsync(long id)
    {
        var reservation = await _context.Reservations.FindAsync(id);

        if (reservation == null)
        {
            throw new KeyNotFoundException("Reserva não encontrada");
        }

        if (reservation.CancelledAt != null)
        {
            throw new InvalidOperationException("Esta reserva já está cancelada");
        }

        // Soft Delete
        reservation.CancelledAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
    }
}
