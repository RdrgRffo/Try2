public class Program
{
    public static void Main(string[] args)
    {
        // Introducir por teclado una frase y a continuación visualizar cada palabra de la frase,
        // una debajo de otra, seguida cada palabra del número de letras que compone dicha palabra.

        string frase = "A mi amigo ricardo le gusta comer paella por las noches";
        
        // Separar la frase por espacios
        string[] fraseSeparada = frase.Split(' ');

        // Recorrer cada palabra e imprimirla junto con su longitud
        foreach (string palabra in fraseSeparada)
        {
            Console.WriteLine($"{palabra} tiene {palabra.Length} letras.");
        }
    }
}
