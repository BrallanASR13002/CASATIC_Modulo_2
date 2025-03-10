using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Excerside2.Tests")]

internal class Program
{
    public static void Main(string[] args)
    {
        Print("Ejemplo de pruebas unitarias en una operación matemática");
        Print("División de dos numeros enteros");
        double number1 = DataInput();
        double number2 = DataInput();
        double result = Division(number1, number2);
        Console.WriteLine(result);
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
    public static double Division(double number1, double number2)
    {
        if (number2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN; // Retorna un valor especial indicando un error
        }
        return number1 / number2;
    }
}