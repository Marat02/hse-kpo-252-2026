// See https://aka.ms/new-console-template for more information

using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Repositories;
using HSE.KPO.Application.Services;
using HSE.KPO.Infrastructure;
using HSE.KPO.Sales.Application;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<ICarService, CarService>();
serviceCollection.AddTransient<ICarRepository, Repository>();
serviceCollection.AddTransient<IFileWriter, FileWriterProxy>();
serviceCollection.AddMassTransit(x =>
{
    x.AddConsumers(typeof(ISalesApplicationMarker).Assembly);
    x.UsingInMemory((context, configurator) => configurator.ConfigureEndpoints(context));
});

var provider = serviceCollection.BuildServiceProvider();

var busControl = provider.GetRequiredService<IBusControl>();
await busControl.StartAsync();
try
{
    using var scope = provider.CreateScope();
    var carService = scope.ServiceProvider.GetRequiredService<ICarService>();

    carService.CreateCar(1);
}
finally
{
    await busControl.StopAsync();
}

// Сборка машин
// Машина - механизм для перемещения по дороге

// Тяжелая машина - машина, которая может перевозить грузы

// Водитель - человек, который управляет машиной

// Сборочная линия - механизм, производящий машины


//Продажи
// Машина - товар, который продается

// Счет - документ, который содержит информацию о продаже

// Клиент - человек, который покупает товар