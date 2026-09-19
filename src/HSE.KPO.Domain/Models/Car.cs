namespace HSE.KPO.Domain.Models;

public class Car : IProduct, IDriverCar
{
    public Car(int id)
    {
        Id = id;
        Color = 0;
    }
    
    public int Id { get; private set; }

    public int Color { get; private set; }

    public virtual void Move()
    {
        System.Console.WriteLine("Moving");
    }

    public int SerialNumber { get; }
}