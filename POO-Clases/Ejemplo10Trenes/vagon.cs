namespace vagones;
using pasajeros;

class Vagon
{

    //tabla guardara los nombres de los pasajeros
    private Pasajero[] TablaAsientos; //cada asiento puede estar libre o ocupado
    protected int indice = 0;


    public Vagon(int capacidad)
    {
        //recibe numero de asientos para crear tabla    
        TablaAsientos = new Pasajero[capacidad];

    }

    public void subir(Pasajero pasajero)
    {

        //acomoda al pasajero en el vagón, los asientos se llenan en orden según lleguen pasajeros, si no hay asientos libres debe lanzarse una excepción (Exception).

        if (indice >= TablaAsientos.Length) //si el indice llega a ser igual que .Length (No  tuilizables)
        {
            throw new Exception("Error: No hay más espacio en el tren");
        }

        TablaAsientos[indice] = pasajero;
        indice++;

    }

    public Pasajero Bajar(string nombre)
    {

        //recibe el nombre del pasajero que debe apearse, lo elimina del vagón y devuelve el objeto correspondiente
        int i= 0;
        Pasajero guardado = null;

        while (i < TablaAsientos.Length && !TablaAsientos[i].GetNombre().Equals(nombre)){
            i++;
        } //que mostrare si se sale sin encontrarr , si no es n

        if(i < TablaAsientos.Length && TablaAsientos[i].GetNombre().Equals(nombre)){
            
            guardado = TablaAsientos[i];
            
            while(i < TablaAsientos.Length-1){
                TablaAsientos[i] = TablaAsientos[i+1]; //esto lo hace hasta el penultimo donde guarda el ultimo y el ultimo lo pone a null
                i++;
            }

            TablaAsientos[TablaAsientos.Length - 1] = null; //len es un numero no accesible se usa el anterior
            indice--;

        }

        return guardado;

    }

    public override string ToString(){
        return $"El vagon tiene {indice} pasajeros";
    }


    public override bool Equals(object obj){

        if(obj == null || GetType() != obj.GetType())
        return false;


        Vagon otroVagon = (Vagon)obj;
        return indice == otroVagon.indice;

    }
}