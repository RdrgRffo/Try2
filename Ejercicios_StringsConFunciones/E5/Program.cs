public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena de caracteres,
        // elimina los espacios en blanco a ambos extremos de la cadena y la muestra por pantalla.

        string frase = "   A mi madre le gusta ir a correr por la mañana   ";

        // Usar el método Trim() para eliminar los espacios en blanco de ambos extremos
        string nuevafrase = frase.Trim();

        // Mostrar la nueva frase sin los espacios en blanco
        Console.WriteLine(nuevafrase);
    }
}
