using HSE.KPO.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HSE.KPO.Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddCarsInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<CarsDbContext>(t => 
            t.UseNpgsql("Host=localhost;Port=5432;Database=kpo;Username=postgres;Password=password"));
        services.AddScoped<ICarRepository, Repository>();
        
        return services;
    }
}