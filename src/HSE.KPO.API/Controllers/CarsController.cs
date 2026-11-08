using HSE.KPO.Application.Interfaces;
using HSE.KPO.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HSE.KPO.API.Controllers;

[ApiController]
[Route("/api/cars")]
public class CarsController : Controller
{
    private readonly ICarService _carService;

    public CarsController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet]
    public async Task<IReadOnlyCollection<Car>> GetCars(CancellationToken cancellationToken)
    {
        var car = new Car(1);
        return [car];
    }
    
    [HttpGet("{id}")]
    public async Task<Car> GetCar([FromRoute] int id, CancellationToken cancellationToken)
    {
        var car = new Car(id);
        return car;
    }
}