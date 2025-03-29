public class Program
{
    public static void Main(string[] args)
    {
        // Saber cuantas mayusculas y minusculas tiene mi string

        string frase = "Hola Mundo, ¿Cómo Estás?";

        int contadorMayusculas = 0;
        int contadorMinusculas = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (Char.IsUpper(frase[i]))
            {
                contadorMayusculas++;
            }
            else if (Char.IsLower(frase[i]))
            {
                contadorMinusculas++;
            }
        }

        Console.WriteLine($"Cantidad de letras mayúsculas: {contadorMayusculas}");
        Console.WriteLine($"Cantidad de letras minúsculas: {contadorMinusculas}");
    }
}
