//clase :V
class Peliculas
{
  //atributos 
  private string _terror;
  private string _comedia;
  private string _drama;
  private string _fantasia;

//constructor
 
public Peliculas()
{
  this._terror = "anabelle";
  this._comedia = "¿y dónde está el fantasma?";
  this._drama = "atrapame si puedes";
  this._fantasia = "el origen";

}

public string terror
{
  get { return _terror;}
  set {this._terror = value;}
}
public string comedia
{
  get { return _comedia;}
  set {this._comedia = value;}
}
public string drama
{
  get { return _drama;}
  set {this._drama = value;}
}
public string fantasia
{
  get { return _fantasia;}
  set {this._fantasia = value;}
}

public void nombrePeliculas()
{
    Console.WriteLine($"la pelicula de terror es: {terror}");
    Console.WriteLine($"la pelicula de comedia es {comedia}");
    Console.WriteLine($"la pelicula de drama es: {drama}");
    Console.WriteLine($"la pelicula de fantasia es: {fantasia}");
}
  
}

/*

 var animal = new {nombre ="Perro", color="Negro"};

// \n new line (alt gr esta al lado de la tecla space + ? que esta al lado de la tecla del número cero )
// \t tab
Console.WriteLine("hola\tmundo");
// esto se llama 
//  Console.WriteLine(animal.color);


ejercicio Duvian:

  var animal = new {nombre = "León", habitat = "Sabana Africana", continente = "Africa"};

  Console.WriteLine(animal.nombre);
  Console.WriteLine(animal.habitat);
  Console.WriteLine(animal.continente);
*/