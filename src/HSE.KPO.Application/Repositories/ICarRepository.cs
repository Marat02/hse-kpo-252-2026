using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Repositories;

public interface ICarRepository
{
    public Car AddCar(Car car);

    public Task<IReadOnlyCollection<Car>> GetCars(CancellationToken cancellationToken);

    public Task<Car?> GetCar(int id, CancellationToken cancellationToken);

    public Task SaveChangesAsync(CancellationToken cancellationToken);
}