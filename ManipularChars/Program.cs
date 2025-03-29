using System;

public class Program
{
    public static void ManipularCaracteres()
    {
        // Ejemplo 1: Obtener el valor numérico de un carácter (código ASCII/Unicode)
        char letra = 'a';
        int valorNumerico = letra; // Convertir el carácter a su valor numérico
        Console.WriteLine($"Valor numérico de '{letra}': {valorNumerico}");

        // Ejemplo 2: Convertir un valor numérico a un carácter
        int valor = 65; // Valor ASCII de 'A'
        char caracter = (char)valor; // Convertir el valor numérico a carácter
        Console.WriteLine($"El carácter correspondiente al valor {valor} es: {caracter}");

        // Ejemplo 3: Convertir letras a mayúsculas y minúsculas
        char letraMinuscula = 'd';
        char letraMayuscula = char.ToUpper(letraMinuscula); // Convertir a mayúscula
        Console.WriteLine($"La letra '{letraMinuscula}' en mayúscula es: {letraMayuscula}");

        char letraMayuscula2 = 'D';
        char letraMinuscula2 = char.ToLower(letraMayuscula2); // Convertir a minúscula
        Console.WriteLine($"La letra '{letraMayuscula2}' en minúscula es: {letraMinuscula2}");

        // Ejemplo 4: Verificar si un carácter es una letra o un número
        char simbolo = '#';
        bool esLetra = char.IsLetter(simbolo);
        bool esNumero = char.IsDigit(simbolo);
        Console.WriteLine($"¿El carácter '{simbolo}' es una letra? {esLetra}");
        Console.WriteLine($"¿El carácter '{simbolo}' es un número? {esNumero}");

        // Ejemplo 5: Comprobar si un carácter es un espacio
        char espacio = ' ';
        bool esEspacio = char.IsWhiteSpace(espacio);
        Console.WriteLine($"¿El carácter '{espacio}' es un espacio? {esEspacio}");

        // Ejemplo 6: Realizar desplazamiento de un carácter (similar a un cifrado)
        char letraOriginal = 'a';
        int desplazamiento = 3; // Desplazamos 3 posiciones
        char letraDesplazada = (char)((letraOriginal - 'a' + desplazamiento) % 26 + 'a');
        Console.WriteLine($"La letra '{letraOriginal}' desplazada {desplazamiento} posiciones es: {letraDesplazada}");

        /* char letraOriginal = 'a'; // La letra original
            int desplazamiento = 3;   // Desplazamiento de 3 posiciones

            // Normalizamos la letra a un valor entre 0 y 25 restando 'a' (97)
            int valorOriginal = letraOriginal - 'a'; // 'a' es 97, entonces 97 - 97 = 0

            // Aplicamos el desplazamiento
            int valorDesplazado = (valorOriginal + desplazamiento) % 26; // 0 + 3 = 3 (y 3 % 26 = 3)

            // Convertimos el valor desplazado de vuelta a un carácter
            char letraDesplazada = (char)(valorDesplazado + 'a'); // 3 + 'a' = 'd' */


        // Ejemplo 7: Comparar dos caracteres
        char letra1 = 'a';
        char letra2 = 'b';
        bool sonIguales = letra1 == letra2;
        Console.WriteLine($"¿La letra '{letra1}' es igual a '{letra2}'? {sonIguales}");

        // Ejemplo 8: Obtener la siguiente letra en el alfabeto
        char letraSiguiente = (char)(letraOriginal + 1);
        Console.WriteLine($"La siguiente letra después de '{letraOriginal}' es: {letraSiguiente}");

        //Ejemplo 9 generar caracteres con random:
          Random random = new Random();
        char letraAleatoria = (char)random.Next('a', 'z' + 1);  // 'a' es inclusivo, 'z' es inclusivo
    }

    static void Main(string[] args)
    {
        ManipularCaracteres();
    }
}
