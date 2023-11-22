using System;

class Progam
{

  public static void Main(string[] args){
  
  /*

  crear una clase en un archivo externo para un proyecto de una página de películas piratas, esta clase debe tener 4 atributos que servirá para mostrar en un método lo siguiente: las reseñas, nombre de la película, fecha de la película y la puntuación de la misma. A su vez cada atrubuto deberá tener su método get y su método set.

  dame un momento please

  */  
 
    


    int fist = int.Parse(Console.ReadLine());
    int second = int.Parse(Console.ReadLine());

    Calculator cal = new Calculator(fist, second);

    cal.PlusNumber();
  }
}








