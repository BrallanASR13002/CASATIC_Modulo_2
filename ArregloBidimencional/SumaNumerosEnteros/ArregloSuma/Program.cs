//Ejercicio 1 del modulo2 del Curso de Programacion en C# y Javascript
//Creado por: Brallan Sanchez
//fecha: 24/01/2025
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // Obtener el tamaño de la matriz del usuario
        Console.Write("Suma de los elementos de una fila de una matriz\n");
        Console.Write("Ingrese el número de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        // Crear la matriz
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con números enteros
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el elemento [{i}, {j}]: de la fila {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                }
            }
        }
        Console.Write("Resultados: \n");

        // Calcular y mostrar la suma de cada fila
        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }
            // Mostrar el resultado de forma amigable
            Console.Write($"La suma de ");
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine($"de la fila {i + 1} es de: {sumaFila}");
        }
    }
}