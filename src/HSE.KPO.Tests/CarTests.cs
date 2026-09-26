using FluentAssertions;
using HSE.KPO.Domain.Models;

namespace HSE.KPO.Tests;

public class CarTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void HeavyCarExisted_CarCarry_WeightValid(int id)
    {
        // Arrange
        var weight = 1000;
        var heavyCar = new HeavyCar(id, weight);
        
        // Act
        var result = heavyCar.Carry();

        // Assert
        result.Should().Be(weight, because: "Carry should return the weight of the car");
    }
}