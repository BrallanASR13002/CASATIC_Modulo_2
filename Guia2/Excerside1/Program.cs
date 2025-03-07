internal class Program
{
    private static void Main(string[] args)
    {
        string data;
        data = DataInput();
        Print("Conteo del numero de palabras en una cadena");
        Print($"La cantidad de palabras en la cadena es: {CountWords(data)}");
    }
     public static string DataInput()
        {
            string data;
            Print("Ingrese un numero: ");
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