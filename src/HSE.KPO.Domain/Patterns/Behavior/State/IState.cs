namespace HSE.KPO.Domain.Patterns.Behavior.State;

public interface IState
{
    IState StartWorking();

    IState StopWorking();

    IState Prepare();
    
    IState Maintain();
}