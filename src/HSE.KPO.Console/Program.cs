// See https://aka.ms/new-console-template for more information

using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Services;
using HSE.KPO.DependencyInjector;
using Microsoft.Extensions.DependencyInjection;

var di = new DependencyInjector();

di.Register<ICarRepository>(di => new CarRepository());

di.Register<ICarService>(di => new CarService(di.Create<ICarRepository>()));

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<ICarService, CarService>();
serviceCollection.AddScoped<ICarRepository, CarRepository>();

var provider = serviceCollection.BuildServiceProvider();

var scope = provider.CreateScope();
var carService = scope.ServiceProvider.GetRequiredService<ICarService>();
var carService2 = scope.ServiceProvider.GetRequiredService<ICarService>();

var scope2 = provider.CreateScope();
var carService3 = scope2.ServiceProvider.GetRequiredService<ICarService>();

carService.CreateCar(1);

// Машина - механизм для перемещения по дороге

// Тяжелая машина - машина, которая может перевозить грузы

// Водитель - человек, который управляет машиной

// Сборочная линия - механизм, производящий машины

