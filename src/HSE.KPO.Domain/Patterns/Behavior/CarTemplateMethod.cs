using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Behavior;

public class CarTemplateMethod : ITemplateMethod
{
    private Car _car;

    public CarTemplateMethod(Car car)
    {
        _car = car;
    }

    public void AddBody()
    {
        Console.WriteLine("Adding body");
    }

    public void AddWheels()
    {
        Console.WriteLine("Adding wheels");
    }

    public void AddDoors()
    {
        Console.WriteLine("Adding doors");
    }
}