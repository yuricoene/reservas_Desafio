using Microsoft.EntityFrameworkCore;
using ReservasCoworking.Domain.Entities;

namespace ReservasCoworking.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Reservation> Reservations => Set<Reservation>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed das salas
        modelBuilder.Entity<Room>().HasData(
            new Room { Id = 1, Name = "Sala Aurora" },
            new Room { Id = 2, Name = "Sala Horizon" },
            new Room { Id = 3, Name = "Sala Nexus" },
            new Room { Id = 4, Name = "Sala Vertex" }
        );
    }
}
