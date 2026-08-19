using Microsoft.EntityFrameworkCore;
using ReservasCoworking.Application.Features.Reservations.Interfaces;
using ReservasCoworking.Application.Features.Reservations.Services;
using ReservasCoworking.Infrastructure.Persistence;
using ReservasCoworking.Api.Filters;

var builder = WebApplication.CreateBuilder(args);

// Serviços
// 2. Modifique aqui para registrar o filtro globalmente:
builder.Services.AddControllers(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Banco SQLite + Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=reservas.db"));

// Injeção de dependência (interface → implementação)
builder.Services.AddScoped<IReservationService, ReservationService>();

// CORS (libera o frontend React)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Cria o banco e aplica o seed automaticamente
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.MapControllers();

app.Run();