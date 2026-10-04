namespace HSE.KPO.Domain.Patterns.Behavior;

public class StartupStrategy : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Startup strategy");
    }
}