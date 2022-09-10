using api.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;


[Route("api/v1/cars")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly CarBookingContext _context;
    
    public CarsController(CarBookingContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetCars()
    {
        return StatusCode(StatusCodes.Status200OK, await _context.Cars.ToListAsync());
    }
}