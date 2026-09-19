using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Interfaces;

public interface ICarRepository
{
    void SaveCar(Car car);
}

public class CarRepository : ICarRepository
{
    public void SaveCar(Car car)
    {
    }
}