using System;

internal class Program
{   
    // Variable global para almacenar la entrada
    static string input = "";

    private static void Main(string[] args)
    {
        Print("Documentation example");

        // Asignar nuevo dato a la variable input
        input = Input().ToString(); // Convertimos a string para mantener compatibilidad
        Print("User input: " + input);
    }

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

    public static void Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
    }
}
