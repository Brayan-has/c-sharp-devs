using System;

class Program{

    public static void Main(string[] args){

        // crear una clase para sumar dos números
        // y crear una classe claculadora básica que solo pueda multiplicar por si misma, pero esta debe heredar de la clase sumar para que la calculadora pueda sumar también.


        Suma result = new Suma(3,5);
        result.resultado();

        CalculadoraBasica resulta = new CalculadoraBasica(5,2);
        resulta.multiplicar();

       
        
    }

        
}




