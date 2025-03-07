internal class Program
{
    private static void Main(string[] args)
    {
        Print("matriz de números enteros y calcule la suma de cada fila");
        Print("Ingrese el número de filas de la matriz");
        int filas = 0;
        filas.DataInput();
        Print("Ingrese el número de columnas de la matriz");
        int columnas = 0;
        columnas = DataInput();
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = DataInput();
            }
        }
        for (int i = 0; i < filas; i++)
        {
            int suma = 0;
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
            Print($"La suma de la fila {i + 1} es: {suma}");

        }
    }
    public static int DataInpunt()
    {
        int number;
        Print("Ingrese un numero: ");
        string? data = Console.ReadLine();
        number = int.Parse(data);
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

