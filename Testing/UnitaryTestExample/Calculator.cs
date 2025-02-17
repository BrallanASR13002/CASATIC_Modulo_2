/* The Calculator class in C# contains a method that calculates the sum of two integers. */
public class Calculator
{
    /// <summary>
    /// The Sum function in C# takes two integers as input and returns their sum.
    /// </summary>
    /// <param name="number1">The parameter `number1` is the first integer value that is passed to the
    /// `Sum` method for addition.</param>
    /// <param name="number2">The parameter `number2` is an integer value that is passed into the `Sum`
    /// method as an input parameter.</param>
    /// <returns>
    /// The Sum of `number1` and `number2` is being returned.
    /// </returns>
    public int Sum(int number1, int number2)
    {
        int result = 0;
        result = number1 + number2;
        return result;
    }
}