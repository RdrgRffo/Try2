public class Program
{
    public static void Main(string[] args)
    {
        // Dada una cadena de caracteres que contenga el nombre de una persona en formato APELLIDOS, NOMBRE, 
        // convertirla en una cadena del tipo NOMBRE APELLIDOS.

        string nombreCompleto = "Riffo, Rodrigo";

        int coma = nombreCompleto.IndexOf(',');

        // Obtener los apellidos (todo lo que está antes de la coma)
        string apellido = nombreCompleto.Substring(0, coma);

        // Ajustar coma para empezar después de la coma y el espacio
        coma = coma + 1;

        // Obtener el nombre (todo lo que está después de la coma)
        string nombre = nombreCompleto.Substring(coma).Trim();  // Trim para eliminar cualquier espacio extra

        // Imprimir los resultados
        Console.WriteLine(apellido);
        Console.WriteLine(nombre);

        // Mostrar el nuevo nombre en formato NOMBRE APELLIDOS
        string NuevoNombre = nombre + ' ' + apellido;

        // Imprimir el nuevo formato
        Console.WriteLine(NuevoNombre);
    }
}
