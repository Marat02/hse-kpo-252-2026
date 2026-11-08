namespace HSE.KPO.Domain.Models;

public class Car : IProduct, ICar
{
    private readonly IEngine _engine;
    private readonly IWheel[] _wheels;
    
    public Car(int id, IWheel[] wheels, IEngine engine)
    {
        Id = id;
        _engine = engine;
        _wheels = wheels;
        Color = 0;
    }

    public Car(int id)
    {
        Id = id;
        _engine = new Engine(1);
        _wheels = new IWheel[4];
        Color = 0;
    }
    
    public int Id { get; private set; }

    public int Color { get; private set; }

    public int MoveCount { get; private set; } = 0;

    public virtual void Move()
    {
        Console.WriteLine("Moving");
        MoveCount++;
    }

    public int SerialNumber { get; }
}