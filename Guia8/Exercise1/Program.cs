internal class Program
{   //global vars
    static string input = "";
    private static void Main(string[] args)
    {
        Print("Documentation example");
        //assign a new data at input var
        input = Input();
        int integerInput = Convert(input);
        Print(integerInput.ToString());
    }
    public static string Input()
    {

        string data;
        Print("Enter a data: ");
        data = Console.ReadLine();
        return data;
    }
    public static int Convert(string data)
    {
        int number;
        while (true)
        {
            Print(data);
            data = Console.ReadLine();
            if (int.TryParse(data, out number))
            {
                return number;
            }
            else
            {
                Print("Invalid entry. Please enter a number.");
            }
        }
    }

    public static void Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
    }

}