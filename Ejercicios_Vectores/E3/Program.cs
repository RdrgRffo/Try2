public class Program
{
    public static void Main(string[] args)
    {
        //Solicitar 10 números por teclado. A continuación, solicitar otro. 
        //Buscar ese último número entre los 10 primeros y decir, en el caso de que esté, en qué lugar fue introducido.

        int busca, i; // i es para usarla en todos los bucles, como bandera,y se va reiniciando
        int[] lista = new int[10];


        Console.WriteLine("Programa. buscar un número dentro de array de 10 números");
        Console.WriteLine("-----------------------------");

        for (i = 0; i < 10; i++) //asignar valores a array
        {
            Console.Write("Dame un número para añadirlo al array:  ");
            lista[i] = Convert.ToInt32(Console.ReadLine());
        } //acá i vale 11

        Console.Write("Dame un número para buscarlo:  "); //numero buscado
        busca = Convert.ToInt32(Console.ReadLine()); 

        //ahora busqueda lineal

        i = 0; //contador para while , existe para que la pregunta del while siga su respuesta fuera, y poder hacer if y else. [es un reinicio]

        // OPCIÓN MENOS OPTIMA --------------------------------------------------------------------

        // //while(lista[i] != busca && lista[i] < lista.Length){ 
        // //mientras no encuentre el  numero que busca y el valor contador sea menor que la longitud del array
        // //se usa ALREVEZ para evitar error index out bounds
        // while(lista[i] < lista.Length && lista[i] != busca){ 
        //     i++;
        // }
        // //cuando lo encuentra se sale con el valor de i por la segunda condicion
        // //al encontrarlo mostrará donde está o si no está (else)
        // if(i<lista.Length){
        //     Console.WriteLine($"el numero {busca} está en la posición {i}");
        // }
        // else{
        //     Console.WriteLine("el numero no está");
        // }-------------------------------------------------------------------------------------------

        //OPCIÓN MAS OPTIMA YA QUE NO OCURRIRA EL ERROR INDEX OUT BOUND Y PODEMOS HACER UNA COMPARACIÓN DIRECTA

        while (lista[i] < lista.Length - 1 && lista[i] != busca)
        {  //ACÁ SE SALE EN EL 9 SI TABLA TIENE 10 ,NO HABRÁ ERROR
            i++;
        }
        //cuando lo encuentra se sale con el valor de i por la segunda condicion
        //al encontrarlo mostrará donde está o si no está (else)

        //en estos casos el if debe ir fuera del while, todo ocurré posst while, con una condición que sale del while con un valor "i" de contador

        if (lista[i] == busca)
        { //acá si podemos buscar el rollo directamente
            Console.WriteLine($"el numero {busca} está en la posición {i}");
        }
        else
        {
            Console.WriteLine("el numero no está");
        }

    }
}
//busqueda lineal con while (para no recorrer todo sin usar break)
//inicializo un valor a cero, lobuscado es el 11avo numero y usamos while (valor<lenght-1 && lobuscado!= datos[i])
//incremento la i en 1  para recorrer y buscar en cada paso, y sirve porque el largo del array es lo que he metido
//if (lobuscado == datos[i]) entonces true = encontrado en posicion i else ps no esta
//la posicion i puede estar asociada en dos sitios tabla 1 [1] "enero" y tabla 2 [1] "30dias", datos asociados que al recorrer
//en un bucle for, puedo mostrar a la vez con posición "i"