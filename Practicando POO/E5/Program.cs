internal class Program
{
    private static void Main(string[] args)
    {
        //Clase Relacionada: Crea una clase Estudiante con una lista de calificaciones. 
        //Implementa métodos para agregar calificaciones y calcular el promedio.

        System.Console.WriteLine("Inserte el numero de notas que tendra el estudiante");

        int notas = Int32.Parse(Console.ReadLine());

        Estudiante e1 = new Estudiante(5);

        e1.Add(1);
        e1.Add(2);
        e1.Add(3);
        e1.Add(4);
        e1.Add(5);
        e1.Add(6);
        e1.Add(7);
        e1.Add(8);

        e1.MuestraNotas();
        e1.Promedio();

    }
}

class Estudiante
{

    private int[] Notas;

    private int NotasEntrada;

    private int indice = 0;

    public Estudiante(int NumNotas)
    {
        this.NotasEntrada = NumNotas;
        Notas = new int[NumNotas];
    }

    public void Add(int nota)
    {

        if (indice == Notas.Length)
        {

            int[] aux = new int[Notas.Length * 2];
            Array.Copy(Notas, aux, Notas.Length);
            Notas = aux;
        }

        Notas[indice] = nota;
        indice++; // usado para posicionar

    } //hacer uno en poas y eso

    public int Promedio()
    {

        int suma = 0;

        for (int i = 0; i < Notas.Length; i++)
        {
            suma += Notas[i];
        }

        return suma / indice;
    }

    public void MuestraNotas()
    {
        int j= 0;

        foreach (int Nota in Notas)
        {
            if(j<indice){
            System.Console.WriteLine(Nota);
            j++;
            }

        }

    }
}