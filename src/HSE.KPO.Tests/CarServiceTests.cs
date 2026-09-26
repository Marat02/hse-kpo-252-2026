using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Services;
using HSE.KPO.Domain.Models;
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
        carRepositoryMock.Setup(x => x.SaveCar(It.IsAny<Car>())).Returns(20);

        var carService = new CarService(carRepositoryMock.Object);
        
        // Act
        var result = carService.CreateCar(1);
        
        // Assert
        Assert.NotNull(result);
        carRepositoryMock.Verify(x => x.SaveCar(It.IsAny<Car>()), Times.Once);
    }
}