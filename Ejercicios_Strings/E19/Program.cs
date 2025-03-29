public class Program
{
    public static void Main(string[] args)
    {
        //Calcula la cantidad de veces que se repite un carácter dado en una cadena.

        string frase ="";
        char caracter;
        int contCaracter=0;

        Console.WriteLine("Dame la frase para ver cuantas veces se repite un caracter");
        frase = Console.ReadLine();
        Console.WriteLine("Dame un caracter para ver cuanto se repite: ");
        caracter = Console.ReadKey().KeyChar;
        Console.WriteLine("");

        frase = frase.ToLower(); // Convertir toda la frase a minúsculas
        caracter = char.ToLower(caracter); // Convertir el carácter a minúscula     

        for(int i=0;i<frase.Length;i++){

            if(frase[i]==caracter)
                contCaracter++;

        }

        if (contCaracter > 0)
        {
            Console.WriteLine($"La letra '{caracter}' se ha repetido {contCaracter} veces");
        }
        else
        {
            Console.WriteLine($"La letra '{caracter}' no se ha encontrado");
        }
    }
}