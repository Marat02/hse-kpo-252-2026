using HSE.KPO.Domain.Patterns.Behavior;
using HSE.KPO.Domain.Patterns.Behavior.State;
using HSE.KPO.Domain.Patterns.Creative;

namespace HSE.KPO.Domain.Models;

public class AssemblyLine
{
    private readonly TruckBuilder _truckBuilder;
    private readonly IStrategy _strategy; 
    
    public AssemblyLineStatus Status { get; private set; }
    
    private IState _state;

    public AssemblyLine(TruckBuilder truckBuilder, IStrategy strategy)
    {
        Status = AssemblyLineStatus.Idle;
        _truckBuilder = truckBuilder;
        _strategy = strategy;
        _state = new ReadyState();
    }

    public Car CreateCar()
    {
        _state = _state.StartWorking();

        var car = new Car(1);
        _strategy.Execute();
        
        var templateMethod = new CarTemplateMethod(car);
        Assemble(templateMethod);
        
        var command = new CreateCarCommand();
        command.Execute();
        var testCar = command.Car;
        
        if (testCar.Id < 0)
            command.Undo();
        
        _state.StopWorking();
        return new Car(1);
    }

    public TruckCar CreateHeavyCar()
    {
        _state = _state.StartWorking();
        var car = _truckBuilder.SetId(1).SetWheels(new IWheel[4]).SetEngine(new Engine(1)).Build();
        var templateMethod = new HeavyCarTemplateMethod(car);
        
        Assemble(templateMethod);

        _state = _state.StopWorking();
        return (TruckCar)_truckBuilder.Build();
    }
    
    public Bike CreateBike()
    {
        return new Bike();
    }

    public void Stop()
    {
        _state = _state.StopWorking();
    }

    public void Prepare()
    {
        _state = _state.Prepare();
    }

    private void Assemble(ITemplateMethod templateMethod)
    {
        templateMethod.AddBody();
        templateMethod.AddWheels();
        templateMethod.AddDoors();
    }
}