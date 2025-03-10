internal class Program
{
    private static void Main(string[] args)
    {
        Print("Ejemplo de pruebas unitarias en una operación matemática");
        Print("División de dos numeros enteros");
    }
    public static int DataInput()
    {
        int number;
        string data;
        Print("Ingrese un numero: ");
        data = Console.ReadLine();
        while (!int.TryParse(data, out number) || number < 0)
        {
            Print("Ingrese un número válido (entero positivo o cero): ");
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
        Console.ForegroundColor = color;
        return message; 
        Console.WriteLine("Presione Enter para continuar ...");
        Console.ReadKey(); 
        Console.Clear();
    }
}