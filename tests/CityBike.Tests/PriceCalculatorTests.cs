using CityBike.Core;
using Xunit; 

namespace CityBike.Tests; 

public class PriceCalculatorTests
{
    private readonly PriceCalculator _calculator = new();

    [Fact]    
    public void Calculate_18Minutes_Returns55()    
    {        
        decimal price = _calculator.Calculate(18 * 60);         
        Assert.Equal(55m, price);    
    }

    [Fact]
    public void Calculate_0Seconds_ReturnsUnlockFee10()
    {
        const int zeroSecondTrip = 0;

        var result = _calculator.Calculate(zeroSecondTrip);

        Assert.Equal(PriceCalculator.UnlockFee, result);
    }

    [Fact]
    public void Calculate_100Minutes_ReturnsMaxPrice250()
    {
        const int hundredMinuteTrip = 6000;

        var result = _calculator.Calculate(hundredMinuteTrip);

        Assert.Equal(PriceCalculator.MaxPrice, result);
    }

    [Fact]
    public void Calculate_61Seconds_Returns15()
    {
        const int sixtyOneSecondTrip = 61;

        var result = _calculator.Calculate(sixtyOneSecondTrip);

        Assert.Equal(15, result);
    }

    [Fact]
    public void Calculate_NegativeSeconds_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Calculate(-1));
    }
}