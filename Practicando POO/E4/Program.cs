internal class Program
{
    private static void Main(string[] args)
    {
       //Clase con Contador: Implementa una clase Contador que lleve la cuenta de cuántas instancias de la clase se han creado.

       Contador contador0 = new Contador();
       Contador contador1 = new Contador();
       Contador contador2 = new Contador();

        System.Console.WriteLine(Contador.VerContador());;

    }
}

class Contador{

    private static int contador = 0;

    public Contador() //no necesita parametro
    {
        // Incrementar el contador estático cada vez que se crea una nueva instancia.
        contador++;
    }

    public static int VerContador(){
        return contador;
    }


}