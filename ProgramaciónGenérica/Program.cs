using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        ManejoDateTime();
        ManejoGenericos();
    }

    private static void ManejoDateTime()
    {
        Console.WriteLine("=== Manejo de DateTime ===");

        List<DateTime> fechas = new List<DateTime>
        {
            new DateTime(2025, 3, 23),
            new DateTime(2022, 12, 25),
            new DateTime(2023, 5, 1)
        };

        foreach (var fecha in fechas)
        {
            Console.WriteLine("Fecha almacenada: " + fecha.ToString("dd/MM/yyyy"));
        }

        TimeSpan diferencia = fechas[0] - fechas[1];
        Console.WriteLine("Diferencia entre fechas: " + diferencia.Days + " días");

        Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
    }

    private static void ManejoGenericos()
    {
        Console.WriteLine("\n=== Manejo de Almacén Genérico con ISalario ===");

        AlmacenObjetosGenericos<ISalario> empleados = new AlmacenObjetosGenericos<ISalario>(3);
        empleados.AddObjeto(new Director(7000));
        empleados.AddObjeto(new Ingeniero(5000));
        empleados.AddObjeto(new Secretaria(3000));

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Salario del objeto " + (i + 1) + ": " + empleados.GetObjeto(i)?.getSalario());
        }
    }
}

// Interfaz ISalario\interface ISalario
{
    double getSalario();
}

// Implementaciones de ISalario
class Director : ISalario
{
    private double salario;
    public Director(double s) => salario = s;
    public double getSalario() => salario;
}

class Secretaria : ISalario
{
    private double salario;
    public Secretaria(double s) => salario = s;
    public double getSalario() => salario;
}

class Ingeniero : ISalario
{
    private double salario;
    public Ingeniero(double s) => salario = s;
    public double getSalario() => salario;
}

// Clase genérica
class AlmacenObjetosGenericos<T> where T : ISalario
{
    private List<T> datosElemento = new List<T>();

    public AlmacenObjetosGenericos(int capacidadInicial)
    {
        datosElemento.Capacity = capacidadInicial;
    }

    public void AddObjeto(T obj)
    {
        datosElemento.Add(obj);
    }

    public T GetObjeto(int i)
    {
        if (i >= 0 && i < datosElemento.Count)
        {
            return datosElemento[i];
        }
        else
        {
            Console.WriteLine("Índice fuera de rango.");
            return default;
        }
    }
}
