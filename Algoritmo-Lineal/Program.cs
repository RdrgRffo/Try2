public class Program
{ //Este algoritmo recorre un arreglo elemento por elemento hasta encontrar el valor deseado o terminar el arreglo.

    public static void Main()
    {

        int[] arreglo = null;
        int objetivo = 21; // Elemento a buscar

        BuscaNum(arreglo ,objetivo);
       
    }

    public static int BuscaNum(int[] arreglo, int buscado){

        int i = 0;
        bool encontrado = false;

        while (i < arreglo.Length && !encontrado)
        {
            if (arreglo[i] == buscado)
            {
                encontrado = true;
            }
            else
            {
                i++;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("Elemento encontrado en la posición: " + i);
        }
        else
        {
            Console.WriteLine("Elemento no encontrado.");
        }

        return buscado;

    }
}