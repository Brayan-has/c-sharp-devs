const $ul = document.querySelectorAll("li"),
$btnMenu = document.querySelector("button"),
$elVisible = document.getElementById("menu"),
$parra = document.querySelectorAll("p");

// $elVisible.style.display ="none";

let contador = 1;
$ul.forEach(e =>{
    e.insertAdjacentHTML("afterbegin",`<a href=''>Sección ${contador} </a>`);
    e.style.textAlign ="center";
    e.style.padding = " 100px";
    contador += 1;
    
   
    
})

contador = 0;
 const $lista = document.querySelectorAll("a");
    $lista.forEach(e =>{
        contador +=1;
        e.setAttribute("href",`#para${contador}`);
    })

contador = 0;

$parra.forEach(e =>{
    contador += 1;
    e.setAttribute("id",`para${contador}`)
})

//método para desaparecer menu

const $documento = document;
//aquí el evento escucha para el botón.
$btnMenu.addEventListener("click",(e)=>{

    $elVisible.style.display = "grid";

})

$documento.addEventListener("dblclick",e =>{

    
    if(e.target.matches("button")){
        
      $elVisible.style.display = "none";
    }
})

