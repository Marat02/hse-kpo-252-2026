namespace HSE.KPO.Domain.Patterns.Behavior;

public interface IObservable
{
    void AddObserver(IObserver observer);
    
    void RemoveObserver(IObserver observer);
    
    void NotifyObservers();
}