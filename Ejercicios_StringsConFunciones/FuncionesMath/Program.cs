public class Program
{
    public static void Main(string[] args)
    {
        // 1. Redondeo y aproximación
        Console.WriteLine("Redondeo:");
        Console.WriteLine($"Round(3.6): {Math.Round(3.6)}"); // 4
        Console.WriteLine($"Ceiling(3.2): {Math.Ceiling(3.2)}"); // 4
        Console.WriteLine($"Floor(3.8): {Math.Floor(3.8)}"); // 3
        Console.WriteLine($"Truncate(3.8): {Math.Truncate(3.8)}"); // 3

        // 2. Valor absoluto
        Console.WriteLine("\nValor absoluto:");
        Console.WriteLine($"Abs(-5): {Math.Abs(-5)}"); // 5

        // 3. Potencias y raíces
        Console.WriteLine("\nPotencias y raíces:");
        Console.WriteLine($"Pow(2, 3): {Math.Pow(2, 3)}"); // 8
        Console.WriteLine($"Sqrt(9): {Math.Sqrt(9)}"); // 3
        Console.WriteLine($"Cbrt(27): {Math.Cbrt(27)}"); // 3

        // 4. Logaritmos y exponentes
        Console.WriteLine("\nLogaritmos y exponentes:");
        Console.WriteLine($"Log(2.71828): {Math.Log(2.71828)}"); // ~1
        Console.WriteLine($"Log10(100): {Math.Log10(100)}"); // 2
        Console.WriteLine($"Exp(1): {Math.Exp(1)}"); // ~2.71828

        // 5. Signo
        Console.WriteLine("\nSigno:");
        Console.WriteLine($"Sign(-5): {Math.Sign(-5)}"); // -1
        Console.WriteLine($"Sign(0): {Math.Sign(0)}"); // 0
        Console.WriteLine($"Sign(5): {Math.Sign(5)}"); // 1
    }
}