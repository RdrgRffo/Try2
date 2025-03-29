using System;
using System.Linq; // Necesario para algunas funciones

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 3, 8, 1, 9, 2 };

        Console.WriteLine("Array original:");
        MostrarArray(numeros);

        // Propiedades
        Console.WriteLine("\nLongitud del array: " + numeros.Length);
        Console.WriteLine("Primer elemento: " + numeros.First());
        Console.WriteLine("Último elemento: " + numeros.Last());

        // Métodos
        Array.Sort(numeros);
        Console.WriteLine("\nArray ordenado:");
        MostrarArray(numeros);

        Array.Reverse(numeros);
        Console.WriteLine("\nArray en orden inverso:");
        MostrarArray(numeros);

        int max = numeros.Max();
        int min = numeros.Min();
        Console.WriteLine($"\nMáximo: {max}, Mínimo: {min}");

        int valorBuscado = 5;
        int indice = Array.IndexOf(numeros, valorBuscado);

        if (indice != -1)
            Console.WriteLine($"El número {valorBuscado} está en el índice {indice}.");
        else
            Console.WriteLine($"El número {valorBuscado} no está en el array.");

            //---- COPY

        int[] arrayOriginal = { 10, 20, 30, 40, 50 };
        int[] arrayCopia = new int[5];  // Array de destino con el mismo tamaño

        // Copiar los elementos del array original al nuevo array
        Array.Copy(arrayOriginal, arrayCopia, arrayOriginal.Length);
    }

    static void MostrarArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
