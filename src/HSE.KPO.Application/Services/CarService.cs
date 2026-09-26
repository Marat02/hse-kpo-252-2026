using HSE.KPO.Application.Interfaces;
using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Services;

public sealed class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    
    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public Car CreateCar(int id)
    {
        var car = new Car(1);
        
        Console.WriteLine($"Car created with id: {car.Id}");
        var result = _carRepository.SaveCar(car);

        return car;
    }
}