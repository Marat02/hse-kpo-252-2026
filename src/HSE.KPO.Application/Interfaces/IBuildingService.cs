using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Interfaces;

public class IBuildingService
{
    private readonly ICarService _carService;
    private readonly IAssemblyLineService _assemblyLineService;

    public IBuildingService(ICarService carService, IAssemblyLineService assemblyLineService)
    {
        _carService = carService;
        _assemblyLineService = assemblyLineService;
    }

    public Car CreateCar(int id)
    {
        return _carService.CreateCar(id);
    }

    public AssemblyLine CreateAssemblyLine()
    {
        return _assemblyLineService.Create();
    }
}