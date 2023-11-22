/* crear una clase para sumar dos números
 y crear una classe claculadora básica que solo pueda multiplicar, pero esta debe heredar de la clase sumar para que la calculadora pueda sumar también.*/

class Suma
{
    //atributos
    private int _numeroUno;
    private int _numeroDos;
    
    

    //constructor

    public Suma(int numeroUno, int numeroDos)
    {
        this._numeroUno = numeroUno;
        this._numeroDos = numeroDos;
        
    }
    
    

    //Metodos GEt y SET

    public int numeroUno
    {
        get {return this._numeroUno;}
        set {this._numeroUno = value;}
    }

    public int numeroDos
    {
        get {return this._numeroDos;}
        set {this._numeroDos = value;}
    }


    // método
    public void resultado()
    {
        Console.WriteLine(this._numeroUno + this._numeroDos);
    }
}

// //Clase Heredada

class CalculadoraBasica : Suma
{
    //atributo
    private int _primerNumero;
    private int _segundoNumero;

    //Constructor

    public CalculadoraBasica(int primerNumero, int segundoNumero) : base(primerNumero, segundoNumero)
    {
        this._primerNumero = primerNumero;
        this._segundoNumero = segundoNumero;
    }   
    
    //Get y SET

    public int primerNumero
    {
        get {return this._primerNumero;}
        set {this._primerNumero = value;}
    }

    public int segundoNumero
    {
        get {return _segundoNumero;}
        set {this._segundoNumero = value;}
    }

    //metodo

    public void multiplicar()
    {
        Console.WriteLine(this._primerNumero * this._segundoNumero);
    }


}




