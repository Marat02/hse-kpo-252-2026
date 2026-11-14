using HSE.KPO.API.Infos;
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
    
    [HttpPost]
    public async Task<Car> CreateCar([FromBody] CarInfo info, CancellationToken cancellationToken)
    {
        var car = await _carService.CreateCar(info.Id, cancellationToken);
        return car;
    }

    [HttpGet]
    public async Task<IReadOnlyCollection<Car>> GetCars(CancellationToken cancellationToken)
    {
        var car = new Car(1);
        return [car];
    }
    
    [HttpGet("{id:int}")]
    public async Task<Car> GetCar([FromRoute] int id, CancellationToken cancellationToken)
    {
        var car = await _carService.GetCar(id, cancellationToken);
        return car;
    }
}