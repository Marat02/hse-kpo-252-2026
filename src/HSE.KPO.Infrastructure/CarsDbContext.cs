using HSE.KPO.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HSE.KPO.Infrastructure;

public class CarsDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
    {
    }
}