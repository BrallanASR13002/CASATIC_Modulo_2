internal class Program
{
    private static void Main(string[] args)
    {
        Print("Reemplazar una palabra en una frase");
        string data = DataInput();
        string wordToReplace = DataInput("Ingrese la palabra a reemplazar: ");
        string newWord = DataInput("Ingrese la nueva palabra: ");
        string result = ReplaceWord(data, wordToReplace, newWord);
        Print("La nueva frase es: "+result);
    }

    public static string DataInput()
    {
        string data;
        Print("Ingrese la frase: ");
        data = Console.ReadLine();
        return data;
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

    public static string ReplaceWord(string data, string wordToReplace, string newWord)
    {
        if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(wordToReplace) || string.IsNullOrEmpty(newWord))
        {
            return data;
        }

        return data.Replace(wordToReplace, newWord);
    }
}