namespace HSE.KPO.Domain.Patterns.Behavior;

public interface ICommand
{
    void Execute();
    
    void Undo();
}