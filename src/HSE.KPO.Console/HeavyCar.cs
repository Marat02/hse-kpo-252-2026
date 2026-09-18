namespace HSE.KPO.Console;

public class HeavyCar : Car
{
    public int Weight { get; private set; }

    public HeavyCar(int id) : base(id)
    {
        Weight = 0;
    }

    public override void Move()
    {
        base.Move();
        System.Console.WriteLine("Carrying a load");
    }

    public void Carry()
    {
        System.Console.WriteLine("Carrying");
    }
}