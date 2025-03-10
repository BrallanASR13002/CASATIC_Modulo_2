using System;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void Division_DivideSixByTwo_ReturnsThree()
    {
        // Arrange
        double number1 = 6;
        double number2 = 2;
        
        // Act
        double result = Program.Division(number1, number2);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Division_DivideByZero_ReturnsNaN()
    {
        // Arrange
        double number1 = 5;
        double number2 = 0;
        
        // Act
        double result = Program.Division(number1, number2);

        // Assert
        Assert.True(double.IsNaN(result));
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(9, 3, 3)]
    [InlineData(100, 10, 10)]
    public void Division_ValidInputs_ReturnsExpectedResult(double num1, double num2, double expected)
    {
        // Act
        double result = Program.Division(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
}
