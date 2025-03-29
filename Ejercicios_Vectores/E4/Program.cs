using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // // Solicitar 10 números distintos por teclado y mostrarlos
        // double[] numeros = new double[10];

        // Console.WriteLine("Programa que solicita 10 números distintos.");

        // for (int i = 0; i < 10; i++) // Ciclo para pedir 10 números
        // {
        //     double numero;  
        //     bool encontrado; // para la búsqueda lineal

        //     do
        //     {
        //         Console.Write("Dame un número: ");
        //         numero = Convert.ToDouble(Console.ReadLine());

        //         // Verificar si el número ya fue ingresado
        //         encontrado = false;
        //         for (int j = 0; j < i; j++)
        //         {
        //             if (numeros[j] == numero)
        //             {
        //                 encontrado = true;
        //                 Console.WriteLine("Ese número ya fue ingresado. Intenta con otro.");
        //             }
        //         }
        //     } while (encontrado); // Mientras el número ya esté en el arreglo

        //     // Almacenar el número en el arreglo
        //     numeros[i] = numero;
        // }

        // // Mostrar los números ingresados sin usar foreach
        // Console.WriteLine("Números ingresados:");
        // for (int i = 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine(numeros[i]);
        // }

        //Ahora como en clases......................................................

        int[] ListaNum = new int[10];
        int numero, posicion, numLeidos;

        Console.WriteLine($"Escribe el primer número en la posición");
        ListaNum[0] = Convert.ToInt32(Console.ReadLine());

        for (numLeidos = 1; numLeidos < ListaNum.Length; numLeidos++)
        {

            do
            {
                Console.WriteLine($"Escribe un número en la posición {numLeidos}");
                numero = Convert.ToInt32(Console.ReadLine());
                posicion = 0;

                while (posicion < numLeidos - 1 && numero != ListaNum[posicion])
                    posicion++;

            } while (numero == ListaNum[posicion]);
            ListaNum[numLeidos] = numero;
        }

        Console.WriteLine("numero introducidos");
        for (numLeidos = 0; numLeidos < ListaNum.Length; numLeidos++)
        {
            Console.WriteLine(ListaNum[numLeidos]);
        }

    }
}

//para hacer debugging hay que abrir un solo proyecto
//crea fichero de lanzamiento para net core
//puedes poner breakpoint al hacer debugging
//en el json se puede poner el paso a aso al run en debug
//al usar breakpoint se puede mover con el skip over paso a paso la ejecución
// al pararse encima se puedn ver los valores que lleva el array
