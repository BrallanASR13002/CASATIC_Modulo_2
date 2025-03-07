internal class Program
{
    private static void Main(string[] args)
    {
        Print("lectura de un archivo de texto y muestre su contenido línea por línea");
        string path = DataInput("Ingrese la ruta del archivo: ");
        
        while (!System.IO.File.Exists(path))
        {
            Print("El archivo no existe. Por favor, ingrese una ruta válida.");
            path = DataInput("Ingrese la ruta del archivo: ");
        }

        string[] lines = System.IO.File.ReadAllLines(path);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
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