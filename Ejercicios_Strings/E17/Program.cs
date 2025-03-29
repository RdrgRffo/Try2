public class Program
{
    public static void Main(string[] args)
    {
        //Un número capicúo se refiere a cualquier número que se lee igual de izquierda a derecha y de derecha a izquierda.
        // Dado un número por teclado, devolver si se trata de un capicúo o no.

        string capicuo;
        //los pudo en variable string ya que sino no puedo usar indexados

        bool EsCapicuo=true; 

        Console.WriteLine("Dame un numero ppara saber si es capicuo");
        capicuo = Console.ReadLine();

        int medio = capicuo.Length/2;

        for(int i=0; i<medio; i++){

            if(capicuo[i] != capicuo[capicuo.Length - 1 - i])
            EsCapicuo = false;
        }        

        if(EsCapicuo)
            Console.WriteLine("Es Capicuo");
        else   
            Console.WriteLine("No es capicuo");
    }
}