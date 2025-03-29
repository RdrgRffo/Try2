public class Program
{
    public static void Main(string[] args)
    {
        //Crear un programa que pida al usuario 10 números decimales, calcule su media y luego muestre los que están por encima de la media.

        Console.WriteLine("Dame 10 números decimales para conocer su media");
        double suma,media;
        int i=0;
        double[] numeros = new double[10];
        suma=0;
        media=0;

        for(i=0;i<10;i++){

            Console.WriteLine($"Dame el numero de la posicion {i+1}");
            numeros[i]=Convert.ToDouble(Console.ReadLine());
            suma=suma+numeros[i];

        }

        media=suma/numeros.Length;
        Console.WriteLine($"La media es {media:F2}");

        for(int j=0;j<10;j++){

            if(numeros[j]>media){
                Console.WriteLine($"El numero {numeros[j]} de la posición {j} es menor a la media");
            }

        }

    }
}

//tiene que ser una tabla por la comparacion para la media