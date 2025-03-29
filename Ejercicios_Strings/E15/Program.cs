public class Program
{
    public static void Main(string[] args)
    {
        //Dada una cadena de caracteres, elimina los espacios en blanco a ambos extremos de la cadena y la muestra por pantalla.

        string cadena="";
        string cadenaSinEspacio="";
        int contInicio=0;
        int contFinal=0;
        
        Console.WriteLine("Dame una string para quitar los espacios: ");
        cadena=Console.ReadLine();

       // for(int i=0;i<cadena.Length;i++){ NO USAMOS FOR, NO DEBO RECORRER TODO, SOLO LOS ESPACIOS Y SALIR

            int i= 0;

            while(i<cadena.Length && cadena[i] ==' '){
                contInicio++;
                i++;
            }

            int j = cadena.Length-1; // para leer desde el ultimo

            while(j>0 && cadena[j]==' '){
                contFinal++;
                j--;
            }

            for(int sitio=i; sitio<=j;sitio++){

                cadenaSinEspacio+=cadena[sitio];
            }

            Console.WriteLine('.'+cadenaSinEspacio+'.');
            Console.WriteLine($"habian {contInicio+contFinal} espacios en blanco");
    }
}