namespace HSE.KPO.Domain.Models;

public class Button : HSE.KPO.Domain.Patterns.Behavior.IObservable
{
    private List<HSE.KPO.Domain.Patterns.Behavior.IObserver> _observers = new();
    
    public void AddObserver(HSE.KPO.Domain.Patterns.Behavior.IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(HSE.KPO.Domain.Patterns.Behavior.IObserver observer)
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