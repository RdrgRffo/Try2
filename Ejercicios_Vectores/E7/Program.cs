public class Program
{
    public static void Main(string[] args)
    {

        //ecogidos los datos del nombre de diez alumnos, y la nota que han obtenido en un examen, 
        //calcular la media de las notas de los diez alumnos, e indicar el nombre de los alumnos que tienen una nota inferior a la media.

        Console.WriteLine("--programa de notas---");
        string[] nombres=new string[10];
        double[] nota=new double[10];
        double media,suma;
        suma=0;
        media=0;

        for(int i=0;i<10;i++){

        Console.WriteLine($"Dame el nombre del alumno #{i+1}");
        nombres[i]=Console.ReadLine();

        Console.WriteLine($"Dame la nota del alumno ¨{nombres[i]}");
        nota[i]=Convert.ToDouble(Console.ReadLine());

        suma+=nota[i];

        }

        media=suma/nota.Length;

        Console.WriteLine($"La media es {media}");

        for(int j=0;j<10;j++){

            if(nota[j]<media){
                Console.WriteLine($"La nota del alumno {nombres[j]}, con nota {nota[j]} es menor a la media ");
            }

        }

    }
}