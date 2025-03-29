using System;

class Programa
{
    private static void Main(string[] args)
    {
        // Definición de cadenas
        string texto = "  Hola Mundo! Bienvenido al mundo de C#.  ";
        string nombre = "Rodrigo";
        string frase = "Rodrigo y Pedro son amigos.";

        // 1. Length: Obtener la longitud de la cadena
        Console.WriteLine("1. Longitud de 'texto': " + texto.Length); // Muestra la longitud
        int longitudTexto = texto.Length; // Almacena en variable
        Console.WriteLine("   Longitud de 'texto' almacenado en variable: " + longitudTexto);

        // 2. Contains: Verifica si la cadena contiene una subcadena
        Console.WriteLine("2. ¿'texto' contiene 'Mundo'? " + texto.Contains("Mundo")); // Muestra si contiene
        bool contieneMundo = texto.Contains("Mundo"); // Almacena en variable
        Console.WriteLine("   Resultado de 'Contains' almacenado en variable: " + contieneMundo);

        // 3. StartsWith: Verifica si la cadena comienza con una subcadena
        Console.WriteLine("3. ¿'texto' empieza con '  Hola'? " + texto.StartsWith("  Hola")); // Muestra si comienza con
        bool empiezaConHola = texto.StartsWith("  Hola"); // Almacena en variable
        Console.WriteLine("   Resultado de 'StartsWith' almacenado en variable: " + empiezaConHola);

        // 4. EndsWith: Verifica si la cadena termina con una subcadena
        Console.WriteLine("4. ¿'texto' termina con 'C#.'? " + texto.EndsWith("C#.")); // Muestra si termina con
        bool terminaConCSharp = texto.EndsWith("C#."); // Almacena en variable
        Console.WriteLine("   Resultado de 'EndsWith' almacenado en variable: " + terminaConCSharp);

        // 5. Trim: Elimina los espacios en blanco al principio y al final de la cadena
        Console.WriteLine("5. 'texto' sin espacios: " + texto.Trim()); // Muestra sin espacios
        string textoSinEspacios = texto.Trim(); // Almacena en variable
        Console.WriteLine("   Resultado de 'Trim' almacenado en variable: " + textoSinEspacios);

        // 6. Substring: Extrae una subcadena de una cadena
        Console.WriteLine("6. Subcadena de 'texto' desde el índice 3: " + texto.Substring(3)); // Muestra la subcadena
        string subcadenaTexto = texto.Substring(3); // Almacena en variable
        Console.WriteLine("   Subcadena de 'texto' almacenada en variable: " + subcadenaTexto);

        // 7. Substring con longitud específica
        Console.WriteLine("7. Subcadena de 'frase' desde el índice 8, con longitud 5: " + frase.Substring(8, 5)); // Muestra la subcadena
        string subcadenaFrase = frase.Substring(8, 5); // Almacena en variable
        Console.WriteLine("   Subcadena de 'frase' almacenada en variable: " + subcadenaFrase);

        // 8. IndexOf: Encuentra el primer índice de una subcadena
        Console.WriteLine("8. Índice de 'Mundo' en 'texto': " + texto.IndexOf("Mundo")); // Muestra el índice
        int indiceMundo = texto.IndexOf("Mundo"); // Almacena en variable
        Console.WriteLine("   Índice de 'Mundo' almacenado en variable: " + indiceMundo);

        // 9. LastIndexOf: Encuentra el último índice de una subcadena
        Console.WriteLine("9. Último índice de 'o' en 'texto': " + texto.LastIndexOf("o")); // Muestra el índice
        int ultimoIndiceO = texto.LastIndexOf("o"); // Almacena en variable
        Console.WriteLine("   Último índice de 'o' almacenado en variable: " + ultimoIndiceO);

        // 10. ToUpper: Convierte todos los caracteres de la cadena a mayúsculas
        Console.WriteLine("10. 'nombre' en mayúsculas: " + nombre.ToUpper()); // Muestra en mayúsculas
        string nombreMayusculas = nombre.ToUpper(); // Almacena en variable
        Console.WriteLine("   'nombre' en mayúsculas almacenado en variable: " + nombreMayusculas);

        // 11. ToLower: Convierte todos los caracteres de la cadena a minúsculas
        Console.WriteLine("11. 'nombre' en minúsculas: " + nombre.ToLower()); // Muestra en minúsculas
        string nombreMinusculas = nombre.ToLower(); // Almacena en variable
        Console.WriteLine("   'nombre' en minúsculas almacenado en variable: " + nombreMinusculas);

        // 12. Replace: Reemplaza caracteres en la cadena
        Console.WriteLine("12. Reemplazar 'Mundo' por 'Universo' en 'texto': " + texto.Replace("Mundo", "Universo")); // Muestra reemplazo
        string textoReemplazado = texto.Replace("Mundo", "Universo"); // Almacena en variable
        Console.WriteLine("   Resultado del 'Replace' almacenado en variable: " + textoReemplazado);

        // 13. Split: Divide la cadena en un array de subcadenas
        string[] palabras = texto.Split(' '); // Divide 'texto' en palabras
        Console.WriteLine("13. Palabras en 'texto': ");
        foreach (var palabra in palabras)
        {
            Console.WriteLine(palabra); // Muestra cada palabra
        }

        // 14. Chars: Trabajar con caracteres de una cadena
        char primerCaracter = texto[0]; // Obtener el primer carácter de la cadena
        Console.WriteLine("14. Primer carácter de 'texto': " + primerCaracter); // Muestra el primer carácter

        foreach (char letra in palabra)
        {
            if (Char.IsUpper(letra))
            {
                Console.WriteLine($"{letra} es mayúscula");
            }
            else if (Char.IsLower(letra))
            {
                Console.WriteLine($"{letra} es minúscula");
            }

        // -------------------------------------------------------------- 
        // ------------------------Números-------------------------------
        // --------------------------------------------------------------
        
        int num1 = 25;
        int num2 = 10;
        double num3 = 9.7;
        double num4 = 3.2;

        // 1. Math.Abs: Valor absoluto
        Console.WriteLine("1. Valor absoluto de num1: " + Math.Abs(num1)); // Muestra el valor absoluto
        int valorAbsoluto = Math.Abs(num1); // Almacena en variable
        Console.WriteLine("   Valor absoluto de num1 almacenado: " + valorAbsoluto);

        // 2. Math.Sqrt: Raíz cuadrada
        Console.WriteLine("2. Raíz cuadrada de num1: " + Math.Sqrt(num1)); // Muestra la raíz cuadrada
        double raizCuadrada = Math.Sqrt(num1); // Almacena en variable
        Console.WriteLine("   Raíz cuadrada de num1 almacenada: " + raizCuadrada);

        // 3. Math.Pow: Potencia (elevar un número)
        Console.WriteLine("3. num2 elevado a la potencia 2: " + Math.Pow(num2, 2)); // Muestra potencia
        double potencia = Math.Pow(num2, 2); // Almacena en variable
        Console.WriteLine("   Resultado de Math.Pow almacenado: " + potencia);

        // 4. Math.Round: Redondear número
        Console.WriteLine("4. Redondeo de num3: " + Math.Round(num3)); // Muestra redondeo
        double redondeo = Math.Round(num3); // Almacena en variable
        Console.WriteLine("   Redondeo de num3 almacenado: " + redondeo);

        // 5. Math.Ceiling: Redondeo hacia arriba
        Console.WriteLine("5. Redondeo hacia arriba de num3: " + Math.Ceiling(num3)); // Muestra redondeo hacia arriba
        double redondeoArriba = Math.Ceiling(num3); // Almacena en variable
        Console.WriteLine("   Redondeo hacia arriba de num3 almacenado: " + redondeoArriba);

        // 6. Math.Floor: Redondeo hacia abajo
        Console.WriteLine("6. Redondeo hacia abajo de num4: " + Math.Floor(num4)); // Muestra redondeo hacia abajo
        double redondeoAbajo = Math.Floor(num4); // Almacena en variable
        Console.WriteLine("   Redondeo hacia abajo de num4 almacenado: " + redondeoAbajo);

        // Arrays
        int[] numeros = { 5, 3, 9, 1, 7, 6 };

        // 7. Array.Length: Obtener la longitud del array
        Console.WriteLine("7. Longitud del array 'numeros': " + numeros.Length); // Muestra la longitud
        int longitudArray = numeros.Length; // Almacena en variable
        Console.WriteLine("   Longitud del array almacenada: " + longitudArray);

        // 8. Array.Sort: Ordenar un array
        Array.Sort(numeros); // Ordena el array
        Console.WriteLine("8. Array ordenado: " + string.Join(", ", numeros)); // Muestra el array ordenado
        int[] arrayOrdenado = (int[])numeros.Clone(); // Almacena el array ordenado en una nueva variable
        Console.WriteLine("   Array ordenado almacenado: " + string.Join(", ", arrayOrdenado));

        // 9. Array.Reverse: Invertir el orden de un array
        Array.Reverse(numeros); // Invierte el array
        Console.WriteLine("9. Array invertido: " + string.Join(", ", numeros)); // Muestra el array invertido
        int[] arrayInvertido = (int[])numeros.Clone(); // Almacena el array invertido en una nueva variable
        Console.WriteLine("   Array invertido almacenado: " + string.Join(", ", arrayInvertido));

        // 10. Array.IndexOf: Buscar un valor en el array
        int index = Array.IndexOf(numeros, 7); // Busca el valor 7
        Console.WriteLine("10. Índice de '7' en el array: " + index); // Muestra el índice
        int indice7 = index; // Almacena el índice en variable
        Console.WriteLine("   Índice de '7' almacenado: " + indice7);

        // 11. Array.Copy: Copiar parte de un array
        int[] copiaArray = new int[3];
        Array.Copy(numeros, copiaArray, 3); // Copia los primeros 3 elementos
        Console.WriteLine("11. Copia de los primeros 3 elementos del array: " + string.Join(", ", copiaArray)); // Muestra la copia

        // 12. Array.Exists: Verificar si un valor existe en el array
        bool existe = Array.Exists(numeros, num => num == 5); // Verifica si el 5 está en el array
        Console.WriteLine("12. ¿El número 5 existe en el array? " + existe); // Muestra el resultado
        bool existe5 = existe; // Almacena el resultado en variable
        Console.WriteLine("   Resultado de 'Exists' almacenado: " + existe5);

        // Otros Materiales
        string texto = "El valor de PI es aproximadamente 3.14159";

        // 13. Convert.ToInt32: Convertir una cadena a entero
        string numCadena = "42";
        int numeroConvertido = Convert.ToInt32(numCadena); // Convierte a entero
        Console.WriteLine("13. Conversión de cadena a número: " + numeroConvertido); // Muestra el número convertido

        // 14. Parse: Convertir una cadena a un número con manejo de errores
        int numParse = int.Parse("100"); // Convierte de cadena a entero
        Console.WriteLine("14. Conversión de cadena a número con 'Parse': " + numParse); // Muestra el número convertido

        // 15. TryParse: Intentar convertir con manejo de errores
        string cadenaNumero = "200";
        if (int.TryParse(cadenaNumero, out int resultado))
        {
            Console.WriteLine("15. Conversión exitosa con TryParse: " + resultado); // Muestra el resultado si es exitoso
        }
        else
        {
            Console.WriteLine("   Error al convertir la cadena.");
        }

        // 16. Math.Min: Obtener el valor mínimo entre dos números
        Console.WriteLine("16. El valor mínimo entre num1 y num2 es: " + Math.Min(num1, num2)); // Muestra el valor mínimo
        int minValor = Math.Min(num1, num2); // Almacena el valor mínimo
        Console.WriteLine("   Valor mínimo almacenado: " + minValor);

        // 17. Math.Max: Obtener el valor máximo entre dos números
        Console.WriteLine("17. El valor máximo entre num1 y num2 es: " + Math.Max(num1, num2)); // Muestra el valor máximo
        int maxValor = Math.Max(num1, num2); // Almacena el valor máximo
        Console.WriteLine("   Valor máximo almacenado: " + maxValor);

    }
}
