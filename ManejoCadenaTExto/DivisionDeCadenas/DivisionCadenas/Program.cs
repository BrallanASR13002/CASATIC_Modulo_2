Console.WriteLine("Subdivision de cadena de caracteres: \n");
string prayer = "tres tristes tigres, comen trigo en un trigal";
string[] dividers = prayer.Split(' ');
foreach (var divider in dividers)
{
    Console.WriteLine($"{divider}");
}
