namespace HSE.KPO.Console;

public class Driver
{
    public void SetCar(IDriverCar driverCar)
    {
        driverCar.Move();
    }
}