interface Icorrer
{
    void correr();
}
class Caminar
{

    // atrubutos de clase
    private int _pasosPorM;
    private int _distancia; //en metros
    // métodos get y set (getter y setter)

    public int pasosPorM
    {
        get { return this._pasosPorM; }
        set { this._pasosPorM = value; }
    }

    public int distancia
    {
        get { return this._distancia; }
        set { this._distancia = value; }
    }

    // métodos de clase

    
    public virtual void caminar()
    {

        Console.WriteLine($"Cuantos pasos fueron? {pasosPorM}\n Que distancia recorrió? {distancia} en metro cuadrado.");
    }

}