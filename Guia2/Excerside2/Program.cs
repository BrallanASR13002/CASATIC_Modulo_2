internal class Program
{
    private static void Main(string[] args)
    {

    }
    public static string DataInput()
    {
        string data;
        Print("Ingrese la frase: ");
        data = Console.ReadLine();
        return data;
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