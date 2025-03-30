using System;
using System.Collections.Generic;

// --- Agregación ---
// La relación es "tiene un" pero los objetos pueden existir independientemente.
// Ejemplo: Universidad y Estudiantes. Un Estudiante puede existir sin una Universidad.
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Universidad
{
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    public void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }
}

// --- Composición ---
// La relación es "es parte de", lo que significa que si el objeto principal desaparece, los objetos internos también.
// Ejemplo: Casa y Habitaciones. Si la Casa es destruida, las Habitaciones dejan de existir.
class Habitacion
{
    public string Tipo { get; set; }
}

class Casa
{
    public List<Habitacion> Habitaciones { get; set; }

    public Casa()
    {
        Habitaciones = new List<Habitacion>
        {
            new Habitacion { Tipo = "Dormitorio" },
            new Habitacion { Tipo = "Cocina" },
            new Habitacion { Tipo = "Sala" }
        };
    }
}

// --- Asociación ---
// Relación sin dependencia de ciclo de vida. Los objetos interactúan entre sí pero pueden existir por separado.
// Ejemplo: Cliente y Pedido. Un Pedido está asociado a un Cliente, pero no depende de su existencia.
class Cliente
{
    public string Nombre { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

class Pedido
{
    public string Producto { get; set; }
    public Cliente Cliente { get; set; }
}

// --- Programa Principal para pruebas ---
class Program
{
    static void Main()
    {
        // Agregación: Universidad y Estudiantes
        Universidad universidad = new Universidad();
        Estudiante estudiante1 = new Estudiante { Nombre = "Carlos", Edad = 22 };
        universidad.AgregarEstudiante(estudiante1);
        Console.WriteLine("Agregación: Universidad con estudiante " + estudiante1.Nombre);

        // Composición: Casa y Habitaciones
        Casa casa = new Casa();
        Console.WriteLine("Composición: Casa con " + casa.Habitaciones.Count + " habitaciones.");

        // Asociación: Cliente y Pedido
        Cliente cliente = new Cliente { Nombre = "Ana" };
        Pedido pedido = new Pedido { Producto = "Laptop", Cliente = cliente };
        cliente.Pedidos.Add(pedido);
        Console.WriteLine("Asociación: Cliente " + cliente.Nombre + " hizo un pedido de " + pedido.Producto);
    }
}
