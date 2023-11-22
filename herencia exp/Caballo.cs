class Caballo : Mamifero {

// atributos
private string _sonido;

// constructor
// la instrucción base va escrita en la misma linea que el constructor
  public Caballo(string nombre) : base(nombre){

    this._sonido = nombre;
  }

  // método get y set 
  public string sonido{
    get{return this._sonido;}
    set{this._sonido = value;}
  }

}