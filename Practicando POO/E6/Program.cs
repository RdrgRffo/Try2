internal class Program
{
    private static void Main(string[] args)
    {

        System.Console.WriteLine("Bienvenido a la tienda, que acción desea realizar?");
        System.Console.WriteLine("1.Añadir Producto(y stock)\n2.Aplicar descuento\n3.Ver detalles del producto\n4.Calcular precio final\n5.Comprar producto");
        int entrada= Int32.Parse(Console.ReadLine());
        switch(entrada){

        case 1:
            System.Console.WriteLine("Introduzca el nombre del producto");
            string Nombre = Console.ReadLine();
            System.Console.WriteLine("Introduzca el precio");
            int precio= Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Introduzca el stock en tienda");
            int stock= Int32.Parse(Console.ReadLine());
            Producto 
            break;


        }






        // //Clase Producto: Diseña una clase Producto con atributos nombre y precio.
        // // Crea métodos para aplicar un descuento al precio y mostrar el precio final.

        // Producto p1 = new Producto("Jabón",5);
        // Producto p2 = new Producto("shampoo",3);
        // Producto p3 = new Producto("Lejia",4);
        // Producto p4 = new Producto("Quitamancha",8);

        // // p1.Descuento(0.20m);
        // // p2.Descuento(0.10m);
        // // p3.Descuento(0.05m);
        // // p4.Descuento(0.12m);

        // p1.SetNewPrecio(12);
        // p1.Descuento(0.20m);

        // System.Console.WriteLine(p1.PrecioFinal());
        // // System.Console.WriteLine(p2.PrecioFinal());
        // // System.Console.WriteLine(p3.PrecioFinal());
        // // System.Console.WriteLine(p4.PrecioFinal());

        // Tienda market = new Tienda();

        // market.AñadirProducto(p1);
        // market.AñadirProducto(p2);
        // market.AñadirProducto(p3);
        // market.AñadirProducto(p4);

        // market.QuitarProducto(p1);

        // System.Console.WriteLine(market.IndexOf(p1));
        // System.Console.WriteLine(market.IndexOf(p2));

    }
}

class Producto{

    private string nombre;
    private int precio;

    private decimal PostDescuento= 0.0m; //nomenclatura decimal propia de tipos para manejo de dinero , tengo q inicializarla en constructor

    public Producto(string nombre,int precio){

        this.nombre=nombre;
        this.precio=precio;
        this.PostDescuento = precio; // si no lo inicializo y luego muesto PostDesc, me daria 0.0m
    }

    public decimal Descuento(decimal PorcientoDescuento){

        if(PorcientoDescuento < 0 || PorcientoDescuento > 1){
            throw new ArgumentException ("El descuento no puede ser menor que 0 ni mayor a 1");
        }

        PostDescuento = precio - (precio*PorcientoDescuento); //precio le resto el descuento que es 0.Algo*precio (me da la cantidad a restar)

        return PostDescuento;
    }

    public string PrecioFinal(){

        return $"El precio final del {nombre} es {PostDescuento}";
    }

    //metodo para volver precio a sin Descuento

    public void PreciOriginal(){
        PostDescuento=precio;
    }

    public void SetNewPrecio(int NuevoPrecio){ //lo actualiza de este producto
        this.precio = NuevoPrecio;
    }


}

class Tienda{
private List<Producto> Stock = new List<Producto>(); //Siempre con 'L' y () al final.


    public void AñadirProducto(Producto producto){
        Stock.Add(producto);
    }

    public void QuitarProducto(Producto producto){
        Stock.Remove(producto);
    }

    public int IndexOf(Producto producto){
       return  Stock.IndexOf(producto);
    }

    public int Count(){
        return Stock.Count; //count como .Length es una propiedad no lleva()
    }

}