internal class Program
{
    private static void Main(string[] args)
    {
        Print("División entre cero mediante bloques try-catch.");
        double a = DataInpunt("Ingrese el primer número:");
        double b = DataInpunt("Ingrese el segundo número (no puede ser cero):");
        
        try
        {
            double result = a / b;
            Print($"El resultado de la división es: {result}");
        }
        catch (DivideByZeroException)
        {
            Print("No se puede dividir entre cero.");
        }
    }

    public static double DataInpunt(string prompt)
    {
        double number;
        string data;
        while (true)
        {
            Print(prompt);
            data = Console.ReadLine();
            if (double.TryParse(data, out number))
            {
                return number;
            }
            else
            {
                Print("Entrada no válida. Por favor, ingrese un número.");
            }
        }
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