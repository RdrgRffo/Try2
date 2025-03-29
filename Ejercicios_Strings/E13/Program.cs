public class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Dame una cadena de caracteres con espacios a la izquierda: ");
        string cadena = Console.ReadLine();

        string CadenaSinEsp = ""; //pa guardarla sin los espacios
        int i = 0; //global para guardar avance en la string
        int cont=0;

        for (i = 0; i < cadena.Length && cadena[i] == ' '; i++)
        {
           cont++;
        }

        // Agregar el resto de la cadena después de los espacios, no pongo el primer i para q mantenga el valor que deje en el for anterior.
        for (; i < cadena.Length; i++)
        {
            CadenaSinEsp += cadena[i];
        }

        Console.WriteLine("Cadena sin los espacios a la izquierda: " + CadenaSinEsp);
        Console.WriteLine($"Habian {cont} espacios en la izquierda");
    }
}