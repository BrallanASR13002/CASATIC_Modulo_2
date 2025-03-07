internal class Program
{
    private static void Main(string[] args)
    {
        Print("Recursividad de funciones: cálculo de un Factorial de un número");
        
    }
        public static int DataInput()
    {
        int number;
        string data;
        Print("Ingrese un numero: ");
        data = Console.ReadLine();
        while (!int.TryParse(data, out number))
        {
            Print("Ingrese un numero valido: ");
            data = Console.ReadLine();
        }
        return number;
    }
    public static string Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
        return message;
    }
}