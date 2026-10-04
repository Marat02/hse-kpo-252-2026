namespace HSE.KPO.Domain.Patterns.Behavior.State;

public class MaintenanceState : IState
{
    public IState StartWorking()
    {
        return this;
    }

    public IState StopWorking()
    {
        return this;
    }

    public IState Prepare()
    {
        return new ReadyState();
    }
    
    public IState Maintain()
    {
        return this;
    }
}