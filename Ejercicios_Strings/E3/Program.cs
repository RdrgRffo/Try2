public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena por teclado, mostrar la cadena al revés.

        Console.WriteLine("Dame una cadena de caracteres para verla al revés:");
        string cadena = Console.ReadLine();

        Console.Write("La cadena al revés es: ");
        for (int i = cadena.Length - 1; i >= 0; i--) //siempre en for acordarme de unas length -1, por que recorre posiciones de array.no la lenght
        {
            Console.Write(cadena[i]);
        }

        Console.WriteLine(); // Salto de línea al final
    }
}
