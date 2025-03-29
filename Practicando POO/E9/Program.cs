internal class Program
{
    private static void Main(string[] args)
    {
        //odifica la búsqueda para encontrar el número más grande dentro del arreglo.

       int[,] matriz = {
    {10, 20, 30, 40},
    {50, 60, 70, 80},
    {90, 100, 110, 120}
};

    bool resultado = BuscarNumero(matriz, 50);
Console.WriteLine("¿Se encontró un número mayor a 50? " + resultado);
    }

   
                /*
        Encuentra el primer número primo en un array.

        Encuentra el primer número negativo seguido de un positivo en un array.

        Encuentra el primer número mayor que X en una matriz m × n.

        Encuentra la primera aparición de un número en una matriz irregular (jagged array).

        Encuentra la primera aparición de un carácter específico en un string.

        Encuentra la primera palabra con más de X letras en una frase.

        ver si una palabra esta en una cadena
        */
        

        // bool hay = false;

        // for(int i = 0; i< numeros.Length;i++){

        //     int cont = 0;


        //         for(int j = 1; j <= numeros[i] ; j++){

        //             if(numeros[i] % j == 0){
        //                 cont++;
        //             }

        //     }

        //     if(cont == 2){
        //         hay = true;
        //     }

        // }

        // return hay;

        //-----------

    //     int i=0;
    //     int num = -1;

    //     while(i<numeros.Length -1 && !(numeros[i] < 0 && numeros[i+1] > 0 )){
    //         i++;
    //     }

    //     if(i<numeros.Length-1){
    //         num = numeros[i];
    //     }

    //     return num;
    // }

    public static bool BuscarNumero(int[,] numeros, int max) {
    int i = 0, j = 0;
    bool esta = false;  // 🔹 Se agrega el punto y coma

    while (i < numeros.GetLength(0) && numeros[i, j] <= max) {  
        j = 0;  // 🔹 Reiniciar j al inicio de cada fila

        while (j < numeros.GetLength(1) && numeros[i, j] <= max) {  
            j++;
        }

        i++;
    }

    // 🔹 Solo será true si el while se detuvo antes de recorrer toda la matriz
    if (i < numeros.GetLength(0)) {  
        esta = true;
    }

    return esta;
}

}


