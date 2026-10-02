using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns;

public class CarBuilder : ICarBuilder
{
    private int _id = 1;
    private IWheel[] _wheels = Array.Empty<IWheel>();
    private IEngine _engine = new Engine(1);
    
    public ICarBuilder SetId(int id)
    {
        _id = id;
        return this;
    }

    public ICarBuilder SetWheels(IWheel[] wheels)
    {
        _wheels = wheels;
        return this;
    }

    public ICarBuilder SetEngine(IEngine engine)
    {
        _engine = engine;
        return this;
    }

    public ICar Build()
    {
        return new Car(_id, _wheels, _engine);
    }
}