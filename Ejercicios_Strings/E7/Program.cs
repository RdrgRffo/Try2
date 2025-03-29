public class Program
{
    public static void Main(string[] args)
    {
        // Pedir las dos cadenas al usuario
        Console.WriteLine("Dame una cadena de texto:");
        string cadena1 = Console.ReadLine();
        
        Console.WriteLine("Dame la cadena de comparación:");
        string cadena2 = Console.ReadLine();

        bool esta = false;
        
        // Recorremos cadena1 hasta donde pueda contener a cadena2
        for (int i = 0; i < cadena1.Length - cadena2.Length; i++)
        {
            bool coincide = true;

            if(cadena1[i] == ' '){
                i++;
            }

            // Comparamos cada carácter de la subcadena
            for (int j = 0; j < cadena2.Length; j++)
            {

                if (cadena1[i + j] != cadena2[j])
                {
                    coincide = false;

                }
            }

            // Si coincide es true después del bucle, hemos encontrado cadena2 en cadena1
            if (coincide)
            {
                esta = true;
            }
        }

        // Mostrar el resultado
        if (esta)
        {
            Console.WriteLine("Está");
        }
        else
        {
            Console.WriteLine("No está");
        }
    }
}
