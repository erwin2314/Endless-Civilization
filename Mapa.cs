class Mapa
{
    public int tamano_x;
    public int tamano_y;
    public Casilla[,] casillas_mapa;
    public Mapa (Casilla[,] casillas_mapa)
    {
        this.casillas_mapa = casillas_mapa;
        this.tamano_x = casillas_mapa.GetLength(0);
        this.tamano_y = casillas_mapa.GetLength(1);
    }

    public void DibujarMapa()
    {
        for (int y = 0; y < tamano_y; y++)
        {
            for (int x = 0; x < tamano_x; x++)
            {
                Console.Write(casillas_mapa[x, y].imagen);
            }
            Console.WriteLine();
        }
    }

    public bool MovimientoValido(int x, int y)
    {
        if (x < 0 || x >= tamano_x || y < 0 || y >= tamano_y)
        {
            return false;
        }
        else 
        {
            foreach (Entidad entidad in casillas_mapa[x, y].entidades)
            {
                if (entidad.es_solido)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public void MoverEntidad(Entidad entidad, int desplazamiento_x, int desplazamiento_y)
    {
        if (MovimientoValido(entidad.posicion_x + desplazamiento_x, entidad.posicion_y + desplazamiento_y))
        {
            casillas_mapa[entidad.posicion_x, entidad.posicion_y].entidades.Remove(entidad);
            casillas_mapa[entidad.posicion_x + desplazamiento_x, entidad.posicion_y + desplazamiento_y].entidades.Add(entidad);
        }
        
    }
    public int DistanciaManhattan(int posicion_x_inicial, int posicion_y_inicial, int posicion_x_final, int posicion_y_final)
    {
        return Math.Abs(posicion_x_final - posicion_x_inicial) + Math.Abs(posicion_y_final - posicion_y_inicial);
    }
}