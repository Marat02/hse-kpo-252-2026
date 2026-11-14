using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Repositories;
using HSE.KPO.Application.Services;
using HSE.KPO.Domain.Models;
using MassTransit;
using Moq;

namespace HSE.KPO.Tests;

public class CarServiceTests
{
    private readonly Mock<ICarRepository> _carRepositoryMock = new();
    
    [Fact]
    public void CarServiceExisted_CreateCar_CarCreated()
    {
        // Arrange
        var carRepositoryMock = new Mock<ICarRepository>();
        carRepositoryMock.Setup(x => x.AddCar(It.IsAny<Car>())).Returns(new Car(1));

        var carService = new CarService(carRepositoryMock.Object, new Mock<IBus>().Object);
        
        // Act
        var result = carService.CreateCar(1, CancellationToken.None);
        
        // Assert
        Assert.NotNull(result);
        carRepositoryMock.Verify(x => x.AddCar(It.IsAny<Car>()), Times.Once);
    }
}