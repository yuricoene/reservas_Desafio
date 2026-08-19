using Microsoft.AspNetCore.Mvc;
using ReservasCoworking.Application.Features.Reservations.DTOs;
using ReservasCoworking.Application.Features.Reservations.Interfaces;

namespace ReservasCoworking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly IReservationService _service;

    public ReservationsController(IReservationService service)
    {
        _service = service;
    }

    /// <summary>
    /// Lista todas as reservas ativas
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<List<ReservationResponse>>> GetAll()
    {
        var reservations = await _service.ListAllAsync();
        return Ok(reservations);
    }

    /// <summary>
    /// Cria uma nova reserva
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ReservationResponse>> Create([FromBody] CreateReservationRequest request)
    {
        try
        {
            var reservation = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), reservation);
        }
        catch (BadHttpRequestException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(new { message = ex.Message });
        }
    }

    /// <summary>
    /// Cancela uma reserva (Soft Delete)
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Cancel(long id)
    {
        try
        {
            await _service.CancelAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}