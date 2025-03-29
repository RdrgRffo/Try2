public class Programa {
    public static void Main()
    {
        SopaLetras sopa = new SopaLetras(8, 6);
        sopa.AñadirPalabra("hola", 1, 1, 1, 4);
        sopa.AñadirPalabra("YO", 1, 3, 1, 4);
        sopa.AñadirPalabra("llave", 3, 0, 3, 4);
        sopa.AñadirPalabra("flan", 7, 5, 4, 2);
        sopa.AñadirPalabra("ajedrez", 6, 5, 0, 5);
        sopa.Completar();

        Console.WriteLine("Sopa de letras inicial:");
        Console.WriteLine(sopa);

        Console.WriteLine("\nDescubriendo 'llave':");
        sopa.Descubrir(3, 0, 3, 4);
        Console.WriteLine(sopa);

        Console.WriteLine("\nResolviendo toda la sopa:");
        sopa.Resolver();
        Console.WriteLine(sopa);
    }
}
