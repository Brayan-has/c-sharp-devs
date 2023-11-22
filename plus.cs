class Plus{
    // fist i'm ganna make the attrubutes

    private int _firstNumber;
    private int _secondNumber;

    // now i'm ganna make the constructor

    public Plus(int firstNumber, int secondNumber){

        this._firstNumber = firstNumber;

        this._secondNumber = secondNumber;
    }


    // then I'm  ganna make the get and set method

    public int firstNumber{
        get{return this._firstNumber;}
        set{this._firstNumber = value;}
    }

    public int secondNumber{

        get{return this._secondNumber;}
        set{this._secondNumber = value;}
    }

    //then i'm ganna make the principal method 


    public void  PlusNumber(){

        Console.WriteLine( $"El resultado de la suma entre {this._firstNumber} y {this._secondNumber} es\n: {this._firstNumber + this._secondNumber}");


    } 
}