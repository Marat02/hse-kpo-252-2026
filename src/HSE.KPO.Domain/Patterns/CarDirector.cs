using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns;

public class CarDirector
{
    private readonly ICarBuilder _carBuilder;

    public CarDirector(ICarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
    }
    
    public ICar BuildCar()
    {
        _carBuilder.SetId(2);
        _carBuilder.SetWheels(new IWheel[4]);
        _carBuilder.SetEngine(new Engine(1));
        return _carBuilder.Build();
    }
}