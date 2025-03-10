class Imperio
{
    public string nombre;
    public int dinero_actual;
    public List<Recurso>? recursos;
    public Imperio
    (
        string nombre,
        int dinero_actual,
        List<Recurso>? recursos = null
    )
    {
        this.nombre = nombre;
        this.dinero_actual = dinero_actual;
        if (recursos == null)
        {
            recursos = new List<Recurso>();
            /*
            
            */
        }
        else
        {
            this.recursos = recursos;
        }
    }
}