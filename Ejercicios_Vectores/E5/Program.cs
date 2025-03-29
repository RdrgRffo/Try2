public class Program
{
    public static void Main(string[] args)
    {
        /*Solicitar una cantidad no definida de datos y calcular su suma. Debe estar preparado para un máximo de 100 números, 
        que pedirá de uno en uno. Cuando se introduzca un valor cero, 
        mostrará la suma de todos los anteriores y dará el número de datos introducidos.*/

        double suma, numero, contadorNum;
        Console.WriteLine("Dame el primer número para acumularlo");
        numero = Convert.ToDouble(Console.ReadLine());
        suma = 0;
        contadorNum = 1;

        while (numero !=0 && contadorNum < 100)
        {

                Console.WriteLine("Dame un número para acumularlo");
                numero = Convert.ToDouble(Console.ReadLine());
                suma = suma + numero;
                contadorNum++;

        }

        Console.WriteLine($"La suma de los números es {suma} y la cantidad de números introducidos es {contadorNum}");

    }
}