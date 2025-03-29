public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena por teclado, y una segunda de comparación, mostrar por pantalla la cadena “Está”
        // cuando encontremos la segunda cadena en cualquier posición de la primera.

        string frase;
        string Buscada;

        Console.WriteLine("Dame una frase por teclado");
        frase = Console.ReadLine();

        Console.WriteLine("Dame una frase para buscarla dentro de la anterior");
        Buscada = Console.ReadLine();

        if (frase.Contains(Buscada))
            Console.WriteLine("Está");
        else
            Console.WriteLine("No está");
    }
}
