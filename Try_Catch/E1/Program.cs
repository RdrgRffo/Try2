using System;
using System.IO;

class Program
{
    static void Main()
    {
        decimal saldo = 1000; // Saldo inicial del usuario
        try
        {
            Console.Write("Ingrese el monto a retirar: ");
            string entrada = Console.ReadLine();

            // Convertir a decimal (puede lanzar FormatException)
            decimal monto = Convert.ToDecimal(entrada);

            // Validar monto
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a 0.");

            if (monto > saldo)
                throw new InvalidOperationException("Saldo insuficiente.");

            // Realizar la transacción
            saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Saldo restante: {saldo:C}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Entrada no válida. Ingrese un número.");
            LogError(ex);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            LogError(ex);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            LogError(ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado. Intente nuevamente.");
            LogError(ex);
        }
        finally
        {
            Console.WriteLine("Gracias por usar nuestro cajero automático.");
        }
    }

    static void LogError(Exception ex)
    {
        string ruta = "logErrores.txt";
        string mensaje = $"{DateTime.Now}: {ex.GetType()} - {ex.Message}\n";
        
        File.AppendAllText(ruta, mensaje);
    }
}
