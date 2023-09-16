using System;
       
class Program
{
    public static void Main(string[] args)
    {
        Estudios respuesta = new Estudios("ingenieria mecatronica");
        Console.WriteLine(respuesta.nombreCarrera());
    }
}


class Estudios
{   //atributos
    private string _nombreCarrera;
    //cosntructor
    public Estudios (string nombreCarrera)
    {
        this._nombreCarrera = nombreCarrera;
    }

    //metodo
    public string nombreCarrera()
    {
        return this._nombreCarrera;
    }
}