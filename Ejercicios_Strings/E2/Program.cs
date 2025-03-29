public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar una frase y una letra para buscar dentro de la frase
        Console.Write("Dame una frase: ");
        string frase = Console.ReadLine();

        Console.Write("Dame una letra para buscarla dentro de la frase: ");
        char letra = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int contador = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == letra)
            {
                contador++;
                Console.WriteLine($"La letra '{letra}' se ha encontrado en la posición {i}");
            }
        }

        Console.WriteLine($"\nLa letra '{letra}' aparece {contador} veces en la frase.");
    }
}
