public class Program
{
    public static void Main(string[] args)
    {
        //Dada una cadena de caracteres, determina la cantidad de minúsculas y mayúsculas que contiene la cadena
        string frase="";
        int contMayus=0;
        int contMinus=0;

        //solo se puede comparar char con char y string con string. Y por cada letra recorrer cada arreglo.

        char[] mayusculas = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        char[] minusculas = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        Console.WriteLine("Dame una cadena de caracteres para saber cuantas mayusculas y minusculas tiene:");
        frase = Console.ReadLine();

        for(int i=0; i<frase.Length;i++){

            for(int j=0; j<mayusculas.Length;j++){

                if(frase[i]==mayusculas[j])
                    contMayus++;
            }

            for(int x=0; x<minusculas.Length;x++){

                if(frase[i] == minusculas[x])
                    contMinus++;
            }


        }

        Console.WriteLine($"La frase tiene #{contMinus} minusculas y #{contMayus} mayusculas");

    }
}