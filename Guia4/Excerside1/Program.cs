internal class Program
{
    private static void Main(string[] args)
    {
        Print("división entre cero mediante bloques try-catch.");
        
        
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