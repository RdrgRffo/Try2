internal class Program
{
    private static void Main(string[] args)
    {
        //Desarrolla un programa que devuelva una cadena con un carácter repetido n veces, siendo n solicitado por teclado.

        string repeticion = "";
        char requerido;
        int numeroReps;

        Console.Write("Dame un caracter para repetirlo n veces en una cadena:");
        requerido = Console.ReadKey().KeyChar;

        
        Console.WriteLine("\n Dame la cantidad de veces:");
        numeroReps = Convert.ToInt32(Console.ReadLine());

        for(int i=1;i<=numeroReps;i++){

            repeticion+=requerido;

        }

        Console.WriteLine($"El string resultante es: {repeticion}");
    }
}