using System;

internal class Program
{
    // Global variable to store the input
    static string input = "";
    /// <summary>
    /// static method Main
    /// </summary>
    /// <param name="args">Flow the program</param>
    private static void Main(string[] args)
    {
        Print("Documentation example");

        // Assign new data to the input variable and
        //We convert to string to maintain compatibility
        input = Input().ToString(); 
        //print in terminal, the data entries
        Print("User input: " + input);
    } 
    /// <summary>
    /// function region
    /// </summary>
    /// <returns>none</returns>
    #region   
    //input function for convert a string input at integer output
    public static int Input()
    {
        string data;
        int number;

        while (true)
        {
            Print("Enter a number:");  // Mensaje fijo para solicitar entrada
            data = Console.ReadLine();

            if (int.TryParse(data, out number))
            {
                return number;
            }
            else
            {
                Print("Invalid entry. Please enter a valid number.");
            }
        }
    }
/// <summary>
/// Console Print in green color
/// </summary>
/// <param name="message">Terminal Output</param>
    public static void Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
    }
    #endregion
}
