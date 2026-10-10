using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Repositories;

public interface ICarRepository
{
    public Car SaveCar(Car car);
}