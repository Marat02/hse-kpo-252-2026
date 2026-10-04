using FluentAssertions;
using HSE.KPO.Domain.Models;
using HSE.KPO.Domain.Patterns;
using HSE.KPO.Domain.Patterns.Creative;

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
        var weight = 2000;
        var builder = new TruckBuilder().SetEngine(new Engine(1)).SetWheels(new IWheel[4]).SetId(1).SetWeight(weight);
        var heavyCar = builder.Build();
        
        // Act
        var result = heavyCar.Carry();

        // Assert
        result.Should().Be(weight, because: "Carry should return the weight of the car");
    }
    
    [Fact]
    public void TruckCarExistedWith4Wheel_CarMove_MoveIsValid()
    {
        // Arrange
        var builder = new TruckBuilder().SetEngine(new Engine(1)).SetWheels(new IWheel[4]).SetId(1);
        var car = builder.Build();
        
        // Act
        car.Move();
    }
}