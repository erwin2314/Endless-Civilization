class Entidad
{
    public int posicion_x;
    public int posicion_y;
    public char imagen;
    public string nombre;
    public string descripcion;
    public bool es_solido;
    public Mapa mapa;
    public int prioridad_imagen;
    public Entidad (

        int posicion_x,
        int posicion_y,
        char imagen = ' ',
        string nombre = "Espacio vacio",
        string descripcion = "Espacio sin nada interesante",
        bool es_solido = false,
        Mapa mapa = null,
        int prioridad_imagen = 0

        )
    {
        this.posicion_x = posicion_x;
        this.posicion_y = posicion_y;
        this.imagen = imagen;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.es_solido = es_solido;
        this.mapa = mapa;
        this.prioridad_imagen = prioridad_imagen;
    }
    public void Mover(int desplazamiento_x, int desplazamiento_y)
    {
        mapa.MoverEntidad(this, desplazamiento_x, desplazamiento_y);
    }
}