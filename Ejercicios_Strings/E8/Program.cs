public class Program
{
    public static void Main(string[] args)
    {
        // Teniendo en cuenta que la clave es “eureka”, el usuario tiene 3 intentos para acertarla.
        
        string clave = "";
        int intentos = 0;

        Console.WriteLine("Clave de entrada:");

        // Bucle para dar 3 intentos
        do
        {
            clave = Console.ReadLine();
            intentos++;

            // Si la clave es correcta, salimos del bucle
            if (clave == "eureka")
            {
                Console.WriteLine("Entras!");
            }

        } while (intentos < 3 && clave != "eureka");

        // Si se agotaron los intentos y no se acertó
        if (clave != "eureka")
        {
            Console.WriteLine("Ha superado sus tres intentos");
        }
    }
}