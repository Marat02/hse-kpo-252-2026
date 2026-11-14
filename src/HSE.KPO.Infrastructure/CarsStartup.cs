using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HSE.KPO.Infrastructure;

public static class CarsStartup
{
    public static async Task Migrate(IServiceProvider provider)
    {
        using var scope = provider.CreateScope(); 
        await scope.ServiceProvider.GetRequiredService<CarsDbContext>().Database.MigrateAsync();
    }
}