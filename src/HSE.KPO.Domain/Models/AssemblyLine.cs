namespace HSE.KPO.Domain.Models;

public class AssemblyLine
{
    public Car CreateCar()
    {
        return new Car(1);
    }

    public HeavyCar CreateHeavyCar()
    {
        return new HeavyCar(2, 1000);
    }
    
    public Bike CreateBike()
    {
        return new Bike();
    }
}