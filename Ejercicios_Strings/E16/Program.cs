public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Indique cadena:");
        string cadena = Console.ReadLine();
        bool esPalindromo = true;
        string cadenaLimpia = "";

        // Quita espacios en blanco de la cadena para que no afecten la verificación de palíndromo
        for (int i = 0; i < cadena.Length; i++)
        {    
            if (cadena[i] != ' ')
            {
                cadenaLimpia += cadena[i];
            }
        }

        // Calcula el número de iteraciones necesarias (la mitad de la longitud de la cadena limpia)
        int medio = cadenaLimpia.Length / 2;

        // Compara caracteres desde el principio y el final hasta el medio
        for (int i = 0; i < medio; i++)
        {
            if (cadenaLimpia[i] != cadenaLimpia[cadenaLimpia.Length - 1 - i])
            {
                esPalindromo = false;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine($"{cadena} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"{cadena} no es un palíndromo.");    
        }
    }
}