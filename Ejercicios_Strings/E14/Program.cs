public class Program
{
    public static void Main(string[] args)
    {
        //Dada una cadena de caracteres, elimina los caracteres en blanco a la derecha de la cadena y la muestre por pantalla.

        
        Console.Write("Dame una cadena de caracteres con espacios a la DERECHA: ");
        string cadena = Console.ReadLine();

        string CadenaSinEsp = ""; //pa guardarla sin los espacios
        int i = 0; //global para guardar avance en la string
        int cont=0;

        for (i = 0; i < cadena.Length; i++)
        {
            if(cadena[i]==' '){
                cont++;
            }
            else
             CadenaSinEsp += cadena[i];
        }

        Console.WriteLine("Cadena con los espacios a la derecha: " + cadena+'x');
        Console.WriteLine("Cadena sin los espacios a la derecha: " + CadenaSinEsp+'x');
        Console.WriteLine($"Habian {cont} espacios en la derecha");

    }
}