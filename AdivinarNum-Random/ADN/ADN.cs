class Adn
{

    //SE RECORREN LAS CADENAS EN SENTIDO HORARIO

    private string cadenaAdn;

    public Adn(string adn)
    {

        foreach (char caracter in adn)
        {
            if (caracter != 'A' && caracter != 'C' && caracter != 'T' && caracter != 'G')
            {
                throw new ArgumentException("La secuencia de ADN no es correcto");
            }
        }

        cadenaAdn = adn;
    }

    public string GetAdn()
    {
        return cadenaAdn;
    }

    public bool ComprobacionCircular(string otroAdn)
{
    if (otroAdn.Length != cadenaAdn.Length)
    {
        return false; // Si las longitudes son diferentes, no pueden ser equivalentes circularmente.
    }

    bool esIgual = false;
    bool diferenciaEncontrada;

    for (int i = 0; i < otroAdn.Length; i++)
    {
        if (otroAdn[i] == cadenaAdn[0]) // Posible punto de inicio
        {
            esIgual = true; // Suponemos que es igual para esta rotación
            diferenciaEncontrada = false; //para ver si encontramos una diferencia

            for (int j = 0; j < otroAdn.Length && !diferenciaEncontrada; j++)
            {
                int IndiceCircular = (i + j) % otroAdn.Length; //usando la tecnica del indice que rodea desde n a n

                if (otroAdn[IndiceCircular] != cadenaAdn[j])
                {
                    esIgual = false; // Esta rotación no es válida
                    diferenciaEncontrada = true; // Detenemos esta búsqueda interna si no es ifual en uno de los indices
                }
            }

            if (esIgual) // Si encontramos una rotación válida, terminamos la búsqueda
            {
                i = otroAdn.Length; //forzando salir del bucle externo que busca la primera coincidencia
            }
        }
    }

    return esIgual;
}

    public bool ComprobacionConcat(string otroAdn){
        string CadenaDoble = otroAdn + otroAdn;
        return CadenaDoble.Contains(cadenaAdn);
    }

    public override bool Equals(object? obj)
    {

        if (obj == null || GetType() != obj.GetType() || obj.Length != cadenaAdn.Length)
        {
            return false;
        }

        Adn otroAdn = (Adn)obj;
        return (ComprobacionCircular(otroAdn));
    }

}