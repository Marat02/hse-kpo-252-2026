// See https://aka.ms/new-console-template for more information

using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Services;
using HSE.KPO.Infrastructure;
using HSE.KPO.Infrastructure.Extensions;
using HSE.KPO.Sales.Application;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<ICarService, CarService>();
serviceCollection.AddCarsInfrastructure();
serviceCollection.AddTransient<IFileWriter, FileWriterProxy>();
serviceCollection.AddMassTransit(x =>
{
    x.AddConsumers(typeof(ISalesApplicationMarker).Assembly);
    x.UsingInMemory((context, configurator) => configurator.ConfigureEndpoints(context));
});

var provider = serviceCollection.BuildServiceProvider();

var busControl = provider.GetRequiredService<IBusControl>();
await busControl.StartAsync();

// Сборка машин
// Машина - механизм для перемещения по дороге

// Тяжелая машина - машина, которая может перевозить грузы

// Водитель - человек, который управляет машиной

// Сборочная линия - механизм, производящий машины


//Продажи
// Машина - товар, который продается

// Счет - документ, который содержит информацию о продаже

// Клиент - человек, который покупает товар