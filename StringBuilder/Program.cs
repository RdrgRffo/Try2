using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Inicializar un StringBuilder con un texto base
        StringBuilder sb = new StringBuilder("Hola, este es un texto de prueba.");

        Console.WriteLine("📌 Texto original:");
        Console.WriteLine(sb.ToString());

        // 🔹 1. Concatenación eficiente (Append)
        sb.Append(" Estamos aprendiendo sobre StringBuilder en C#.");
        Console.WriteLine("\n🔹 Después de Append:");
        Console.WriteLine(sb.ToString());

        // 🔹 2. Inserción en una posición específica (Insert)
        sb.Insert(5, "a todos, "); // Inserta después de "Hola, "
        Console.WriteLine("\n🔹 Después de Insert:");
        Console.WriteLine(sb.ToString());

        // 🔹 3. Reemplazo de palabras (Replace)
        sb.Replace("texto", "mensaje");
        Console.WriteLine("\n🔹 Después de Replace:");
        Console.WriteLine(sb.ToString());

        // 🔹 4. Eliminación de caracteres (Remove)
        sb.Remove(0, 6); // Elimina "Hola, " (primeros 6 caracteres)
        Console.WriteLine("\n🔹 Después de Remove:");
        Console.WriteLine(sb.ToString());

        // 🔹 5. Capacidad y optimización
        Console.WriteLine($"\n🔹 Capacidad inicial: {sb.Capacity}");
        sb.EnsureCapacity(100); // Asegura que tenga al menos 100 caracteres de capacidad
        Console.WriteLine($"🔹 Capacidad después de EnsureCapacity: {sb.Capacity}");

        // 🔹 6. Conversión a string
        string resultadoFinal = sb.ToString();
        Console.WriteLine("\n📌 Resultado Final:");
        Console.WriteLine(resultadoFinal);
    }
}
