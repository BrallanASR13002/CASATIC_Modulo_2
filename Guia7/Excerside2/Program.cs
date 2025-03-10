internal class Program
{
    // static vars by the function calling count
    private static int callCounter = 0;
    private static void Main(string[] args)
    {
        Console.WriteLine("Input integer data:");
        int integer1 = int.Parse(Console.ReadLine());
        int integer2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum of integers: " + Sum(integer1, integer2));
        Console.WriteLine("number of calling by Sum: " + callCounter);

        Console.WriteLine("\nInput two numbers data:");
        double real1 = double.Parse(Console.ReadLine());
        double real2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Double's sum: " + Sum(real1, real2));
        Console.WriteLine("number of calling by Sum: " + callCounter);
    }
    //override the function by integers numbers
    static int Sum(int a, int b)
    {
        callCounter++;
        return a + b;
    }

    //override the function by double
    static double Sum(double a, double b)
    {
        callCounter++;
        return a + b;
    }
}
