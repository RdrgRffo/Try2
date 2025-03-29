using System;

public class Program
{
    public static void Main()
    {
        // Leer la cantidad de segundos
        Console.Write("Introduce la cantidad de segundos: ");
        int segundos = Convert.ToInt32(Console.ReadLine());

        // Obtener los segundos restantes
        int segundosRestantes = segundos % 60;

        // Convertir los segundos a minutos
        int minutos = segundos / 60;

        // Obtener los minutos restantes
        int minutosRestantes = minutos % 60;

        // Convertir los minutos a horas
        int horas = minutos / 60;

        // Normalizar la hora en el rango de 0 a 23
        horas = horas % 24;

        // Mostrar la hora en formato h:mm:ss
        Console.WriteLine("Hora normalizada: {0:D2}:{1:D2}:{2:D2}", horas, minutosRestantes, segundosRestantes);
    }
}
