internal class Program
{
    private static void Main(string[] args)
    {
        // saludos con bidimensional [,] 

        int opcion;

        Persona p1 = new Persona();

        Persona.VerIdiomas();

        p1.EligeIdioma(1);

       System.Console.WriteLine(p1.Saludar());

        // System.Console.WriteLine("Inserte opcion de dialogo 0.Saludar / 1.Preguntar / 2.Despedida");

        // do{
        // opcion = Int32.Parse(Console.ReadLine());
        // System.Console.WriteLine("Inserte un número valido");
        // }while(opcion < 0 || opcion >2);

        // System.Console.WriteLine(p1.Habla(opcion));

    }

    class Persona
    {

        private int EN = 0;
        private int ES = 1;
        private int FR = 2;

        private int IdiomaPersona;

        private string[,] Dialogo = new string[3, 3] {
    { "Hello!", "How are you?", "Goodbye!" },  // Inglés
    { "¡Hola!", "¿Cómo estás?", "¡Adiós!" },  // Español
    { "Bonjour!", "Comment ça va?", "Au revoir!" }  // Francés
                                                };

        public void EligeIdioma(int idioma)
        {
            this.IdiomaPersona = idioma;
        }

        // Ver idiomas disponibles
        public static void VerIdiomas()
        {
            System.Console.WriteLine("Elige un idioma: (0) Inglés, (1) Español, (2) Francés");
        }

        // Método para saludar
        public string Saludar()
        {
            return this.Dialogo[(int)this.IdiomaPersona, 0];
        }

        // Método para preguntar
        public string Preguntar()
        {
            return this.Dialogo[(int)this.IdiomaPersona, 1];
        }

        // Método para despedirse
        public string Despedirse()
        {
            return this.Dialogo[(int)this.IdiomaPersona, 2];
        }

    }
}