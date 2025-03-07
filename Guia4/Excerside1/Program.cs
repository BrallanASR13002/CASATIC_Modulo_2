internal class Program
{
    private static void Main(string[] args)
    {
        Print("división entre cero mediante bloques try-catch.");
        a = DataInpunt("Ingrese el dividendo: ");
        b = DataInpunt("Ingrese el divisor: ");
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
    public static double DataInpunt()
    {
        double number;
        string data;
        data = Console.ReadLine();
        number = Convert.ToDouble(data);
        return number;
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