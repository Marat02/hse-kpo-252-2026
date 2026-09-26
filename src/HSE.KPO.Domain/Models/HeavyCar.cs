namespace HSE.KPO.Domain.Models;

public class HeavyCar : Car
{
    public int Weight { get; private set; }

    public HeavyCar(int id, int weight) : base(id)
    {
        Weight = weight;
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