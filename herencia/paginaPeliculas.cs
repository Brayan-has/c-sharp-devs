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
        this._nombrePelicula = nombrePelicula;
        this._fechaEstreno = fechaEstreno;
        this.__reseña = reseña;
        this._puntuaciones = puntuaciones;
    }

    public string nombrePelicula
    {   get { return _nombrePelicula;}
        set {this._nombrePelicula = value;} 
    }
    public string fechaEstreno
    {
        get {return _fechaEstreno;}
        set {this._fechaEstreno = value;}
    }
    public string reseña
    {
        get {return __reseña;}
        set {this.__reseña = value;}
    }
    public decimal puntuaciones
    {
        get {return _puntuaciones;}
        set {this._puntuaciones = value;}
    }

    public void peliculaPirata()
    {
        Console.WriteLine($"nombre de la pelicula: {nombrePelicula}");
        Console.WriteLine($"fecha de estreno: {fechaEstreno}");
        Console.WriteLine($"reseña: {reseña}");
        Console.WriteLine($"puntuacion {puntuaciones}");
    }

}