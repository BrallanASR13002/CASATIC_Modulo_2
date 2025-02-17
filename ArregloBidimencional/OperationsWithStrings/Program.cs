internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inserción");
        string primaryString = "Hola mundo";
        Console.WriteLine("Cadena Inicial: " + primaryString);
        string subString = ", ¡bienvenido!";
        int positionToInsert = 10;
        primaryString = primaryString.Insert(positionToInsert, subString);
        Console.WriteLine("Cadena resultante: " + primaryString);
        Console.WriteLine("\nBorrado");
        string primaryStringR = "Hola mundo cruel";
        Console.WriteLine("Cadena Inicial: " + primaryStringR);
        int position = 5;
        int amountString = 6;
        primaryStringR = primaryStringR.Remove(position, amountString);
        Console.WriteLine("Cadena resultante: " + primaryStringR);
        Console.WriteLine("\nReemplazo");
        string primaryString2 = "Hola mundo cruel";
        Console.WriteLine("Cadena Inicial: " + primaryString2);
        string subString2 = " cruel";
        primaryString2 = primaryString2.Replace(subString2, "");
        Console.WriteLine("Cadena resultante: " + primaryString2);
        Console.WriteLine("\nConversión");
        string stringExample = "12345";
        Console.WriteLine("Cadena inicial: "+stringExample);
        int numberExample = int.Parse(stringExample);
        Console.WriteLine("Cadena a entero: " + numberExample);
        float decimalExample = float.Parse(stringExample);
        Console.WriteLine("Cadena a flotante: " + decimalExample);
        Console.WriteLine("De mayuscula a minuscula");
        string capitalLetters = "HOLA MUNDO";
        Console.WriteLine("Cadena Inicial: "+capitalLetters);
        string  lowerLetters= capitalLetters.ToLower();
        Console.WriteLine("De mayúsculas a minúsculas: " + lowerLetters);
    }
}