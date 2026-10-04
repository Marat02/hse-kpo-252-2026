using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Creative;

public interface ICarFactory
{
    ICar CreateCar();
    
    IWheel CreateWheel();
}