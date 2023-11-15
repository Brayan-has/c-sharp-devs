/*crear una clase en un archivo externo para un proyecto
de una página de películas piratas, esta clase debe tener
4 atributos que servirá para mostrar en un método 
lo siguiente: las reseñas, nombre de la película,
fecha de la película y la puntuación de la misma.
A su vez cada atrubuto deberá tener su método get
y su método set.*/

class PaginaPirata
{
    //atributos
    private string _nombrePelicula;
    private string _fechaEstreno;
    private string __reseña;
    private decimal _puntuaciones;

    //constructor

    public PaginaPirata(string nombrePelicula, string fechaEstreno, string reseña, decimal puntuaciones)
    {
        this._nombrePelicula = "Soul";
        this._fechaEstreno = "11 de Octubre de 2020";
        this.__reseña = "Un profesor de música que ha perdido la pasión se transporta fuera de su cuerpo al ´Gran Antes´ y debe encontrar el camino de regreso con la ayuda de un alma infantil que aprende sobre sí misma.";
        this._puntuaciones = 7.4;
    }

    public string nombrePelicula
    {   get { return _nombrePelicula;}
        set {nombrePelicula = value;} 
    }
    public string fechaEstreno
    {
        get {return _fechaEstreno;}
        set {fechaEstreno = value;}
    }
    public string reseña
    {
        get {return _reseña;}
        set {reseña = value;}
    }
    public decimal puntuaciones
    {
        get {return _puntuaciones;}
        set {puntuaciones = value;}
    }
}