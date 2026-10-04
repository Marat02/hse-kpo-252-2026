namespace HSE.KPO.Domain.Patterns.Behavior;

public class DiffStartupStrategy : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Diff startup strategy");
    }
}