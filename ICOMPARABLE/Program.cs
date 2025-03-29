using System;
using System.Collections.Generic;

class Persona : IComparable<Persona>
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Implementación de IComparable<Persona> comparando por edad y luego por nombre
    public int CompareTo(Persona otra)
    {
        if (otra == null) return 1;

        // Comparar por edad
        int resultado = Edad.CompareTo(otra.Edad);

        // Si las edades son iguales, comparar por nombre (orden alfabético)
        if (resultado == 0)
        {
            resultado = Nombre.CompareTo(otra.Nombre);
        }

        return resultado;
    }

    public override string ToString()
    {
        return $"{Nombre}, {Edad} años";
    }
}

class Program
{
    static void Main()
    {
        List<Persona> personas = new List<Persona>
        {
            new Persona("Carlos", 30),
            new Persona("Ana", 25),
            new Persona("Luis", 35),
            new Persona("Elena", 28),
            new Persona("Beatriz", 25),  // Misma edad que Ana, prueba de comparación por nombre
            new Persona("David", 30)    // Misma edad que Carlos, prueba de comparación por nombre
        };

        Console.WriteLine("Lista original:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }

        // Ordenar la lista usando IComparable
        personas.Sort();

        Console.WriteLine("\nLista ordenada por edad y luego por nombre:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }
    }
}
