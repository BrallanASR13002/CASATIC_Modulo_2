// See https://aka.ms/new-console-template for more information
/* This C# code snippet is prompting the user to input two numbers, reading those inputs, creating an
instance of a `Calculator` class, and then calling the `Sum` method of the `Calculator` class to
calculate the sum of the two numbers entered by the user. Finally, it prints out the total sum to
the console. */
Console.WriteLine("ingrese un numero: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el otro numero: ");
int number2 = int.Parse(Console.ReadLine());
var calculator = new Calculator();
/* The line `Console.WriteLine($"Total> {calculator.Sum(number1,number2)}");` is printing the total sum
of the two numbers entered by the user. It is using string interpolation to include the result of
calling the `Sum` method of the `Calculator` class with `number1` and `number2` as arguments within
the output message. */
Console.WriteLine($"Total> {calculator.Sum(number1, number2)}");