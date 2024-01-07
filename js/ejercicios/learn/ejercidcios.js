//crear una función que cuente cuantos caracteres hay en una cadena de texto

 
// alert("este programa dirá cuantos caracteres escribió.\n");

//     let cadena = prompt("ingrese un texto");
   
// let cantidadCadena = (cadena) =>  alert("la cantidad de caracteres que ingresaste son: " + cadena.length);

// cantidadCadena(cadena);


//crea una función que devuelva un texto recordado según el número de caracteres indicados.

// let texto = prompt("escribe untexto");

// let recortar = (texto) => alert(texto.slice(0, 3));

// recortar(texto);


//crear una función que resiba un texto y devuelva un array de texto separados por caracter:

// let texto = prompt("escribe un texto");

// function almacenArray(texto){    

//     alert(texto.split(" "));
// }

// almacenArray(texto);


//crea una función que reciba un texto y devuelva el mismo texto la cantidad de veces indicada por el usuario


// let texto = prompt("ingresa el texto");

// let cantidad = prompt("ingresa la cantidad de veces que se repetirá el texto");

// function repetir(texto,cantidad){
 
//     for(let i = 0; i < cantidad;i++ ){

//         alert(texto,i);
//     }
    
   
// }

// repetir(texto,cantidad);

// let text = prompt("escribe algo");

// let invertir = (caracter) =>alert(caracter.split(" ").reverse().join());

// invertir(text);

// function imp(numero){

//     if(numero % 2 === 0){
//         alert("es par");
//     }else{
//         alert("es impar");
//     }
// }

// let texto = prompt("escribe un número");
// imp(texto);


//crea una función con callback que sume  dos números y luego muestre un mensaje de realizado

// let a = prompt("escribe un número");
// let b = prompt("escribe un segundo número");

// suma(a,b,callback());


// function callback(){
// alert(`¡La suma de ${a} + ${b} hacido realizada correctamente!.`)
// }
// async function suma(a,b,callback){

//     let resultado = 0;
//     resultado = parseInt(a) + parseInt(b);
//      alert(`el resultado es: ${resultado}`);
//      setTimeout(() => {
        
//       callback();
//     }, 5000)
// };




// function* iterable(){

// yield alert("Hola");
// alert("hola consola");
// yield "Hola2";
// alert("Seguimos con más instrucciones de nuestro código");
// yield alert("Hola3");
// yield alert("Hola4");
// }

// iterable().next();

// let iterador = iterable();

// console.log(iterador.next());
// console.log(iterador.next());
// console.log(iterador.next());

/* API PARA VOZ EN LA WEB CON UN MENSAJE 
// let mensaje = "hola soy un desarrollador de softwaer avanzado y experimentado.";


// const hablar = (mensaje)=> speechSynthesis.speak(new SpeechSynthesisUtterance(mensaje));

// hablar(mensaje);

*/

const $parrafo = document.getElementById("o"),
$todo =  document.getElementById("todo");

$parrafo.innerText = "hola mundo";
$todo.innerText = "soy todo al mismo tiempo";
$todo.style.color ="red";
console.log($parrafo);

const $imagen = document.createElement("img");

const $division = document.getElementById("contend");

$division.setAttribute("class", "que");


 $division.addEventListener("click",function(e){

     $division.style.backgroundColor = "blue";
     setTimeout(() => {
         $division.style.backgroundColor ="red";
        },1000);
        alert("¡me he ejecutado correctamente!");
        e.preventDefault();
        
 });

 const $ul = document.createElement("ul"),
 $par = document.createElement("p");

 document.body.appendChild($ul);
 document.body.appendChild($par);

 $par.textContent = "soy un parrafo creado desde javaScript puro.";

//  document.body.removeChild($par);
document.body.appendChild($par.cloneNode(true));
document.body.stopP










