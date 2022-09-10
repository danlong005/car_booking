using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Database;

public class CarBookingContext : DbContext
{
    public CarBookingContext(DbContextOptions<CarBookingContext> options) : base(options) 
    {
    }

    public DbSet<Car> Cars { get; set; }
}
