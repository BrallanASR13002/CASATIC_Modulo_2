using System;

namespace TransposicionMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtener el tamaño de la matriz
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            // Crear la matriz original
            int[,] matrizOriginal = new int[filas, columnas];

            // Llenar la matriz original
            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizOriginal[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Crear la matriz transpuesta
            int[,] matrizTranspuesta = new int[columnas, filas];

            // Realizar la transposición
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizTranspuesta[j, i] = matrizOriginal[i, j];
                }
            }

            // Imprimir la matriz transpuesta
            Console.WriteLine("Matriz transpuesta:");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write($"{matrizTranspuesta[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}