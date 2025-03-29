/* Tranvia, que tendrá información sobre los pasajeros que transporta o podría transportar en cada uno de sus vagones.
Tiene un atributo privado... una tabla vagones, de modo que cada elemento de la tabla debe contener un objeto VagonPasajeros.

Pasajero Bajar(String nombre, int vagon)

int Subir(Pasajero p,int vagon)
*/

namespace tranvias;
using vagones;
using pasajeros;

class Tranvia
{

    private Vagon[] TablaVagones; //guarda objetos vagon, los cuales guardan pasajeros. usa jagged array no?

    public Tranvia()
    {
        TablaVagones = new Vagon[4];
        System.Console.WriteLine($"Vagon de 4 pasajeros");//donde meto vagones que tengo que inicializar con su n pasajeros y luego manipulando meterlos desde aca
        for(int i=0; i<4 ;i++){
            TablaVagones[i] = new Vagon(4);
        }
   }

    public Tranvia(int nVagones) : this()
    {
        TablaVagones = new Vagon[nVagones];
        System.Console.WriteLine($"Vagon de {nVagones} pasajeros");
            for(int i=0; i<nVagones ;i++){ //4 asientos porque si, para cada vagon, asi todos iniciados
            TablaVagones[i] = new Vagon(4);
        }
    }

    public Pasajero Bajar(String nombre, int vagon)
    {
        //          para eliminar al pasajero indicado, del vagón indicado y retornarlo como resultado.
        //  Si no existe ningún pasajero con el nombre indicado, se retornará null.
        //  nota.- los vagones se numeran desde 0 en adelante.

        Pasajero pasajero = null;

        if (vagon >= 0 && vagon < TablaVagones.Length && TablaVagones[vagon] != null)
        { //toca verificar q no pasen uno negativi, ojo
            pasajero = TablaVagones[vagon].Bajar(nombre);
        }

        //si el vagon existe en la posicion del int y en la posicio
        return pasajero;
    }

    public int Subir(Pasajero p, int vagon)
    {
        //  Para intentar subir al pasajero indicado, en el vagón indicado.
        //  Si este vagón está lleno, se intentará en los siguientes.
        //  Si no quedan más vagones detrás, se continuará intentando desde el primer vagón.
        //  Si finalmente no se consigue subir al pasajero a ningún vagón, se lanzará una excepción Exception indicando en 
        // un texto el problema.
        //  Si el vagón solicitado no existe, se lanzará una excepción Exception indicando en un texto el problema.
        //  La función retornará el número del vagón al que haya conseguido subir al pasajero

        //aca se usa el algoritmo de recorrido ciclico que es 
        // int currentIndex = (startingIndex + offset) % arrayLength;
        //en base a este currentIndex se haran las VERIFICACIONES Y OPERACIONES
        //y el recorrido es en un for de i hasta el final, asi se emula una vuelta circular

        //tambien se intentara en cada vuelta añadir a la persona al vagon, pero claro, para ello debe dentro de mi array vagones
        //estar inicializado cada vagon y dentro de este puedo meter gente con subir() o darselo con vagones ya inicializados y guardarlos en travia.
        //si quisiera copiar un tranvia a otro lo manual seria hacer una instancia con un numero mayor y mover los datos alli
        //el añadir se intenta en un try, si da excepcion (ya esta lleno) lo coge el catch y da un mensaje, itera otra vez, hasta que lo logra,
        //si lo logra no sera un error, sino que retornara el vagon donde lo guardo. (un vagon en base al current index de 0 hasta .len), NO EN BASE A I

        for (int i = 0; i < TablaVagones.Length; i++)
        {

            int IndiceCircular = (vagon + i) % TablaVagones.Length; //si es 5 es mod 5

            try
            {
                TablaVagones[IndiceCircular].Subir(p);
                return IndiceCircular;
            }

            catch (System.Exception)
            {

                System.Console.WriteLine($"Error: Vagon #{IndiceCircular} está lleno");
            }

        }

        // Si después de recorrer todos los vagones no se subió al pasajero, lanzamos una excepción
        throw new Exception("Error: No hay espacio en el tren.");
    }
}