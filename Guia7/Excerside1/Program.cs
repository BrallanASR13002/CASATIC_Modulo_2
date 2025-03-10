internal class Program
{
    private static void Main(string[] args)
    {
        Print("Uso de variables globales");
        Print("Sobrecarga de metodos: ");
        Print("Suma de numeros enteros: ");
        //global variables
        int number1 = Input01();
        int number2 = Input01();
        int result = Suma(number1, number2);
        Print("El resultado es: ");
        Print(result.ToString());
        Print("Suma de numeros reales");
        //global vars
        double number3 = Input02();
        double number4 = Input02();
        double result2 = Suma(number3, number4);
        Print("El resultado es: ");
        Print(result2.ToString());
    }
    public static double Input02()
    {
        //local variables
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
    public static int Input01()
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
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
        return message;
    }
    public static int Suma(int number1, int number2)
    {
        int suma = number1 + number2;
        return suma;
    }
    public static double Suma(double number3, double number4)
    {
        double suma = number3 + number4;
        return suma;
    }
}