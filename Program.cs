using System;
using System.Runtime.InteropServices;

class Program{

  public static void Main(string[] args){
  
  /*crear una clase de tipo pélicula que tenga 4 atributos, cada atributo debe tener un método get y un método set, se deberá poner un valor por defecto para cada atributo en el constructor, (sin pedirse lo al usuario/desarrollador).

  
  pdata: La clase debe estar en otro archivo.cs.
  */ 
    
  Peliculas Movies = new Peliculas("el conjuro", "scary movie", "titanic", "avatar");
  
  Console.WriteLine(Movies.drama);
  
  


  


  }
}

