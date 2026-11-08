namespace HSE.KPO.Domain.Models;

public class CarView
{
    private readonly List<ICarViewPushEvent> _subs = [];
    public int Counter { get; private set; } = 0;

    public void AddSub(ICarViewPushEvent carViewPushEvent)
    {
        _subs.Add(carViewPushEvent);
    }
    
    public void Push()
    {
        foreach (var sub in _subs)
        {
            sub.Pushed();
        }
    }

    public void SetCounter(int carMoveCount)
    {
        Counter = carMoveCount;
    }
}

public interface ICarViewPushEvent
{
    public void Pushed();
}