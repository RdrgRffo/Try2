public class Program
{
    public static void Main(string[] args)
    {
        //separar palabras de string y contar sus letras
        
        Console.WriteLine("Introduce una frase:");
        string frase = Console.ReadLine();
        string palabra = "";
        int longitud = 0;

        for (int i = 0; i <= frase.Length; i++)
        {
            // Si encontramos un espacio o llegamos al final de la frase, procesamos la palabra actual

            if (i == frase.Length || frase[i] == ' ')
            {
                if (palabra.Length > 0)
                {
                    longitud = palabra.Length;
                    Console.WriteLine($"{palabra} ({longitud} letras)");
                    palabra = "";  // Reiniciar para la siguiente palabra
                }
            }
            else
            {
                // Construir la palabra carácter por carácter
                palabra += frase[i];
            }
        }
    }
}
