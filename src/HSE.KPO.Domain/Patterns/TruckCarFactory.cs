using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns;

public class TruckCarFactory : ICarFactory
{
    private readonly int _id;
    private readonly int _weight;

    public TruckCarFactory(int id, int weight)
    {
        _weight = weight;
        _id = id;
    }

    public ICar CreateCar()
    {
        if (_id <= 0)
            throw new ArgumentException("Id must be greater than 0");
        
        return new TruckCar(_id, _weight, new Engine(1), new IWheel[4]);
    }

    public IWheel CreateWheel()
    {
        return new TruckWheel();
    }
}