namespace ReservasCoworking.Domain.Entities;

public class Room
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
