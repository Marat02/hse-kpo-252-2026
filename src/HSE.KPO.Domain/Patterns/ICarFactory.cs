using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns;

public interface ICarFactory
{
    ICar CreateCar();
    
    IWheel CreateWheel();
}