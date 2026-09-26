using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Interfaces;

public interface ICarRepository
{
    int SaveCar(Car car);
}

public class CarRepository : ICarRepository
{
    public int SaveCar(Car car)
    {
        return 10;
    }
}