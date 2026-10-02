namespace HSE.KPO.Domain.Models;

public class TruckCar : Car
{
    private readonly IEngine _engine;
    private readonly IWheel[] _wheels;
    
    public int Weight { get; private set; }

    public TruckCar(int id, int weight, IEngine engine, IWheel[] wheels) : base(id)
    {
        Weight = weight;
        _engine = engine;
        _wheels = wheels;
    }

    public override void Move()
    {
        base.Move();
        Console.WriteLine("Carrying a load");
    }

    public int Carry()
    {
        Console.WriteLine("Carrying");
        return Weight;
    }
}