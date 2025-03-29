using System;

class Program
{
    static void Main()
    {
        string texto = " Hola, Mundo! ";

        Console.WriteLine("Texto original: '" + texto + "'");
        Console.WriteLine("Longitud: " + texto.Length);
        Console.WriteLine("En mayúsculas: " + texto.ToUpper());
        Console.WriteLine("En minúsculas: " + texto.ToLower());
        Console.WriteLine("Sin espacios al inicio y fin: '" + texto.Trim() + "'");
        Console.WriteLine("Reemplazo de 'Mundo' por 'C#': " + texto.Replace("Mundo", "C#"));
        Console.WriteLine("¿Contiene 'Hola'? " + texto.Contains("abcde....")); //meteria aca el string de chars buscados
        Console.WriteLine("¿Empieza con ' Hola'? " + texto.StartsWith(" Hola"));
        Console.WriteLine("¿Termina con '!'? " + texto.EndsWith("!"));
        Console.WriteLine("Parte extraída (substring 7 a 5 caracteres): " + texto.Substring(7, 5));
    }

    /* using System;

public class Program
{
    public static void ContarVocalesYConsonantes(string texto)
    {
        string vocales = "aeiou";  // Las vocales en minúsculas
        int contadorVocales = 0;
        int contadorConsonantes = 0;

        foreach (char c in texto)
        {
            // Convertimos el carácter a minúsculas para evitar distinción de mayúsculas/minúsculas
            char letra = Char.ToLower(c);

            // Comprobamos si es una vocal
            if (vocales.Contains(letra))
            {
                contadorVocales++;
            }
            // Comprobamos si es una consonante
            else if (letra >= 'a' && letra <= 'z')  // Verificamos si es una letra
            {
                contadorConsonantes++;
            }
        }

        // Mostramos el resultado
        Console.WriteLine($"Vocales: {contadorVocales}");
        Console.WriteLine($"Consonantes: {contadorConsonantes}");
    }

    static void Main(string[] args)
    {
        string texto = "programacion";
        ContarVocalesYConsonantes(texto);
    }
}

}
 */

 ///////
 
 /* using System;

public class Program
{
    public static void ContarVocalesYConsonantes(string texto)
    {
        int contadorVocales = 0;
        int contadorConsonantes = 0;

        foreach (char letra in texto)
        {
            // Convertimos la letra a minúscula para evitar distinción de mayúsculas/minúsculas
            char letraMinuscula = Char.ToLower(letra);

            // Comprobamos si la letra es una vocal
            if (char.IsLetter(letra))  // Verificamos si es una letra
            {
                if (letraMinuscula == 'a' || letraMinuscula == 'e' || letraMinuscula == 'i' || letraMinuscula == 'o' || letraMinuscula == 'u')
                {
                    contadorVocales++;
                }
                else
                {
                    // Si es una letra pero no es una vocal, es una consonante
                    contadorConsonantes++;
                }
            }
        }

        // Mostramos el resultado
        Console.WriteLine($"Vocales: {contadorVocales}");
        Console.WriteLine($"Consonantes: {contadorConsonantes}");
    }

    static void Main(string[] args)
    {
        string texto = "programacion";
        ContarVocalesYConsonantes(texto);
    }
}
*/