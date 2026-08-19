namespace ReservasCoworking.Domain.Entities;

public class Reservation
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    /// <summary>
    /// Soft Delete - se estiver preenchido, a reserva está cancelada
    /// </summary>
    public DateTime? CancelledAt { get; set; }

    public long RoomId { get; set; }
    public Room Room { get; set; } = null!;

    public bool IsCancelled => CancelledAt != null;
}
