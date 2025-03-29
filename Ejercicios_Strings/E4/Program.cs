public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena por teclado, introducir en una nueva variable la cadena al revés, y mostrarla.

        Console.WriteLine("Dame una cadena de caracteres para verla al revés:");
        string cadena = Console.ReadLine();
        string cadenaAlrevez = ""; //necesito o una nueva variable o sobrescribir la antigua.

        Console.WriteLine("La cadena al revés es: ");

        for (int i = cadena.Length - 1; i >= 0; i--) //siempre en for acordarme de unas length -1, por que recorre posiciones de array.
        {
            cadenaAlrevez= cadenaAlrevez+cadena[i];
        }
        Console.WriteLine();
        Console.WriteLine("La cadena en su nueva variable escribe: ");
        Console.WriteLine(cadenaAlrevez);
    }
}
