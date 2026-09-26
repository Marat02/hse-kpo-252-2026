using HSE.KPO.Domain.Models;
using HSE.KPO.Tests.Fixtures;
using Moq;

namespace HSE.KPO.Tests;

public class DriverTests : IClassFixture<DriverFixture>
{
    private readonly DriverFixture _driverFixture;

    public DriverTests(DriverFixture driverFixture)
    {
        _driverFixture = driverFixture;
    }

    [Fact]
    public void DriverExisted_SetCar_CarMoved()
    {
        // Arrange
        var driverCarMock = new Mock<IDriverCar>();
        var driver = new Driver();

        // Act
        driver.SetCar(driverCarMock.Object);

        // Assert
        driverCarMock.Verify(x => x.Move(), Times.Once);
    }

    [Fact]
    public void DriverExisted_SetCar_CarNotMovedWhenNull()
    {
        // Arrange
        var driver = new Driver();

        // Act
        var exception = Record.Exception(() => driver.SetCar(null!));

        // Assert
        Assert.NotNull(exception);
    }
}