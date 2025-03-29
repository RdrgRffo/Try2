public class Program
{
    public static void Main(string[] args)
    {
        //Solicitar 10 números por teclado y calcular su media aritmética.

        int num, suma, cont;
        float promedio;
        suma = 0;
        Console.WriteLine("Programa. Media de 10 números");
        Console.WriteLine("-----------------------------");

        for (cont = 1; cont <= 10; cont++)
        {

            Console.WriteLine("Dame un número para sumarlo");
            num = Convert.ToInt32(Console.ReadLine());
            suma = suma + num;
            Console.WriteLine($"llevamos {suma} y el contador es {cont}");

        }

        Console.WriteLine($"El resultado de la suma de los diez número es: {suma}");
        promedio = suma / (float)cont;
        Console.WriteLine($"El promedio es {promedio}");

    }
}

/*using System;

public class Programa
{
public static void Main(string[] args)
{

double[] numeros = new double[10];
double suma = 0;


for (int i = 0; i < 10; i++)
{
Console.WriteLine($"Ingrese el número {i + 1}:");
numeros[i] = Convert.ToDouble(Console.ReadLine());
suma += numeros[i];
}


double media = suma / 10;


Console.WriteLine($"La media aritmética es: {media}");
}
}*/