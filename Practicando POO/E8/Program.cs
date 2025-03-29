internal class Program
{
    private static void Main(string[] args)
    {
        //Implementa una función que busque un número en un arreglo y devuelva true si existe, o false si no.Búsqueda del mayor valor

        // System.Console.WriteLine(BuscaNumeroMenor(new int[] { 1, 2, 4, -3, 10, 6, 3}, 9, 12));
        // System.Console.WriteLine(CuentaNum(new int[] { 1,6,5,7,8,2,3,10 }, 6));

        // System.Console.WriteLine(IndexOf(new char[] { 'a', 'b', 'c', 'd', 'e' }, 'd'));

        // int first;
        // int last;

        // System.Console.WriteLine(Palabra(new string[] { "hola", "como", "va", ",", "eso"}, ","));


        //Encuentra la primera ocurrencia de una secuencia específica dentro de un arreglo. 
        //Por ejemplo, busca si el patrón [3, 4, 5] aparece en [1, 2, 3, 4, 5, 6].
        System.Console.WriteLine(interno(new int[] { 1, 2, 3, 4, 5, 6,7, 3, 4, 5,8 }, new int[] { 3, 4, 5 }));


    }




// public static bool BuscaNumero(int[] array, int num){

//     int i= 0;
//     bool Esta = false;

//     while( i < array.Length && array[i] != num){ //el length -q es cuando se compara con uno posterior

//         if(array[i] == 4){
//             Esta=true;
//         }
//         i++; //cuando acaba i vae a.l -1 pues entra, el incremento siempre va al final
//     }

//     System.Console.WriteLine(i);

//     return Esta;

// } 


//     public static bool BuscaNumeroMenor(int[] array, int n1, int n2){

//         //Implementa una variante que devuelva true si hay al menos un número dentro de un rango definido por dos valores dados.
//         //Contar cuántas veces aparece un número

//     int i= 0;
//     bool EnRango = true;

//     while( i < array.Length && !(array[i] > n1 && array[i] < n2)){ //verifica indice y luego el rango, siempre q se sale al final vale.leng y no entra

//         i++; //cuando acaba i vae a.l -1 pues entra, el incremento siempre va al final
//     }

//     if(i == array.Length)
//     EnRango=false;

//     return EnRango;

// }

// public static int CuentaNum(int[] array, int num)
// {

//     //En vez de buscar un número exacto, busca el primer número mayor a un valor dado.
//     //Búsqueda de números pares o impares
//     int i = 0;
//     int numV = -1;

//     while(i < array.Length && array[i] <= num){
//         i++;
//     }

//     if(i != array.Length){
//         numV = array[i];
//     }

//     return numV;

// }

/*Búsqueda de números pares o impares
Implementa una variante que devuelva cuántos números pares o impares hay en el arreglo.*/

// public static int FnLIndexOf(char[] array, out int f, out int l, int buscado)

// public static int Palabra(string[] array, string palabra)

public static int interno(int[] array, int[] arrayInterno)
{
    // contP = 0;
    // contI=0;
    // for(int i = 0;i<array.Length;i++){

    //     if(array[i] % 2 == 0){
    //         contP++;
    //     }

    //     else
    //         contI++;
    // }

    // f = -1;
    // l = 0;

    // for(int i = 0; i<array.Length; i++){

    //     if(array[i] == buscado && f == -1){
    //         f = i;
    //     }

    //     if(array[i] == buscado ){
    //         l = i;
    //     }

    // }

    // int i =0;
    // int pos = -1;

    // while(i < array.Length && array[i] != palabra){
    //     i++;
    // }

    // if(i < array.Length){
    //     pos = i;
    // }

    // return i;

    //Encuentra el primer número que sea divisible por X pero no por Y en el arreglo.
    // int i = 0;
    // int num = -1;

    // while(i<array.Length && !(array[i] % 5 == 0 && array[i] % 3 != 0)){
    //     i++;
    // } devuelve que es 10

    // if(i != array.Length ){
    //     num = array[i];
    //     System.Console.WriteLine("Estaba en la pos: "+i);}

    // return num;

    int contador = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arrayInterno[0]) // Verifica si el primer valor coincide
        {
            int j = 0;
            // Verifica si el patrón completo coincide
            while (j < arrayInterno.Length && array[i + j] == arrayInterno[j])
            {
                j++;
            }

            if (j == arrayInterno.Length) // Si se encontró una coincidencia completa
            {
                contador++; // Incrementa el contador
            }
        }


    }

    
    return contador;

}

}

