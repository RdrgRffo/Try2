public class Programa
{
    public static void Main(string[] args)
    {
        double[] tiempos = { 1.50, 1.48, 2.06, 1.50, 1.69, 2.06, 1.88, 1.92 };
        double[] penalizaciones = { 0.10, 0.20, 0.00, 0.00, 0.00, 0.04, 0.00, 0.60 };
        String[] nombres = { "Aitor", "Felisa", "Jonay", "Ester", "Ángela", "Tomás", "Óscar", "Taida" };
        double[] totales; //lo declare por un error de abandonar metodo actual

        string Ganador = Ejercicio2.Ganador(tiempos, nombres, penalizaciones, out totales);

        Console.WriteLine($"GANADORA: {Ganador}");

        Console.WriteLine("Totales: ");

        for (int i = 0; i < totales.Length; i++)
        {
            Console.WriteLine($"{totales[i]:f02}");
        }

    }
}

public class Ejercicio1
{
    public static string Reproducir(char[] a, char[] b)
    {
        string CadenaRandom = " ";
        Random random = new Random();

        for (int i = 0; i < a.Length; i++) //Esto no había que hacerlo, las tablas estaban rellanas.
        {
            a[i] = (char)random.Next('a', 'c' + 1);
            b[i] = (char)random.Next('a', 'c' + 1);
        }

        for (int j = 0; j < a.Length; j++)
        {
            int Probabilidad = (int)random.Next(0, 2);  // 2 no lo incluye en el rango
            //tambien podia ser de cero a 1 ya que es (50/50)

            if (Probabilidad > 0)
                CadenaRandom = CadenaRandom + a[j];
            else
                CadenaRandom = CadenaRandom + b[j];
        }

        return CadenaRandom;
    }

}

public class Ejercicio2
{
    public static string Ganador(double[] tiempos, string[] nombres, double[] penalizaciones, out double[] totales)
    {
        // Asignar memoria a "totales"
        totales = new double[nombres.Length]; //NO DEBO VOLVER A INICIALIZAR, SOLO ASIGNAR A TOTALES

        string NombreGanador = " ";
        int ValorMinimo = 3;
        double Min = double.MaxValue;

        if (nombres.Length > ValorMinimo)
        {
            // Calcular totales
            for (int i = 0; i < totales.Length; i++)
            {
                totales[i] = tiempos[i] + penalizaciones[i];
            }

            // Buscar el ganador
            for (int j = 0; j < totales.Length; j++)
            {
                if (totales[j] < Min)
                {
                    Min = totales[j];
                    NombreGanador = nombres[j];
                }
            }

            return NombreGanador;
        }

        // Si no se cumple la condición, asignar un valor por defecto
        totales = new double[0]; // Evitar errores por no inicializar
        return "No hay ganador";
    }
}

/* Para probar la primera función escribí este programa : 
        int tam = 20;
        char[] a = new char[tam];
        char[] b = new char[tam];

        
        Console.Write("String generado: ");
        Console.WriteLine(Ejercicio1.Reproducir(a,b));
*/