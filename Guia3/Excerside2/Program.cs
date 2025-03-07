using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "usuarios.dat";
        bool running = true;

        while (running)
        {
            Print("1. Agregar usuario\n2. Mostrar usuarios\n3. Salir\nSeleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                string nombre = DataInput("Ingrese nombre de usuario: ");
                string edad = DataInput("Ingrese edad: ");
                GuardarUsuario(filePath, nombre, edad);
            }
            else if (opcion == "2")
            {
                MostrarUsuarios(filePath);
            }
            else if (opcion == "3")
            {
                running = false;
            }
            else
            {
                Print("Opción no válida.");
            }
        }
    }

    public static string DataInput(string prompt)
    {
        Print(prompt);
        return Console.ReadLine();
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

    public static void GuardarUsuario(string filePath, string nombre, string edad)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Append)))
        {
            writer.Write(nombre);
            writer.Write(edad);
        }
        Print("Usuario guardado correctamente.");
    }

    public static void MostrarUsuarios(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                Print("Usuarios registrados:");
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string nombre = reader.ReadString();
                    string edad = reader.ReadString();
                    Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
                }
            }
        }
        else
        {
            Print("No hay usuarios registrados.");
        }
    }
}
