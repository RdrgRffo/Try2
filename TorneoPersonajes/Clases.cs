using System;

abstract class Personaje
{
    public string Name;
    private int _vida;
    public int MaxVida = 50;
    private int _nivel;
    private int _poder;
    public int MaxPoder = 20;
    private int _defensa;
    public int MaxDefensa = 50;
    private bool _especial = false;
    private bool _enDefensa = false;
    private int ContAtacks = 0;
    private Random r = new Random();

    public int Vida
    {
        get => _vida;
        set
        {
            if (value >= 1 && value <= MaxVida)
            {
                _vida = value;
            }
            else if (value > MaxVida) { _vida = MaxVida; }
            else { _vida = 20; }
        }
    }

    public int Nivel
    {
        get => _nivel;
        set
        {
            if (value >= 1 && value <= 10)
            {
                _nivel = value;
            }
            else if (value > 10) { _nivel = 10; }
            else { _nivel = 1; }
        }
    }

    public int Poder
    {
        get => _poder;
        set
        {
            if (value >= 1 && value <= MaxPoder)
            {
                _poder = value;
            }
            else if (value > MaxPoder) { _poder = MaxPoder; }
            else { _poder = 5; }
        }
    }

    public int Defensa
    {
        get => _defensa;
        set
        {
            if (value >= 1 && value <= MaxDefensa)
            {
                _defensa = value;
            }
            else { _defensa = 5; }
        }
    }

    public bool Especial => _especial;

    public Personaje() : this("Desconocido", 25, 1, 5, 5) { }

    public Personaje(string Nombre, int V, int N, int P, int D)
    {
        Name = Nombre;
        _especial = false;
        Vida = V;
        Nivel = N;
        Poder = P;
        Defensa = D;
    }

    public void ObtenerEspecial()
    {
        if (_vida > 50 && _poder > 10 && _nivel > 5)
        {
            _especial = true;
        }
    }

    public void SubeNivel()
    {
        ObtenerEspecial(); 
        _nivel++;
        MaxDefensa += 20;
        MaxPoder += 20;
        MaxVida += 20;
    }

    public bool Esquivar()
    {
        return r.Next(2) == 0;
    }

    public void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Name} ataca a {objetivo.Name} con {_poder} de poder.");

        if (objetivo.Esquivar())
        {
            Console.WriteLine($"{objetivo.Name} esquiva el ataque. ¡No recibe daño!");
        }
        else
        {
            objetivo.RecibirDanio(_poder);
        }
    }

    public void RecibirDanio(int danio)
    {
        if (_enDefensa)
        {
            if (_defensa >= danio)
            {
                _defensa -= danio;
                Console.WriteLine($"{Name} bloqueó el ataque. Defensa restante: {_defensa}");
            }
            else
            {
                int danioRestante = danio - _defensa;
                _defensa = 0;
                _vida -= danioRestante;
                Console.WriteLine($"{Name} sufrió daño tras romperse la defensa. Vida restante: {_vida}");
                DesactivarDefensa();
            }
        }
        else
        {
            _vida -= danio;
            Console.WriteLine($"{Name} recibió {danio} de daño directo. Vida restante: {_vida}");
        }

        if (_vida <= 0)
        {
            _vida = 0;
            Console.WriteLine($"{Name} ha sido derrotado.");
        }
    }

    public void ActivarDefensa()
    {
        _enDefensa = true;
        Console.WriteLine($"{Name} se pone en posición defensiva.");
    }

    public void DesactivarDefensa()
    {
        _enDefensa = false;
        Console.WriteLine($"{Name} baja la guardia.");
    }

    public abstract void AtaqueEspecial(Personaje objetivo);

    public override string ToString()
    {
        return $"Stats del personaje: {Name}\nNivel: {Nivel}\nVida: {Vida}\nDefensa: {Defensa}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Personaje otroPersonaje))
            return false;

        return Name == otroPersonaje.Name &&
               Vida == otroPersonaje.Vida &&
               Nivel == otroPersonaje.Nivel;
    }
}

// Clases derivadas
class Guerrero : Personaje, IBlade
{
    public override void AtaqueEspecial(Personaje objetivo)
    {
        if (Especial && Nivel > 7 && Poder > 25 && objetivo.Vida > 0)
        {
            Console.WriteLine($"¡{Name} usa su ataque especial! {objetivo.Name} muere al instante.");
            objetivo.Vida = 0;
        }
    }

    public void Cortar() => Console.WriteLine($"{Name} realiza un corte poderoso.");

    public void AtaqueCargado(Personaje objetivo)
{
        // Cada vez que se repite el ataque, se llama a RecibirDanio
        objetivo.RecibirDanio(Poder*2);

    Console.WriteLine($"{Name} realizó un ataque cargado a {objetivo.Name}.");
}

}

class Mago : Personaje, ICurador
{
    public override void AtaqueEspecial(Personaje objetivo)
    {
        if (Especial && Nivel > 7 && Poder > 25 && objetivo.Vida > 0)
        {
            Console.WriteLine($"¡{Name} lanza un hechizo letal contra {objetivo.Name}!");
            objetivo.Vida = 0;
        }
    }

    public void Curar(Personaje objetivo)
    {
        objetivo.Vida += 10;
        Console.WriteLine($"{Name} curó a {objetivo.Name}. Vida: {objetivo.Vida}");
    }

    public void Curarse() => Console.WriteLine($"{Name} se cura a sí mismo.");
}

class Arquero : Personaje, IShooter
{
    public override void AtaqueEspecial(Personaje objetivo)
    {
        if (Especial && Nivel > 7 && Poder > 25 && objetivo.Vida > 0)
        {
            Console.WriteLine($"¡{Name} dispara una flecha letal a {objetivo.Name}!");
            objetivo.Vida = 0;
        }
    }

    public void Disparar() => Console.WriteLine($"{Name} dispara una flecha.");

    public void AtaqueCargado(Personaje objetivo)
{

        objetivo.RecibirDanio(Poder*2);

    Console.WriteLine($"{Name} realizó un ataque cargado  a {objetivo.Name}.");
}

}

sealed class FinalBoss : Personaje, IShooter, IBlade
{
    public override void AtaqueEspecial(Personaje objetivo)
    {
        Console.WriteLine($"¡{Name} usa su ataque especial y destruye a {objetivo.Name}!");
        objetivo.Vida = 0;
    }

    public void Disparar() => Console.WriteLine($"{Name} dispara con precisión letal.");

     void IShooter.AtaqueCargado(Personaje objetivo)
    {
        Console.WriteLine($"El jefe final dispara a {objetivo.Name} con un ataque cargado.");
        objetivo.RecibirDanio(_poder * 3); // Ejemplo de daño aumentado
    }

    // Implementación explícita de AtaqueCargado para IBlade
    void IBlade.AtaqueCargado(Personaje objetivo) //SIN MODIFICADOR 
    {
        Console.WriteLine($"El jefe final corta a {objetivo.Name} con un ataque cargado.");
        objetivo.RecibirDanio(_poder * 3); // Ejemplo de daño aumentado
    }

    public void Cortar() => Console.WriteLine($"{Name} corta con su espada gigante.");
}

// Interfaces
interface ICurador { void Curar(Personaje objetivo); void Curarse(); }
interface IShooter { void Disparar(); void AtaqueCargado(Personaje objetivo); }
interface IBlade { void Cortar(); void AtaqueCargado(Personaje objetivo); }
