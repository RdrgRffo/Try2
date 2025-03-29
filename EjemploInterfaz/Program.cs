public class Program
{
    private static void Main(string[] args)
    {

        //uso de interfaces en una app de avisos.

        AvisoTrafico av1 = new AvisoTrafico();
        //constructor base

        av1.MostrarAviso();

        AvisoTrafico av2 = new AvisoTrafico("Jefatura","Sanción por velocidad grave","2/5/2019");
   
        av2.MostrarAviso();
    }
}

//metodos en clase abstracta se puede desarrollar o hacer uno abstracto (obligatorio su desarrrollo ene subclasees)
//la herencia se hace en cascada y el que hereda, se lleva lo de su superior y su herencia
//los metodos bastract se le hace override, como a los virtual
//de mamifero a reptil no hereda, asi que respirar no podria ser virtual en mamifero, tiene que ser abstract en animal
interface IAviso{

    //solo se pueden declarar metoodos, no llevan encapsulado
    //no pueden ser atributos tampoco

    void MostrarAviso();

    string GetFecha(); //no con int? no se

    //METODOS OBLIGADOS CUANDO USE IAVISOS

}

class AvisoTrafico : IAviso{ //implementa interfaz

    private string remitente;

    private string contenido;

    private string fecha;

    public AvisoTrafico(){
        //constructor x defecto sin parametro generico siempre
        remitente = "DGT"; //se declaran los default
        contenido = "Sanción cometida, pague la multa";
        fecha = ""; //luego se podria modificar
    }


    public AvisoTrafico(string r, string c, string f){

        remitente = r;
        contenido = c;
        fecha = f;

    }

    public string GetFecha(){
        return fecha;
    }

    public void MostrarAviso(){
        System.Console.WriteLine($"Mensaje : {contenido}, remitente: {remitente}, dia: {fecha}");
    }

}