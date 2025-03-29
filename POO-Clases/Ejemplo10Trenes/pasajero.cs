 namespace pasajeros;

class Pasajero{ //SIEMPRE EN CMAELCASE

    private string _nombre;

    public Pasajero(string nombre){
        _nombre = nombre;
    }

    public string GetNombre(){
        return _nombre;
    }

    public override string ToString(){
        return $"Nombre del pasajero: {_nombre}";
    }

    public override bool Equals(object obj)
    {

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        Pasajero p = (Pasajero)obj;

        return _nombre == p._nombre;

    }
    

}