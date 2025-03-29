

class Torneo
{
    /*Crear un sistema de combate donde los personajes se enfrenten entre sí.
    Agregar enemigos genéricos con inteligencia básica.
    Añadir ataques especiales con diferentes efectos.
    hacer Lista de grupos 2v2
    iniciar comabte y parar combarte si dos estan a 0*/

    List<Personaje> Battleground = new List<Personaje>;


    public void ElegirJugadores()
    {

    }

    public void IniciarCombate(Personaje p1, Personaje p2)
    {

        /*Código Ajustado:
Cada personaje dentro del equipo tiene la posibilidad de elegir a qué enemigo atacar.
Se recorre cada personaje del equipo y se les permite decidir a quién atacar o si defenderse.
Cuando todos los personajes de un equipo han actuado, el turno pasa al siguiente equipo.

Al momento de usar metodos de interfaz en ataque : // Si el personaje es un Guerrero, usa el método Cortar
                if (personaje is IGuerrero guerrero)
                {
                    // Se puede atacar usando el método Cortar
                    guerrero.Cortar(personaje);  // Ataque de Guerrero*/

    }

    public void LimpiaDerrotado()
    {
        //tendria que limpiar despues de cada turno marcandolo como null o usar el remove
    }

    public void AcabaCombate()
    {

    }

}

/*List<List<Personaje>> equipos = new List<List<Personaje>>
{
    new List<Personaje> // Equipo 1
    {
        new Mago { Nombre = "Merlín" },
        new Guerrero { Nombre = "Espartaco" },
        new Defensor { Nombre = "Leonidas" }
    },
    new List<Personaje> // Equipo 2
    {
        new Mago { Nombre = "Dumbledore" },
        new Guerrero { Nombre = "Achilles" },
        new Defensor { Nombre = "Eddard Stark" }
    }
};
*/

//si quiero usar metodos de clases que no son la generica (usada en list), tengo que usar moldeador de tipo : 

/*foreach (var personaje in personajes)
{
    if (personaje is Mago) -----> se usa el is para definir de que SUBCLASE es.
    {
        ((Mago)personaje).Hechizar();  ----> luego se moldea el tipo para poder usar su metodo
    }
    else if (personaje is Guerrero)
    {
        ((Guerrero)personaje).Frenesi();
    }
    else if (personaje is Defensor)
    {
        ((Defensor)personaje).Proteger();
    }*/

//lo otro es hacer que en la clase base se tengan metodos virutales y luego se sobreescriban en cada instancia, asi lo 
//podra usar el foreach en cada iteracion sobre persona ->  public virtual void HabilidadEspecial() {} // Método virtual opcional

/* 1. Elegir Jugadores con un switch
Usar un switch para elegir jugadores y asignarlos a equipos es una excelente opción si tienes un conjunto predefinido de personajes para elegir. En cada ronda, puedes ofrecer al usuario la opción de elegir qué personaje quiere agregar a su equipo y luego asignarlo a la lista correspondiente.

2. Crear los Equipos
Cuando el jugador elige un personaje, lo añades al equipo correspondiente. Para esto, puedes tener dos listas (equipo1 y equipo2).

3. Turnos de Combate
Una vez que los jugadores están asignados a los equipos, puedes realizar un ciclo en el cual ambos equipos se turnan para atacar o defender.

4. Invocar Métodos Específicos para Cada Personaje
Dependiendo de la acción que el personaje elija (atacar, defender, etc.), debes invocar el método correspondiente para cada instancia de personaje.

Esquema General:
Definir las Clases de Personaje y Métodos de Acción
Cada personaje tendrá métodos como Atacar(), Defender(), UsarHechizo(), etc.
Crear el Combate:
Se tendrá un while que continua mientras haya personajes con vida en ambos equipos. En cada ciclo, el jugador puede elegir qué hacer (atacar, defender, etc.). */