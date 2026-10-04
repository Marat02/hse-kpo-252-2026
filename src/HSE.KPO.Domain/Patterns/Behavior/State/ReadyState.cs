namespace HSE.KPO.Domain.Patterns.Behavior.State;

public class ReadyState : IState
{
    public IState StartWorking()
    {
        return new WorkingStatus();
    }

    public IState StopWorking()
    {
        return this;
    }

    public IState Prepare()
    {
        return this;
    }
    
    public IState Maintain()
    {
        return new MaintenanceState();
    }
}