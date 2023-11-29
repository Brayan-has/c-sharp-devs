class Ordenador
{
    //Caracteristicas
  private string _encendido;  
  private int _tamañoDisco;
  private int _discoMaximo;
  

  //Constructor

    public Ordenador(string encendido, int tamañoDisco, int discoMaximo)
    {
        this._encendido = "encender";
        this._tamañoDisco = tamañoDisco;
        this._discoMaximo = discoMaximo;
    }

    //get-set

    public int tamañoDisco
    {
        get {return this._tamañoDisco;}
        set {this._tamañoDisco = value;}
    }

    public int discoMaximo
    {
        get {return this._discoMaximo;}
        set {this.discoMaximo = value;}
    }
    public string encendido
    {
        get {return this._encendido;}
        set {this._encendido = value;}
    }

    //metodo de encendido

    public void encender()
    {
        if(encendido == "")
        {
            Console.WriteLine("el pc está apagado");
        }
        else if(encendido == "encender")
        {
            Console.WriteLine("el pc está encendido");
        }
    }
   
    //metodo de agregar datos

    public void datos()
    {
        tamañoDisco -=1;
        discoMaximo -=1;

        do
        {
            Console.WriteLine(tamañoDisco);
        } while (tamañoDisco == tamañoDisco); // no tiene sentido

        do
        {
            Console.WriteLine(discoMaximo);
        } while ()
    }
}
