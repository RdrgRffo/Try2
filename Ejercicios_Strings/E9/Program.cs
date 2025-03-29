using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar el nombre en formato "APELLIDOS, NOMBRE" y devolderlo en "NOMBRE APELLIDO"

        Console.Write("Dame el nombre en formato 'APELLIDOS, NOMBRE': ");
        string nombreOriginal = Console.ReadLine();

        // Variables para almacenar apellidos y nombre, para reconstruir la string
        string apellidos = "";
        string nombre = "";
        bool comaEncontrada = false;

        // Búsqueda lineal para separar el apellido y el nombre
        for (int i = 0; i < nombreOriginal.Length; i++)
        {
            if (!comaEncontrada)
            { 

                // Agregar a 'apellidos' hasta encontrar la coma
                if (nombreOriginal[i] != ',')
                {
                    apellidos += nombreOriginal[i];
                }
                else
                    comaEncontrada = true;
                
            }
            else
            {
                // Después de la coma, agregar a string 'nombre'
                nombre += nombreOriginal[i];
            }
        }

        // Concatenar en formato "NOMBRE APELLIDOS"
        string nombreCompleto = nombre + " " + apellidos;

        // Mostrar el resultado
        Console.WriteLine("Nombre completo: " + nombreCompleto);
    }
}
