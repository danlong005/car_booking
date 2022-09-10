using api.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<CarBookingContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

List<string> origins = new()
{
    {
    "http://localhost:3000"
    }
};
string MyAllowedOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowedOrigins, policy =>
    {
        policy.WithOrigins(origins.ToArray()); 
        
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors(MyAllowedOrigins);

app.Run();
