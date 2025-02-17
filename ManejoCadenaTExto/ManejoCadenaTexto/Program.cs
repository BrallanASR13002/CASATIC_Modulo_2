//definiendo primer cadena de caracteres
string prayer1 = "Anita lava la Tina";
//definiendo segunda cadena de caracteres
string prayer2 = "anita lava las tinas";
Console.Write("Manejo de cadena de caracteres avanzado: \n");
Console.Write("Comparacion de cadena de caracteres:\n");
bool result = prayer1.Equals(prayer2);
if (result == true)
{
    Console.Write($"{prayer1} es igual a {prayer2}");
}
else
{
    Console.Write($"{prayer1} no es igual a {prayer2}");
}
Console.Write("\n#######################################################################\n");
Console.Write("Manejo de cadena de caracteres avanzado: \n");
Console.Write("Comparacion de cadena de caracteres ignorando mayusculas y minusculas:\n");
bool result2 = prayer1.Equals(prayer2, StringComparison.OrdinalIgnoreCase);
if (result2 ==true)
{
    Console.Write($"{prayer1} es igual a {prayer2}");
}
else
{
    Console.Write($"{prayer1} no es igual a {prayer2}");
}
Console.Write("\n#######################################################################\n");
Console.Write("Manejo de cadena de caracteres avanzado: \n");
Console.Write("Comparacion de cadena de caracteres con desigualdad:\n");
bool result3 = prayer1 !=  prayer2;
if (result3 !=true)
{
    Console.Write($"{prayer1} es igual a {prayer2}");
}
else
{
    Console.Write($"{prayer1} no es igual a {prayer2}");
}
Console.Write("\n#######################################################################\n");
Console.Write("Manejo de cadena de caracteres avanzado: \n");
Console.Write("Concatenacion de cadenas:\n");
string prayer3 = "buenos dias";
Console.Write("Cadena 1: "+ prayer3);
Console.Write("\n#######################################################################\n");
string prayer4 = "saludos cordiales";
Console.Write("Cadena 2: "+ prayer4);
Console.Write("\n#######################################################################\n");
Console.Write(prayer3+prayer4);