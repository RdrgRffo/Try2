class Program
{
    static void Main()
    {
        // Declaración y asignación de un Jagged Array
        int[][] jaggedArray = new int[3][];  
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Recorrer el Jagged Array
        Console.WriteLine("Recorriendo el Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Fila " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Modificación de un elemento
        jaggedArray[1][1] = 50;
        Console.WriteLine("\nValor modificado en jaggedArray[1][1]: " + jaggedArray[1][1]);

        // Agregar una nueva fila
        Array.Resize(ref jaggedArray, 4);
        jaggedArray[3] = new int[] { 10, 11 };

        Console.WriteLine("\nNueva fila agregada:");
        foreach (var fila in jaggedArray)
        {
            Console.WriteLine(string.Join(", ", fila));
        }
    }
}