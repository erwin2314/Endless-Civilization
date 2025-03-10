class Casilla
{
    public char imagen;
    public List<Entidad> entidades;
    public Casilla (char imagen, List<Entidad> entidades = null)
    {
        this.imagen = imagen;
        if (entidades == null)
        {
            this.entidades = new List<Entidad>();
        }
        else
        {
            this.entidades = entidades;
        }
    }
}