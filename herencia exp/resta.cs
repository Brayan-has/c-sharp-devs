class Resta
{

    private int _numberTwo;
    private int _numberOne;

    public Resta(int numberOne, int numberTwo)
    {

        this._numberOne = numberOne;
        this._numberTwo = numberTwo;
    }

    public int numberOne
    {
        get { return this._numberOne; }
        set { this._numberOne = value; }

    }

    public int numberTwo
    {
        get { return this._numberTwo; }
        set { this._numberTwo = value; }
    }


    public void minus()
    {

       Console.WriteLine(numberOne - numberTwo);

    }

}
