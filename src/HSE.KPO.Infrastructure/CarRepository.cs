using HSE.KPO.Application.Repositories;
using HSE.KPO.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HSE.KPO.Infrastructure;

public class Repository : ICarRepository
{
    private readonly CarsDbContext _context;

    public Repository(CarsDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<Car>> GetCars(CancellationToken cancellationToken)
    {
        var cars = await _context.Cars.ToArrayAsync(cancellationToken);
        return cars;
    }

    public async Task<Car?> GetCar(int id, CancellationToken cancellationToken)
    {
        var car = await _context.Cars.Where(t => t.Id == id).FirstOrDefaultAsync(cancellationToken);
        return car;
    }

    public async Task<Car?> GetCar(int id, int moveCount, CancellationToken cancellationToken)
    {
        var car = await _context.Cars.Where(t => t.Id == id && t.MoveCount == moveCount).FirstOrDefaultAsync(cancellationToken);
        return car;
    }
    
    public Car AddCar(Car car)
    {
        _context.Cars.Add(car);
        return car;
    }
    
    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}