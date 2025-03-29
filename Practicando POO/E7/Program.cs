internal class Program
{
    private static void Main(string[] args)
    {
        //Herencia Básica: Crea una clase Animal con atributos especie y edad. 
        //Hereda de ella una clase Perro con un método adicional para ladrar.

        Gato animal4 = new Gato("antom", 3, "pelao");
        Perro animal5 = new Perro("jorge", 1, "golden");


        animal4.HacerRuido();
        animal5.HacerRuido();


    }
}

abstract class Animal
{

    private string nombre;
    private int edad;
    private string especie;

    public Animal(string nombre, int edad, string especie)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.especie = especie;
    }

    public abstract void HacerRuido(); //solo lo declaro como obligatorioa

}

class Perro : Animal
{

    public Perro(string nombre, int edad, string especie) : base(nombre, edad, especie)
    {

    }

    public override void HacerRuido()
    {
        System.Console.WriteLine("Wau Wau");
    }

}

class Gato : Animal
{

    public Gato(string nombre, int edad, string especie) : base(nombre, edad, especie)
    {

    }

    public override void HacerRuido()
    {
        System.Console.WriteLine("miau miua");
    }


}