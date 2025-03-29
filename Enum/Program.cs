using System;

// Definimos un namespace para organizar el código
namespace GestionPedidos
{
    // Enumeración que representa los diferentes estados de un pedido
    enum EstadoPedido
    {
        Pendiente,   // Pedido registrado pero no procesado
        Procesando,  // Pedido en proceso
        Enviado,     // Pedido enviado al cliente
        Entregado,   // Pedido entregado exitosamente
        Cancelado    // Pedido cancelado y no se procesará
    }

    // Clase que representa un pedido
    class Pedido
    {
        public int Id { get; }
        public EstadoPedido Estado { get; private set; }

        // Constructor de la clase Pedido
        public Pedido(int id)
        {
            Id = id;
            Estado = EstadoPedido.Pendiente; // Todos los pedidos inician como "Pendiente"
        }

        // Método para cambiar el estado del pedido
        public void CambiarEstado(EstadoPedido nuevoEstado)
        {
            if (!EsCambioValido(nuevoEstado))
            {
                Console.WriteLine($"No se puede cambiar de {Estado} a {nuevoEstado}.");
                return;
            }

            Estado = nuevoEstado;
            Console.WriteLine($"Pedido {Id} cambiado a estado: {Estado}");
        }

        // Método privado para validar los cambios de estado
        private bool EsCambioValido(EstadoPedido nuevoEstado)
        {
            return Estado switch
            {
                EstadoPedido.Pendiente => nuevoEstado == EstadoPedido.Procesando || nuevoEstado == EstadoPedido.Cancelado,
                EstadoPedido.Procesando => nuevoEstado == EstadoPedido.Enviado || nuevoEstado == EstadoPedido.Cancelado,
                EstadoPedido.Enviado => nuevoEstado == EstadoPedido.Entregado,
                EstadoPedido.Entregado => false, // No se puede cambiar después de entregado
                EstadoPedido.Cancelado => false, // No se puede cambiar si está cancelado
                _ => false
            };
        }
    }

    // Clase principal donde se ejecuta el programa
    class Program
    {
        static void Main()
        {
            // Creación de un nuevo pedido con ID 1001
            Pedido pedido = new Pedido(1001);
            
            // Cambio de estado progresivo siguiendo las reglas establecidas
            pedido.CambiarEstado(EstadoPedido.Procesando);
            pedido.CambiarEstado(EstadoPedido.Enviado);
            pedido.CambiarEstado(EstadoPedido.Entregado);
            pedido.CambiarEstado(EstadoPedido.Cancelado); // No debería permitirse

            Console.ReadLine(); // Mantiene la consola abierta para ver resultados


             // Mostrar los nombres de los estados usando el casteo a string
            foreach (EstadoPedido estado in Enum.GetValues(typeof(EstadoPedido)))
            {
                Console.WriteLine($"Estado: {estado.ToString()}");
            }

        }
    }
}
