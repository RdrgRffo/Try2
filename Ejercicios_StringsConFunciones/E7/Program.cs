using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Pedir al usuario que introduzca 10 números entre 1 y 20 separados por un espacio
        Console.WriteLine("Introduce 10 números enteros entre 1 y 20, separados por un espacio:");

        // Leer la entrada del usuario
        string entrada = Console.ReadLine();

        // Dividir la entrada en un array de strings
        string[] numerosStr = entrada.Split(' ');

        // Validar que el usuario introdujo exactamente 10 números
        if (numerosStr.Length != 10)
        {
            Console.WriteLine("Error: Debes introducir exactamente 10 números separados por un espacio.");
            return;
        }

        // Convertir los números a enteros
        int[] numeros = new int[10];
        for (int i = 0; i < 10; i++)
        {
            try
            {
                int numero = Convert.ToInt32(numerosStr[i]);

                // Validar que los números están entre 1 y 20
                if (numero < 1 || numero > 20)
                {
                    Console.WriteLine($"Error: El número {numero} no está entre 1 y 20.");
                    return;
                }

                numeros[i] = numero;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: '{numerosStr[i]}' no es un número válido.");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Error: '{numerosStr[i]}' está fuera del rango de los números enteros.");
                return;
            }
        }

        // Mostrar las barras de asteriscos con un bucle anidado
        Console.WriteLine("\nRepresentación con barras de asteriscos:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{numeros[i]}: ");
            for (int j = 0; j < numeros[i]; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Salto de línea después de cada barra
        }
    }
}
