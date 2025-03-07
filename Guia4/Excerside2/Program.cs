internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public static string DataInput(string prompt)
    {
        Print(prompt);
        return Console.ReadLine();
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