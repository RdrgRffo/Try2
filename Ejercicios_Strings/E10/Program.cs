public class Program
{
    public static void Main(string[] args)
    {
        //Dada una frase y una palabra, eliminar esa palabra de la frase tantas veces como aparezca, diciendo la frase sin ellas y el número de veces que se ha eliminado. 
        //Por ejemplo: dada la frase: “Hola amigo. Como estas amigo. Yo estoy muy bien amigo.”, y la palabra “amigo”, debe devolver: “Hola. Como estas. Yo estoy muy bien.”
        // y mostrar el valor 3, por eliminarlo tres veces. Se debe eliminar la palabra, y el espacio en blanco anterior si lo hubiera.

        string frase="";
        string palabra="";
        string fraseSinEsp="";
        int i = 0;

        Console.WriteLine("Dame la frase: ");
        frase=Console.ReadLine();

        Console.WriteLine("Eliminación de espacios: ");

        int sinEsp=0;

        while(i<frase.Length && frase[i] == ' '){
            i++;
        }

        for(int x=i;x<frase.Length;x++){
            fraseSinEsp+=frase[x];
        }
        
        Console.WriteLine($"La string sin espacios es:{fraseSinEsp}");

        //--------------------------------------------------------------//

        //tengo fraseSinEsp
        string palabra="";

        Console.WriteLine("Dame una palabra para eliminarla de la frase:")
        palabra = Console.ReadLine();

        for(int x=0;x<fraseSinEsp.Length;x++){

            


        }
    }
}