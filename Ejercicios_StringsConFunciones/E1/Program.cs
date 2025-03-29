public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena por teclado, indicar cuáles son las vocales que contiene.
        string frase = "Hola amigo como va la cosa?";

        // Convertir la frase a minúsculas para evitar problemas con las mayúsculas
        frase = frase.ToLower();

        // Definir las vocales
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

        // Arreglo para verificar si las vocales están presentes
        bool[] EstaVocal = new bool[vocales.Length];

        // Recorrer cada carácter de la cadena
        for (int i = 0; i < frase.Length; i++)
        {
            for (int j = 0; j < vocales.Length; j++)
            {
                // Si encontramos la vocal, la marcamos en el arreglo
                if (frase[i] == vocales[j])
                    EstaVocal[j] = true;
            }
        }

        // Imprimir el resultado
        for (int k = 0; k < EstaVocal.Length; k++)
        {
            if (EstaVocal[k])
                Console.WriteLine($"La vocal {vocales[k]} se encuentra en la cadena");
            else
                Console.WriteLine($"La vocal {vocales[k]} NO se encuentra en la cadena");
        }
    }
}
