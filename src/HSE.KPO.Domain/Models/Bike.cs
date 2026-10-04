using HSE.KPO.Domain.Patterns.Behavior;

namespace HSE.KPO.Domain.Models;

public class Bike : IProduct, IObserver
{
    public int SerialNumber { get; }

    public void Execute()
    {
        Console.WriteLine("Bike is working");
    }
}