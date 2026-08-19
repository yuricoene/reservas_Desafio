namespace ReservasCoworking.Application.Features.Reservations.DTOs;

public class ReservationResponse
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public long RoomId { get; set; }
    public string RoomName { get; set; } = string.Empty;
    public bool Cancelled { get; set; }
}
