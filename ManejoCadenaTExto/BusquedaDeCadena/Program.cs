Console.WriteLine("Busqueda en cadena de caracteres:\n");
string motivational_prayer = "No se trata de si van a derribarte, se trata de si vas a levantarte cuando lo hagan ";
Console.WriteLine($"{motivational_prayer}");
string word = "derribarte";
Console.WriteLine("\nBusqueda con Contains:");
bool contains_prayer = motivational_prayer.Contains(word);
if (contains_prayer == true)
{
    Console.WriteLine($"Se ha encontrado la palabra: {word}");
}
else
{
    Console.WriteLine($"No se ha encontrado la palabra: {word}");
}
Console.WriteLine("\nBusqueda con StartsWith:");
//agregar las expresiones: System.StringComparison.CurrentCultureIgnoreCase despues
//de word seguido de ,
bool contains_prayer1 = motivational_prayer.StartsWith(word, System.StringComparison.CurrentCultureIgnoreCase);
if (contains_prayer1 == true)
{
    Console.WriteLine($"Se ha encontrado la palabra: {word}");
}
else
{
    Console.WriteLine($"No se ha encontrado la palabra: {word}");
}
Console.WriteLine("\nBusqueda con EndWith:");
bool contains_prayer2 = motivational_prayer.EndsWith(word,System.StringComparison.CurrentCultureIgnoreCase);
if (contains_prayer2 == true)
{
    Console.WriteLine($"Se ha encontrado la palabra: {word}");
}
else
{
    Console.WriteLine($"No se ha encontrado la palabra: {word}");
}
string word1 = "Levantarte";

Console.WriteLine("\nBusqueda con IndexOf y LastIndexOf:");
int first = motivational_prayer.IndexOf(word)+word.Length;
int last = motivational_prayer.LastIndexOf(word)-word.Length;
//definiendo variable auxiliar
string aux1 =motivational_prayer.Substring(first,first-last);
Console.WriteLine($"La cadena resultante de {motivational_prayer} teniendo los parametros: \n {first} y {last} es:\n");
Console.WriteLine($"{aux1}");