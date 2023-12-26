using System;

class Progam
{

  public static void Main(string[] args)
  {

    //intancia del objeto ordenador 
    Ordenador pcGamer = new Ordenador();

    int elegir = 0;
    int info = 3;
    int pc = 1;
    // 
    try
    {
      Console.WriteLine("Presiona el botón 1 para ver información de la computadora");
      pc = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
      Console.WriteLine("No puedes ingresar letras ni caracteres");
    }

    if (pc != 1)
    {

      pcGamer.apagar(1);
    }

    pcGamer.Encendido(pc);
    while (pc == 1)
    {


      switch (elegir)
      {

        case 0:
          Console.WriteLine("elige una opción para poder hacer uso del Ordenador");
          Console.WriteLine("1: información de la pc.\n2: apagar ordenador");
          Console.WriteLine("3: para modificar los datos del disco\n4: para eliminar todos los datos del disco");

          try
          {
            elegir = int.Parse(Console.ReadLine());
          }
          catch (Exception)
          {
            Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
          }
          break;

        case 1:
          try
          {

            Console.WriteLine("Presiona 0 para ver información del equipo");
            info = int.Parse(Console.ReadLine());
          }
          catch (Exception)
          {
            Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
          }

          if (info == 0)
          {
            Console.WriteLine($"Información principal:\n disco duro: {pcGamer.tamañoDisco}\n tamaño total del disco: {pcGamer.tamañoMaximoDisco}\n encendido: {pcGamer.encendido}");
          }

          try
          {
            Console.WriteLine("\nPresiona 0 para volver al menu\n Presiona 1 para volver a ver la información del ordenador\n Presiona 2 para pagar la pc\n3 para modificar los datos del oordenador");
            elegir = int.Parse(Console.ReadLine());

          }
          catch (Exception)
          {
            Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
          }

          break;

        case 2:

          try
          {
            Console.WriteLine("¿Desea continuar? Presiona 1\nde lo contrario presione 0");
            pc = int.Parse(Console.ReadLine());
            pcGamer.apagar(pc);
            if (pc == 1)
            {
              Console.WriteLine("\nelige otra opción del menú");
              elegir = int.Parse(Console.ReadLine());
            }
          }
          catch (Exception)
          {
            Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
          }

          break;


        case 3:
          Console.WriteLine("ingresa el valor real del disco en números enteros");
          Console.WriteLine("añade primero el tamaño del disco, segundo el tamaño máximo del disco en decimales.");

          try
          {
            int disco = int.Parse(Console.ReadLine());
            float total = float.Parse(Console.ReadLine());
            pcGamer.aniadirDatos(disco, total);

            Console.WriteLine("\nelige otra opción del menú");
            elegir = int.Parse(Console.ReadLine());
          }
          catch (Exception)
          {
            Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
          }

          break;

        case 4:
          string siNo = "";
          try
          {
            Console.WriteLine("elimina los datos del disco\n para eliminar los datos presiona el numero 3");
            int eliminar = int.Parse(Console.ReadLine());
            if (eliminar == 3)
            {
              Console.WriteLine("¿Estás seguro?\nEscribe con si o no");
              siNo = Console.ReadLine();
            }
            else
            {
              Console.WriteLine("\nNo fue posible eliminar los datos");
              Console.WriteLine("\nelige otra opción del menú");
              elegir = int.Parse(Console.ReadLine());
            }

            if (siNo == "si" || siNo == "Si" || siNo == "SI")
            {
              Console.Beep();
              pcGamer.eliminarDatos();
              try
              {
                Console.WriteLine("\nelige otra opción del menú");
                elegir = int.Parse(Console.ReadLine());
              }
              catch (Exception)
              {
                Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
              }
            }
            else if (siNo == "no" || siNo == "No" || siNo == "NO")
            {

              Console.WriteLine("Cancelado...");
              try
              {
                Console.WriteLine("\nelige otra opción del menú");
                elegir = int.Parse(Console.ReadLine());
              }
              catch (Exception)
              {
                Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
              }


            }
          }
          catch (Exception)
          {

            Console.WriteLine("\nNo puedes ingresar letras ni caracteres, debes ingresar números\n");
          }

          break;

      }


    }



    //
  }

}









