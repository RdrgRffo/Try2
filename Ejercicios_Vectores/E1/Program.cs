public class Program
{
    public static void Main(string[] args)
    {
        // se llaman arrays, listas, vectores, etc (es un objeto)
        // van con índice desde 0 hasta n-1 - si [5] va de [0] a [4]
        //Almacena secuencia de datos
        //debe declararse el tipo de dato que se guardará en el array
        // a(nombreArray)[2](posición)
        //mediante el indice se accede al valor de la posición
        // puedo dentro de bucle asignar a [i] valores y luego leerlos

        //string saludo="hola!" -- C.WL(saludo[0]) = "h" --- C.WL(saludo[4]) = "!"
    
        //int[] nombreVector;
        //nombreVector = new int[i] -- se crea objeto y num de espacios de variable lista
    
        //en un array lista[3] {1,2,3}; se pueden asignar al lado los valroes.

        //hacer int[]diasMes y string[]Nombremes;

        int[] diasMes = {31,29,31,30,31,30,31,31,30,31,30,31};
        string[] nombreMes = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};

        for(int contador=0;contador<12;contador++){

            Console.WriteLine($"El mes de {nombreMes[contador]} tiene {diasMes[contador]} ");


        }
    }
}