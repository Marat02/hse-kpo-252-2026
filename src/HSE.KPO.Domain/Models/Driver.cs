namespace HSE.KPO.Domain.Models;

public class Driver
{
    public void SetCar(IDriverCar driverCar)
    {
        driverCar.Move();
    }
}