using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena por teclado, indicar si las vocales aparecen (solo una vez por vocal)

        Console.WriteLine("Dame una cadena de caracteres para conocer qué vocales tiene:");
        string cadena = Console.ReadLine();

        cadena = cadena.ToLower(); // Convertir a minúsculas para facilitar la comparación

        // Variables para saber si una vocal ha sido encontrada
        bool tieneA = false, tieneE = false, tieneI = false, tieneO = false, tieneU = false;

        // Recorremos la cadena
        for (int i = 0; i < cadena.Length; i++)
        {
            // Si encontramos la vocal 'a' y no ha sido marcada como encontrada
            if (cadena[i] == 'a' && !tieneA)
            {
                tieneA = true; // Marcar que la vocal 'a' ha sido encontrada
                Console.WriteLine("La vocal 'a' aparece.");
            }
            // Repetimos el proceso para cada vocal
            if (cadena[i] == 'e' && !tieneE)
            {
                tieneE = true;
                Console.WriteLine("La vocal 'e' aparece.");
            }
            if (cadena[i] == 'i' && !tieneI)
            {
                tieneI = true;
                Console.WriteLine("La vocal 'i' aparece.");
            }
            if (cadena[i] == 'o' && !tieneO)
            {
                tieneO = true;
                Console.WriteLine("La vocal 'o' aparece.");
            }
            if (cadena[i] == 'u' && !tieneU)
            {
                tieneU = true;
                Console.WriteLine("La vocal 'u' aparece.");
            }
        }

    }
}
