namespace HSE.KPO.Domain.Patterns.Behavior.State;

public class WorkingStatus : IState
{
    public IState StartWorking()
    {
        return this;
    }

    public IState StopWorking()
    {
        return new StoppedStatus();
    }

    public IState Prepare()
    {
        return this;
    }
    
    public IState Maintain()
    {
        return this;
    }
}