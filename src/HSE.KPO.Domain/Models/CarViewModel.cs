namespace HSE.KPO.Domain.Models;

public class CarViewModel : ICarViewPushEvent
{
    private readonly Car _car;
    private readonly List<CarView> _carViews = [];

    public CarViewModel(Car car)
    {
        _car = car;
    }

    public void AddView(CarView view)
    {
        _carViews.Add(view);
    }

    public void Pushed()
    {
        _car.Move();
        foreach (var view in _carViews)
        {
            view.SetCounter(_car.MoveCount);
        }
    }
}