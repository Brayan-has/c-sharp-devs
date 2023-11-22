class Calculator : Plus
{

    // attributes 
    private int _firstNamber;
    private int _secondNamber;
    // get and set method

    public int firstNamber
    {

        get { return this._firstNamber; }
        set { this._firstNamber = value; }
    }
    public int secondNamber
    {
        get { return this._firstNamber; }
        set { this._firstNamber = value; }
    }

    // constructor

    public Calculator(int firstNamber, int secondNameber) : base(firstNamber, secondNameber)
    {

        this._firstNamber = firstNamber;
        this._secondNamber = secondNameber;
    }

    // principal multiply method

    public void multiply()
    {

        Console.WriteLine($"the result of multiply the numbers {this._firstNamber} and {this._secondNamber} is:\n {this._firstNamber * this._secondNamber}");
    }

}