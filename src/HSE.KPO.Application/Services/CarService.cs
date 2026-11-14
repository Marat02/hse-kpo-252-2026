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

    public async Task<Car> CreateCar(int id, CancellationToken cancellationToken)
    {
        var car = new Car(id);
        
        Console.WriteLine($"Car created with id: {car.Id}");
        var result = _carRepository.AddCar(car);

        await _bus.Publish(new CarCreatedEvent(car.Id), cancellationToken);

        await _carRepository.SaveChangesAsync(cancellationToken);
        return car;
    }

    public async Task<Car> GetCar(int id, CancellationToken cancellationToken)
    {
        var car = await _carRepository.GetCar(id, cancellationToken);
        
        return car ?? throw new Exception("Car not found");
    }
}