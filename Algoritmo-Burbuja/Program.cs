
    // Método para ordenar dos arreglos paralelos
    static void OrdenarParalelo(string[] arr1, int[] arr2)
    {
        int n = arr2.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr2[j] > arr2[j + 1])
                {
                    // Intercambiar valores en el arreglo de enteros
                    int tempInt = arr2[j];
                    arr2[j] = arr2[j + 1];
                    arr2[j + 1] = tempInt;

                    // Intercambiar valores en el arreglo de cadenas correspondiente
                    string tempStr = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = tempStr;
                }
            }
        }
    }

    // Método para imprimir los arreglos paralelos
    static void ImprimirArreglos(string[] arr1, int[] arr2)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine($"{arr1[i]} - {arr2[i]}");
        }
    }
