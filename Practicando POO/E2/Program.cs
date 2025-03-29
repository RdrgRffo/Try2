internal class Program
{
    private static void Main(string[] args)
    {
       
       //Gestión de Lista: Crea una clase Biblioteca que contenga una lista de libros. 
       //Implementa métodos para agregar, eliminar y buscar libros por título.

        // Biblioteca TEA = new Biblioteca("SC tenerife",1111);

        // TEA.Add("El hobbit");
        // TEA.Add("The bull");
        // TEA.Add("el silmarilion");
        // TEA.Add("star wars");

        // System.Console.WriteLine(TEA.Buscar("El silmarilion"));
        // System.Console.WriteLine(TEA.Buscar("el silmarilion"));
        // System.Console.WriteLine(TEA.IndexOf("el silmarilion"));
        // TEA.Delete(2);

        //----------------------------------------

        
    }
}



// class Biblioteca{

//     private List<string> libros = new List<string>(); // es por cada instancia
//     private string Ubicacion;
//     private int nID;

//     public Biblioteca(string Ubicacion, int nID){
//         this.Ubicacion=Ubicacion;
//         this.nID=nID;
//     }

//     public void Add(string titulo){
//         libros.Add(titulo);
//     }

//     public void Delete(string titulo){
//         libros.Remove(titulo);
//     }

//     public void Delete(int pos){
//         libros.RemoveAt(pos);
//     }

//     public bool Buscar(string titulo){
//         return libros.Contains(titulo);
//     }

//     public int IndexOf(string titulo){
//        return libros.IndexOf(titulo);
//     }
// }