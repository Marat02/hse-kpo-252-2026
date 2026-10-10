using System.Text.Json;
using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Repositories;
using HSE.KPO.Domain.Models;

namespace HSE.KPO.Infrastructure;

public class Repository : ICarRepository
{
    private IFileWriter _fileWriter;

    public Repository(IFileWriter fileWriter)
    {
        _fileWriter = fileWriter;
    }

    public Car SaveCar(Car car)
    {
        var jsonCar = JsonSerializer.Serialize(car);
        _fileWriter.Write(jsonCar, "car.json");
        return car;
    }
    
    
    
}