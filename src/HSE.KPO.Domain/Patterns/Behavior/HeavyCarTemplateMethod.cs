using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Behavior;

public class HeavyCarTemplateMethod : ITemplateMethod
{
    private readonly TruckCar _car;

    public HeavyCarTemplateMethod(TruckCar car)
    {
        _car = car;
    }

    public void AddBody()
    {
        Console.WriteLine("Adding heavy body");
    }

    public void AddWheels()
    {
        Console.WriteLine("Adding heavy wheels");
    }

    public void AddDoors()
    {
        Console.WriteLine("Adding heavy doors");
    }
}