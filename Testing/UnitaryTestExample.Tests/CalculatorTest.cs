/* This C# class contains a test method to verify the sum functionality of a Calculator class. */
using Xunit;
public class CalculatorTest
{
    /// <summary>
    /// The Sum function in the Calculator class is being tested to ensure that it correctly adds two
    /// numbers.
    /// </summary>
    [Fact]
    public void Sum()
    {
        var calculator = new Calculator();
        var result = calculator.Sum(3, 5);
        Assert.Equal(8, result);
    }
    [Fact]
    public void Sum_0_9()
    {
        var calculator = new Calculator();
        var result = calculator.Sum(0, 9);
        Assert.Equal(8, result);
    }
}