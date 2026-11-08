using HSE.KPO.Domain.Models;

namespace HSE.KPO.MVC.Models;

public class CarViewModel
{
    public int Id { get; set; }

    public int SerialNumber { get; set; }

    public int MoveCount { get; set; }

    public static CarViewModel From(Car car) => new()
    {
        Id = car.Id,
        SerialNumber = car.SerialNumber,
        MoveCount = car.MoveCount
    };
}