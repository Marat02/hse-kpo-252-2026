using HSE.KPO.Domain.Patterns;

namespace HSE.KPO.Domain.Models;

public class AssemblyLine
{
    private readonly ICarBuilder _carBuilder;
    private readonly TruckBuilder _truckBuilder;

    public AssemblyLine(ICarBuilder carBuilder, TruckBuilder truckBuilder)
    {
        _carBuilder = carBuilder;
        _truckBuilder = truckBuilder;
    }

    public Car CreateCar()
    {
        return new Car(1);
    }

    public TruckCar CreateHeavyCar()
    {
        return (TruckCar)_truckBuilder.Build();
    }
    
    public Bike CreateBike()
    {
        return new Bike();
    }

    public ICar[] BuildCars()
    {
        _carBuilder.SetId(1);
        _carBuilder.SetWheels(new IWheel[4]);
        _carBuilder.SetEngine(new Engine(1));
        var car = _carBuilder.Build();
        
        _carBuilder
            .SetId(2)
            .SetWheels(new IWheel[4])
            .SetEngine(new Engine(1));

        var car2 = _carBuilder.Build();

        var car3 = new CarDirector(_carBuilder).BuildCar();
        return [car, car2, car3];
    }
}