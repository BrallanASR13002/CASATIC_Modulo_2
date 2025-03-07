internal class Program
{
    private static void Main(string[] args)
    {
        Print("guardado un registro de usuarios en un archivo binario.");
        

    }
    public static string DataInput(string prompt)
    {
        string data;
        Print(prompt);
        data = Console.ReadLine();
        return data;
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