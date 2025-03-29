using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Concesionario concesionario = new Concesionario("MiConcesionario", "Madrid", "123456");

        Vehiculo coche1 = new Coche(150, 200, "Toyota Corolla");
        Vehiculo moto1 = new Moto(120, 50, "Yamaha R6");
        Vehiculo avion1 = new Avion(4000, 1000, "Boeing 747");

        // solucionar poder usar metodos de avion en variable vehiclo

        concesionario.AddCoche(coche1);
        concesionario.AddCoche(moto1);
        concesionario.AddCoche(avion1);

        concesionario.GetCoches();  // Imprime los vehículos en el concesionario

        coche1.Arrancar();
        moto1.Conducir();
        ((Avion)avion1).Aterrizar(); // Necesario casteo para acceder a métodos propios de Avión

        System.Console.WriteLine(Vehiculo.Contador);

    }
}

class Concesionario //tendria que hacer uno generico si quisiera list especifica de cada tipo de objeto
{
    private List<Vehiculo> almacenVehiculos; // Corregido nombre
    private string _nombre;
    private string _ubicacion;
    private string _cial;

    public Concesionario(string nombre, string ubicacion, string cial)
    {
        _nombre = nombre;
        _ubicacion = ubicacion;
        _cial = cial;
        almacenVehiculos = new List<Vehiculo>(); // Corregido error de sintaxis
    }

    public void AddCoche(Vehiculo vehiculo)
    {
        almacenVehiculos.Add(vehiculo); // Corregido nombre
    }

    public void GetCoches()
    {
        foreach (Vehiculo vehiculo in almacenVehiculos)
            Console.WriteLine(vehiculo); // Llamará a ToString() automáticamente
    }

    public string Nombre { get => _nombre; set => _nombre = value; }
    public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
    public string Cial { get => _cial; set => _cial = value; }
}

interface IVehiculos
{
    void Arrancar();
    void Parar();
    void Conducir(); // no se especifica si es virtual o no
}

class Vehiculo : IVehiculos
{
    private int _alto;
    private int _ancho;
    private string _color;
    private string _modelo;
    private bool _estado;

    public static int Contador = 0;

    public int Ancho { get => _ancho; set => _ancho = value; }
    public int Alto { get => _alto; set => _alto = value; }
    public string Color { get => _color; set => _color = value; }
    public string Modelo { get => _modelo; set => _modelo = value; }

    public Vehiculo(int alto, int ancho, string modelo)
    {
        _alto = alto;
        _ancho = ancho;
        _modelo = modelo;
        Contador++;
    }

    public void Arrancar()
    {
        Console.WriteLine($"{_modelo} arrancado.");
    }

    public void Parar()
    {
        Console.WriteLine($"{_modelo} detenido.");
    }

    public virtual void Conducir()
    {
        Console.WriteLine($"Conduciendo {_modelo}.");
    }

    public override string ToString()
    {
        return $"Modelo: {_modelo}, Alto: {_alto}, Ancho: {_ancho}";
    }
}

class Coche : Vehiculo
{
    private bool _tieneClaxon;
    private bool _esDescapotable;

    public Coche(int alto, int ancho, string modelo) : base(alto, ancho, modelo) { }

    public override void Conducir()
    {
        Console.WriteLine($"Conduciendo un coche: {Modelo}.");
    }
}

class Moto : Vehiculo
{
    public Moto(int alto, int ancho, string modelo) : base(alto, ancho, modelo) { }

    public override void Conducir()
    {
        Console.WriteLine($"Conduciendo una moto: {Modelo}.");
    }
}

class Avion : Vehiculo
{
    public Avion(int alto, int ancho, string modelo) : base(alto, ancho, modelo) { }

    public void Aterrizar()
    {
        Console.WriteLine($"El avión {Modelo} está aterrizando");
    }

    public void Despegando()
    {
        Console.WriteLine($"El avión {Modelo} está Despegando");
    }

    public override void Conducir()
    {
        Console.WriteLine($"Volando un avión: {Modelo}.");
    }
}
