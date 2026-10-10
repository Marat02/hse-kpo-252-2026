// See https://aka.ms/new-console-template for more information

using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Repositories;
using HSE.KPO.Application.Services;
using HSE.KPO.DependencyInjector;
using HSE.KPO.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<ICarService, CarService>();
serviceCollection.AddTransient<ICarRepository, Repository>();
serviceCollection.AddTransient<IFileWriter, FileWriterProxy>();

var provider = serviceCollection.BuildServiceProvider();

var scope = provider.CreateScope();
var carService = scope.ServiceProvider.GetRequiredService<ICarService>();

carService.CreateCar(1);

// Машина - механизм для перемещения по дороге

// Тяжелая машина - машина, которая может перевозить грузы

// Водитель - человек, который управляет машиной

// Сборочная линия - механизм, производящий машины