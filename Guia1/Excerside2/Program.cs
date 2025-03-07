internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("transposición de una matriz");
        Print("Ingrese el número de filas de la matriz");
        int filas = DataInput();
        Print("Ingrese el número de columnas de la matriz");
        int columnas = DataInput();
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Print($"Ingrese el valor de la fila {i + 1} en la columan {j + 1}");
                matriz[i, j] = DataInput();
            }
        }
        Print("Matriz original");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Print(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Print("Matriz transpuesta");
        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                Print(matriz[j, i] + " ");
            }
            Console.WriteLine();
        }
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