using ReservasCoworking.Application.Features.Reservations.DTOs;

namespace ReservasCoworking.Application.Features.Reservations.Interfaces;

public interface IReservationService
{
    Task<List<ReservationResponse>> ListAllAsync();
    Task<ReservationResponse> CreateAsync(CreateReservationRequest request);
    Task CancelAsync(long id);
}
