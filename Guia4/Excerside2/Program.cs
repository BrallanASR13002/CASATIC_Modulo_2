internal class Program
{
    private static void Main(string[] args)
    {
        Print("excepción personalizada si un usuario ingresa un dato no válido.");
        string example = DataInput("Por favor, ingrese un dato:");
        Print(example);
    }

    public static string DataInput(string prompt)
    {
        Print(prompt);
        string input = string.Empty;
        try
        {
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("El dato ingresado no es válido.");
            }
        }
        catch (Exception ex)
        {
            Print($"Error: {ex.Message}");
        }
        return input;
    }

    public static string Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
        return message;
    }
}