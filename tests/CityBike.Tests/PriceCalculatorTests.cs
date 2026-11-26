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
}