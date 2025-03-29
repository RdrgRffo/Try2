using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear instancias de la clase Persona
        Piloto p1 = new Piloto(21, "Pedro");
        Piloto p2 = new Piloto(22, "Jose");
        Piloto p3 = new Piloto(23, "Ana");
        Piloto p4 = new Piloto(24, "Maria");

        Coche c1 = new Coche(2345, "Dodge", 4);
        Coche c2 = new Coche(2346, "Mustang", 4);
        Coche c3 = new Coche(2347, "Supra", 5);
        Coche c4 = new Coche(2348, "Lexus", 4);

        c1.AñadeRueda(1234, "repuesto", 225);
        c1.AñadeRueda(1234, "nueva", 225);
        c2.AñadeRueda(1234, "nueva", 225);
        c3.AñadeRueda(1234, "usada", 225);
        c4.AñadeRueda(1234, "nueva", 225);

        Carrera carrera1 = new Carrera(4, 4);
        carrera1.Iniciar(4);

        carrera1.AñadirCoche(c1);
        carrera1.AñadirCoche(c2);
        carrera1.AñadirCoche(c3);
        carrera1.AñadirCoche(c4);

        carrera1.AñadirPiloto(p1);
        carrera1.AñadirPiloto(p2);
        carrera1.AñadirPiloto(p3);
        carrera1.AñadirPiloto(p4);

        Console.WriteLine("--- Pilotos ---");
        foreach (var piloto in carrera1.carrerita[0])
        {
            Console.WriteLine(piloto.Descripcion());
        }

        Console.WriteLine("--- Coches ---");
        foreach (var coche in carrera1.carrerita[1])
        {
            Console.WriteLine(coche.Descripcion());
        }
    }
}

interface ICarrera
{
    string GetNombre();
    string Descripcion();
}

class Rueda
{
    int modelo;
    string Estado;
    int tam;

    public Rueda(int modelo, string Estado, int tam)
    {
        this.modelo = modelo;
        this.Estado = Estado;
        this.tam = tam;
    }

    public override string ToString()
    {
        return $"Rueda: {modelo}, estado: {Estado}, tamaño: {tam}";
    }
}

class Coche : ICarrera
{
    private int Modelo;
    private string Marca;
    private int nRueda;
    private int contRueda;
    private Rueda[] ruedas;

    public Coche(int Modelo, string Marca, int nRueda)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.nRueda = nRueda;
        this.ruedas = new Rueda[nRueda];
        this.contRueda = 0;
    }

    public void AñadeRueda(int modelo, string Estado, int tam)
    {
        if (contRueda < nRueda)
        {
            ruedas[contRueda] = new Rueda(modelo, Estado, tam);
            contRueda++;
        }
        else
        {
            Console.WriteLine("No pueden ponerse más ruedas.");
        }
    }

    public string GetNombre()
    {
        return Marca;
    }

    public string Descripcion()
    {
        return $"Coche: {Marca}, Modelo: {Modelo}";
    }
}

class Piloto : ICarrera
{
    private int edad;
    private string nombre;

    public Piloto(int edad, string nombre)
    {
        this.edad = edad;
        this.nombre = nombre;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public string Descripcion()
    {
        return $"Piloto: {nombre}, Edad: {edad}";
    }
}

class Carrera
{
    private int nCoches;
    private int nPiloto;
    private int iPiloto = 0;
    private int iCoche = 0;

    public ICarrera[][] carrerita;

    public Carrera(int nCoches, int nPersonas)
    {
        this.nCoches = nCoches;
        this.nPiloto = nPersonas;
    }

    public void Iniciar(int nCoches)
    {
        this.carrerita = new ICarrera[2][];
        this.carrerita[0] = new ICarrera[nCoches];
        this.carrerita[1] = new ICarrera[nCoches];
    }

    public void AñadirPiloto(Piloto piloto)
    {
        if (iPiloto < nPiloto)
        {
            this.carrerita[0][iPiloto++] = piloto;
        }
        else
        {
            Console.WriteLine("No se pueden añadir más pilotos.");
        }
    }

    public void AñadirCoche(Coche coche)
    {
        if (iCoche < nCoches)
        {
            this.carrerita[1][iCoche++] = coche;
        }
        else
        {
            Console.WriteLine("No se pueden añadir más coches.");
        }
    }
}
