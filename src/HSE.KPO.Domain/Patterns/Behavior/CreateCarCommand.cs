using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Behavior;

public class CreateCarCommand : ICommand
{
    public Car Car { get; private set; }
    
    public void Execute()
    {
        Car = new Car(1);
    }

    public void Undo()
    {
        Console.WriteLine("Car is destroyed");
    }
}