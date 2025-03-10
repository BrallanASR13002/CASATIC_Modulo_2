internal class Program
{
    private static void Main(string[] args)
    {

    }
    public static double DataInput()
    {
        double number;
        string data;
        Print("Ingrese un numero: ");
        data = Console.ReadLine();
        while (!double.TryParse(data, out number) || number < 0)
        {
            Print("Ingrese un número válido (entero positivo o cero): ");
            data = Console.ReadLine();
        }
        return number;
    }
    public static void Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Presione Enter para continuar ...");
        Console.ReadLine();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
    }
}