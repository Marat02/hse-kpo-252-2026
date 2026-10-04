using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Creative;

public class TruckBuilder
{
    private int _id = 1;
    private IWheel[] _wheels = Array.Empty<IWheel>();
    private IEngine _engine = new Engine(1);
    private int _weight = 1000;
    
    public TruckBuilder SetId(int id)
    {
        _id = id;
        return this;
    }

    public TruckBuilder SetWheels(IWheel[] wheels)
    {
        _wheels = wheels;
        return this;
    }

    public TruckBuilder SetEngine(IEngine engine)
    {
        _engine = engine;
        return this;
    }

    public TruckBuilder SetWeight(int weight)
    {
        _weight = weight;
        return this;
    }

    public TruckCar Build()
    {
        return new TruckCar(_id, _weight, _engine, _wheels);
    }
}