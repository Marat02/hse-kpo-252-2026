using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Creative;

public class CarFactory : ICarFactory
{
    private readonly int _id;

    public CarFactory(int id)
    {
        _id = id;
    }

    public ICar CreateCar()
    {
        if (_id <= 0)
            throw new ArgumentException("Id must be greater than 0");
            
        return new Car(_id);
    }

    public IWheel CreateWheel()
    {
        return new CarWheel();
    }
}