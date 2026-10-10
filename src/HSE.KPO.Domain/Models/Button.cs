namespace HSE.KPO.Domain.Models;

public class Button : Patterns.Behavior.IObservable
{
    private List<Patterns.Behavior.IObserver> _observers = new();
    
    public void AddObserver(Patterns.Behavior.IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(Patterns.Behavior.IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Execute();
        }
    }
}