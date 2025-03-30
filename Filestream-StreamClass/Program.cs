using System;
using System.IO;
using System.Text;

class StreamExample
{
    static void Main()
    {
        string filePath = "ejemplo.txt";

        // 1. Escribir en un archivo usando FileStream y StreamWriter
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
        using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8)) // Composición: StreamWriter depende de FileStream
        {
            writer.Write("Primera línea de texto.");
            writer.Write(" Segunda línea de texto.");
            writer.WriteLine(" Tercera línea con salto de línea.");
            writer.Flush(); // Asegura que los datos se escriban en el archivo
        }

        // 2. Leer el archivo usando FileStream y StreamReader
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8)) // Composición: StreamReader depende de FileStream
        {
            string contenido = reader.ReadToEnd();
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(contenido);
        }

        // 3. Escritura y lectura en memoria usando MemoryStream
        using (MemoryStream memoryStream = new MemoryStream()) // Uso directo de Stream
        using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8))
        using (StreamReader reader = new StreamReader(memoryStream, Encoding.UTF8))
        {
            writer.Write("Texto en memoria.");
            writer.WriteLine(" Más texto en memoria.");
            writer.Flush();
            memoryStream.Position = 0; // Reiniciar posición para leer
            string contenidoMemoria = reader.ReadToEnd();
            Console.WriteLine("Contenido en memoria: " + contenidoMemoria);
        }

        // 4. Uso de BufferedStream para optimizar escritura y lectura
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
        using (BufferedStream bs = new BufferedStream(fs)) // Agregación: BufferedStream mejora FileStream sin poseerlo
        using (StreamWriter writer = new StreamWriter(bs, Encoding.UTF8))
        using (StreamReader reader = new StreamReader(bs, Encoding.UTF8))
        {
            writer.Write("Texto con BufferedStream.");
            writer.Flush();
            bs.Flush(); // Asegurar que los datos se escriban
            fs.Position = 0; // Reiniciar posición para leer
            string contenidoBuffered = reader.ReadToEnd();
            Console.WriteLine("Contenido con BufferedStream: " + contenidoBuffered);
        }
    }
}

/*
Notas Importantes:

1. **Composición vs. Agregación:**
   - `StreamWriter` y `StreamReader` tienen una relación de **composición** con `Stream` (FileStream o MemoryStream) porque no pueden funcionar sin él.
   - `BufferedStream` tiene una relación de **agregación** porque optimiza `FileStream`, pero no depende de él para existir.

2. **Métodos Claves:**
   - `Write(string)`: Escribe texto en un flujo sin salto de línea.
   - `WriteLine(string)`: Escribe texto en un flujo con un salto de línea.
   - `ReadToEnd()`: Lee todo el contenido del Stream hasta el final.
   - `Flush()`: Asegura que todos los datos se escriban físicamente.
   - `Position`: Permite mover el puntero de lectura/escritura.
   - `Length`: Devuelve el tamaño del Stream.
   - `Dispose()`: Libera los recursos del Stream, pero `using` lo hace automáticamente.

3. **Consideraciones:**
   - **Siempre usar `using`** para evitar fugas de memoria.
   - **Controlar excepciones** al leer/escribir archivos (`FileNotFoundException`, `IOException`).
   - **Cerrar streams** después de usarlos.
   - **Usar `BufferedStream`** para mejorar el rendimiento cuando hay muchas operaciones de E/S.

*/
