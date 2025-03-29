using System;

struct Direccion
{
    public string Calle;
    public int Numero;
    public string Ciudad;

    public Direccion(string calle, int numero, string ciudad)
    {
        Calle = calle;
        Numero = numero;
        Ciudad = ciudad;
    }

    public void MostrarDireccion()
    {
        Console.WriteLine($"Dirección: {Calle} #{Numero}, {Ciudad}");
    }
}

class Persona
{
    public string Nombre;
    public int Edad;
    public Direccion Domicilio; // El struct es un campo de la clase

    public Persona(string nombre, int edad, Direccion domicilio)
    {
        Nombre = nombre;
        Edad = edad;
        Domicilio = domicilio;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        Domicilio.MostrarDireccion();
    }
}

class Program
{
    static void Main()
    {
        // Crear un struct de dirección
        Direccion direccion = new Direccion("Avenida Siempre Viva", 742, "Springfield");

        // Crear un objeto de Persona usando el struct
        Persona persona1 = new Persona("Homer Simpson", 39, direccion);

        // Mostrar información
        persona1.MostrarInformacion();
    }
}

/*  
    ✔️ Sí, los structs pueden ser usados dentro de clases como campos o propiedades.
    ✔️ Son útiles para agrupar datos pequeños e inmutables dentro de una clase más compleja.
    ✔️ Recuerda que los structs son tipos de valor y se copian cuando se asignan a otro objeto, a diferencia de las clases que son tipos de referencia.
*/