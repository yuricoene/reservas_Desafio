using System.ComponentModel.DataAnnotations;

namespace ReservasCoworking.Application.Features.Reservations.DTOs;

public class CreateReservationRequest
{
    [Required(ErrorMessage = "A sala é obrigatória")]
    public long RoomId { get; set; }

    [Required(ErrorMessage = "O título é obrigatório")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "O horário de início é obrigatório")]
    public DateTime Start { get; set; }

    [Required(ErrorMessage = "O horário de fim é obrigatório")]
    public DateTime End { get; set; }
}
