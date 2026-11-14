using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Interfaces;

public interface ICarService
{
    Task<Car> CreateCar(int id, CancellationToken cancellationToken);

    Task<Car> GetCar(int id, CancellationToken cancellationToken);
}