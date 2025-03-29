class Program
{
    static void Main()
    {
        // Crear una lista de enteros
        List<int> numeros = new List<int>() { 10, 20, 30, 40, 50 };

        // Agregar elementos a la lista
        numeros.Add(60);
        numeros.AddRange(new int[] { 70, 80 });

        // Insertar un elemento en una posición específica
        numeros.Insert(2, 25);

        // Eliminar un elemento por valor
        numeros.Remove(40);

        // Eliminar un elemento por índice
        numeros.RemoveAt(0);

        // Buscar elementos
        bool contiene30 = numeros.Contains(30);
        int indiceDe30 = numeros.IndexOf(30);

        // Ordenar la lista
        numeros.Sort();

        // Recorrer la lista
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        // Obtener una sublista
        List<int> sublista = numeros.GetRange(1, 3);

        // Vaciar la lista
        numeros.Clear();

        Console.WriteLine("Número de elementos en la lista: " + numeros.Count);
    }
}

/* 
class Program -bUSQUEDA CON ORDENAMIENTO SIMPLE
    {
        static void Main(string[] args)
        {
 
            int[] valores = { 4, 3, 7, 10, 100, 5, 7 };
 
            Array.Sort(valores);
 
            int maximo = valores[valores.Length-1];
            int minimo = valores[0];
 
            Console.WriteLine("El valor minimo es: "+minimo);
            Console.WriteLine("El valor maximo es: "+maximo);
 
            Console.ReadLine();
        }
    }
*/

/* List<int> lista = new List<int> { 1, 2, 3, 2, 4, 1, 5 };
List<int> listaSinDuplicados = new List<int>();

foreach (var item in lista)
{
    if (!listaSinDuplicados.Contains(item))
    {
        listaSinDuplicados.Add(item);
    }
}

foreach (var item in listaSinDuplicados)
{
    Console.Write(item + " ");
}
*/