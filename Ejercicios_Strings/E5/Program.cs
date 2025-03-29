public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena por teclado, indicar cuántas vocales contiene.
        int contador = 0; 
        Console.WriteLine("Dame una cadena de caracteres para conocer cuántas vocales tiene:");
        string cadena = Console.ReadLine();

        cadena = cadena.ToLower(); //mejor en minuscula para no buscar 2 veces

        for (int i = 0; i < cadena.Length; i++)
        {

            if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
            {
                contador++;
            }
        }

        Console.WriteLine($"El string tiene {contador} vocales."); //no distingue cuantas de cada
    }
}

/*
public class Program
{
    public static void Main(string[] args)
    {
        // Definir el arreglo de vocales
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };  //asi defino un arreglo de char con valores predefinidos.

        // Arreglo de contadores para cada vocal
        int[] vocalesContador = new int[vocales.Length]; //con la longitud de vocales.lenght

        Console.WriteLine("Dame una cadena de caracteres para contar las vocales:");
        string cadena = Console.ReadLine();

        // Convertir la cadena a minúsculas
        cadena = cadena.ToLower();

        // Recorrer cada carácter de la cadena para dentro, buscar cada vocal x cada caracter, y sumar al contador.
        int i = 0
        for (; i < cadena.Length; i++)
        {
            
            bool esVocal = false; --// Comprobar si el carácter actual es una vocal

            int j = 0; --//siempre debo inicializar contadores para while usando vectores.

            // Buscar la vocal en el arreglo de vocales

            while (j < vocales.Length && !esVocal) //while porque? recorre los caracteres hasta que O recorre todo O es no es vocal, si es se sale o si acaba
            {
                if (cadena[i] == vocales[j])
                {
                    esVocal = true; // Se ha encontrado una vocal y se sale del while
                    vocalesContador[j]++; // Incrementar el contador de la vocal correspondiente
                }

                j++; // Avanzamos al siguiente índice del arreglo de vocales si no ha logrado el if
            }
        }

        // Mostrar los resultados
        for (int x = 0; x < vocales.Length; x++)
        {
            Console.WriteLine($"La letra '{vocales[x]}' aparece {vocalesContador[x]} veces.");
        }
    }
}
*/