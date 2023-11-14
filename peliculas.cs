//clase :V
class Peliculas
{
  //atributos
  private string _terror;
  private string _comedia;
  private string _drama;
  private string _fantasia;

//constructor
 
public Peliculas(string terror, string comedia, string drama, string fantasia)
{
  this._terror = "anabelle";
  this._comedia = "¿y dónde está el fantasma?";
  this._drama = "atrapame si puedes";
  this._fantasia = "el origen";

}

public string terror
{
  get { return _terror;}
  set {terror = value;}
}
public string comedia
{
  get { return _comedia;}
  set {comedia = value;}
}
public string drama
{
  get { return _drama;}
  set {drama = value;}
}
public string fantasia
{
  get { return _fantasia;}
  set {fantasia = value;}
}

public void nombrePeliculas()
{
    Console.WriteLine($"la pelicula de terror es: {terror}");
    Console.WriteLine($"la pelicula de comedia es {comedia}");
    Console.WriteLine($"la pelicula de drama es: {drama}");
    Console.WriteLine($"la pelicula de fantasia es: {fantasia}");
}
  
}