class Ordenador
{
    // atributos/ 3
    //tamaño discotamaño máximo disco encendido
    private int _tamañoDisco;
    private float _tamañoMaximoDisco;
    private bool _encendido;

    // constructor

    public Ordenador()
    {
        this._tamañoDisco = 0;
        this._tamañoMaximoDisco = 0.0f;
        this._encendido = false;
    }

    // Métodos get y set

    public int tamañoDisco
    {

        get { return this._tamañoDisco; }
        set { this._tamañoDisco = value; }
    }
    public float tamañoMaximoDisco
    {
        get { return this._tamañoMaximoDisco; }
        set { this._tamañoMaximoDisco = value; }
    }
    public bool encendido
    {
        get { return this._encendido; }
        set { this._encendido = value; }
    }
    // Métodos 
    // anoiadir datos
    public void aniadirDatos(int tamañoDisco, float tamañoMaximo)
    {


        // 
        this.tamañoDisco = tamañoDisco;
        // 
        this.tamañoMaximoDisco = tamañoMaximo;


        //    Console.WriteLine($"Datos ecenciales de la computadora:\n tamaño del disco: {this.tamañoDisco}\n tamaño total del disco: {this.tamañoMaximoDisco}\n Info extra del ordenador: {info}");
    }
    // eliminarDatos()
    public void eliminarDatos()
    {

        this.tamañoDisco = 0;
        this.tamañoMaximoDisco = 0.0f;

        Console.WriteLine("\n¡los datos de la computadora han sido borrados correctamente!\n");

    }
    // encender()

    public void Encendido(int encender)
    {

        if (encender == 1)
        {
            this.encendido = true;
        }

        if (this.encendido == true)
        {

            Console.WriteLine("¡¡El ordenador ha encendido correctamente!!\n");
        }
    }
    // apagar()

    public void apagar(int apagar)
    {

        if (apagar == 0)
        {
            Console.WriteLine("Apagando el equipo...");
        }
        else
        {
            Console.WriteLine("\nEl equipo aun está encendido\n");
            
        }
    }
    // -"ordenador"


}