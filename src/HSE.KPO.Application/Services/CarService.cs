using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Repositories;
using HSE.KPO.CarAssembly.Public;
using HSE.KPO.Domain.Models;
using MassTransit;

namespace HSE.KPO.Application.Services;

public sealed class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IBus _bus;
    
    public CarService(ICarRepository carRepository, IBus bus)
    {
        _carRepository = carRepository;
        _bus = bus;
    }

    public Car CreateCar(int id)
    {
        var car = new Car(1);
        
        Console.WriteLine($"Car created with id: {car.Id}");
        var result = _carRepository.SaveCar(car);

        _bus.Publish(new CarCreatedEvent(car.Id)).GetAwaiter().GetResult();
        return car;
    }
}