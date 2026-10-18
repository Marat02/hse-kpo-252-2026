using HSE.KPO.CarAssembly.Public;
using HSE.KPO.Sales.Domain;
using MassTransit;

namespace HSE.KPO.Sales.Application;

public class CarCreatedEventConsumer : IConsumer<CarCreatedEvent>
{
    public async Task Consume(ConsumeContext<CarCreatedEvent> context)
    {
        var car = new Car(context.Message.Id);
        Console.WriteLine($"Sales car created with id: {car.Id}");
    }
}