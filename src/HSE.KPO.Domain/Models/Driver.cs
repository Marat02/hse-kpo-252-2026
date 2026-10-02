namespace HSE.KPO.Domain.Models;

public class Driver
{
    public void SetCar(ICar driverCar)
    {
        driverCar.Move();
    }
}