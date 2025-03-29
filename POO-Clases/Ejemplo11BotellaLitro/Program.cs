using botellas;
internal class Program
{
    private static void Main(string[] args)
    {
        BotellaLitro b1 = new BotellaLitro();
        BotellaLitro b2 = new BotellaLitro(2f);

        System.Console.WriteLine(b1.Abierto); //estan cerradas
        System.Console.WriteLine(b2.Abierto);

        b1.Abrir();
        b2.Abrir();

        System.Console.WriteLine(b1.Abierto); //estan abiertas
        System.Console.WriteLine(b2.Abierto);

        System.Console.WriteLine(b1.Anadir(1.5f)); //usamos en base a 1
        System.Console.WriteLine(b2.Quitar(0.3f));

        System.Console.WriteLine(b1.Contenido);
        System.Console.WriteLine(b2.Contenido);

        System.Console.WriteLine(b1.EstaLlena());
        System.Console.WriteLine(b1.EstaVacia());
        
        System.Console.WriteLine(b2.EstaLlena());
             System.Console.WriteLine(b2.Quitar(0.7f));
        System.Console.WriteLine(b2.EstaVacia());

        System.Console.WriteLine(b1);
        System.Console.WriteLine(b2);
        System.Console.WriteLine(b2.Equals(new BotellaLitro()));
    }
}