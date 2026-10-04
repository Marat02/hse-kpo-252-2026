using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Creative;

public class CarSingleton
{
    private static Car? _instance;

    public ICar GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Car(1);
        }

        return _instance;
    }
}