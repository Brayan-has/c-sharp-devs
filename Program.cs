using System;
using System.Runtime.InteropServices;

class Program
{

  /*
  
  crear un método get y un método set de un animal con una clase anónima
  
  */

  public static void Main(string[] args)
  {
    PaginaPirata pirate = new PaginaPirata("Soul", "11 de octubre de 2020", "Un profesor de música que ha perdido la pasión se transporta fuera de su cuerpo al 'Gran Antes' y debe encontrar el camino de regreso con la ayuda de un alma infantil que aprende sobre sí misma.", 7.3m);

    pirate.peliculaPirata();

  }
}

