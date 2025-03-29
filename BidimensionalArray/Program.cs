using System;

class Program
{
    static void Main()
    {
        // Declaración e inicialización de un array bidimensional
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Recorriendo la matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)  // Filas
        {
            for (int j = 0; j < matriz.GetLength(1); j++)  // Columnas
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Modificar un valor en la matriz
        matriz[1, 1] = 50;
        Console.WriteLine("\nValor modificado en matriz[1,1]: " + matriz[1, 1]);

        // Buscar un valor en la matriz
        int buscar = 8;
        bool encontrado = false;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == buscar)
                {
                    Console.WriteLine($"\nEl número {buscar} se encuentra en la posición [{i},{j}].");
                    encontrado = true;
                    break;
                }
            }
            if (encontrado) break;
        }

        // Crear una copia de la matriz
        int[,] copiaMatriz = (int[,])matriz.Clone();

        Console.WriteLine("\nCopia de la matriz:");
        for (int i = 0; i < copiaMatriz.GetLength(0); i++)
        {
            for (int j = 0; j < copiaMatriz.GetLength(1); j++)
            {
                Console.Write(copiaMatriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
