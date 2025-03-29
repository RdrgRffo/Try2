public class Program
{
public static void Main(string[] args)
{
Random random = new Random();
char[] letras = new char[100];


for (int i = 0; i < letras.Length; i++)
{
letras[i] = (char)random.Next('A', 'Z' + 1);
}

Console.WriteLine("String generado: ");
Console.WriteLine(letras);


int[] contador = new int[26]; // o [Z-A+1] (son 25 letras pero añadimos uno por el upper bound excluded)


for (int i = 0; i < letras.Length; i++)
{
 contador[letras[i]-'A']++; //A vale cero y Z vale 25, esta es una resta del num de la posición - A (se incrementa el contador de la posicion que se define)
}


Console.WriteLine("\nFrecuencia de cada letra:");
for (int i = 0; i < contador.Length; i++)
{
char letra = (char)('A' + i);
Console.WriteLine($"{letra}: {contador[i]}");
}
}
}