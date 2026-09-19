using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Interfaces;

public interface ICarService
{
    Car CreateCar(int id);
}