namespace botellas;
class BotellaLitro
{
    protected float _contenido;

    public float Contenido
    {
        get => _contenido;

    }

    protected bool _abierto;

    public bool Abierto
    {
        get => _abierto;
    }

    public BotellaLitro()
    {
        _contenido = 0f;
        _abierto = false;
    }


    public BotellaLitro(float liquido) : this()
    { //primero llama al anterior, siempre se inicia cerrada
        if (liquido >= 0f && liquido <= 1f)      //que el contenido nunca sea negativo ni exceda 1L
        {
            _contenido = liquido;
        }
        else if (liquido > 1f)
        {
            _contenido = 1f; // se queda vacio
        }
        else { _contenido = 0f; }
    }

    // Asegurarse de que todas las operaciones tengan en cuenta si la botella está abierta o cerrada
    //Que no se pueda añadir o quitar si la botella esta cerrada


    public void Abrir()
    {
        if (!Abierto)
        { _abierto = true; }
    }

    public void Cerrar()
    {
        if (Abierto)
        { _abierto = false; }
    }

    public bool EstaLlena()
    {
        //true si esta llena x contenido == 1
        return _contenido == 1f;
    }

    public bool EstaVacia()
    {
        //true si esta vacia x contenido == 0
        return _contenido == 0f;
    }

    public float Anadir(float liquido)  //que el contenido nunca sea negativo ni exceda 1L
    {
        //no se puede añadir ni quitar si esta cerrada
        //añade liquido y devuelve cantidad sobrante si excede cantidad
        //lo de añadir se verifica aca no se hace en el set
        float sobrante = 0f;

        if (Abierto)
        {

            if (_contenido + liquido < 1f)
            {
                _contenido += liquido;
            }
            else if (_contenido + liquido >= 1f)
            {
                sobrante = (_contenido + liquido) - 1f;
                _contenido = 1f; //asigno el maximo
            }

        }
        else
        { System.Console.WriteLine("La botella esta cerrada"); }

        return sobrante; //retorna 0 si no sobra
    }

    public float Quitar(float liquido)  //que el contenido nunca sea negativo ni exceda 1L
    {
        //no se puede añadir ni quitar si esta cerrada
        //quita liquido y devuelve la cantidad extraida realmente (si pide mas de lo que hay)
        //lo de añadir se verifica aca no se hace en el set
        float extraido = 0f;
        float exceso = 0f;

        if (Abierto)
        {

            if (_contenido - liquido <= 0f)
            {
                exceso = liquido - _contenido; //mas facil, liquido es mayor y si le quito el contenido queda lo q sobra
                extraido = liquido - exceso;
                _contenido = 0;
            }

            else if (_contenido - liquido > 0f)
            {
                _contenido -= liquido;
                extraido = liquido;
            }

        }

        //si esta cerrada se queda en 0 no extrae nada

        else
        {
            System.Console.WriteLine("La botella esta cerrada");
        }

        return extraido;
    }

    public override string ToString(){
        return $"Cantidad de agua en la botella: {Contenido} l";
    }

    public override bool Equals(object? obj){

        if(obj == null || GetType() != obj.GetType()){return false;}

        //se moldea
        BotellaLitro otraBotella = (BotellaLitro)obj;
        return _contenido == otraBotella._contenido;

    }

}
