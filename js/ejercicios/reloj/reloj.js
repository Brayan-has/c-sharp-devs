

const d = document;
// function reloj(em,te){
    
   
// }

const $boton = document.querySelector("#star"),
$boton2  = document.querySelector(".End");

let tiempValor;

$boton.addEventListener("click",(e) =>{

    //hacemos uso de la delegación de evento
    // para valida si se presionó alguno de los dos
    // botones
    if(e.target.matches("#star")){
         tiempValor = setInterval(() =>{
            let tiempo = new Date().toLocaleTimeString();
            d.querySelector(".reloj").innerHTML = `${tiempo}`;
            
        },1000)
        e.target.disabled = true;
    }

   
   
    $boton2.addEventListener("click",(e) =>{
    
         if(e.target.matches(".End")){
            // alert()
            clearInterval(tiempValor);
            d.querySelector(".reloj").innerHTML = null;
            d.querySelector("#star").disabled = false;
        }
    })
})



//apartir de aquí trabajaremos la alarma

const $iniciarA = document.querySelector(".Ial"),
$detenerA = document.querySelector(".Dal");

let alarmaT;

$iniciarA.addEventListener("click",(e) =>{

 
    const $audio = d.createElement("audio"),
    direc = "../reloj/alarm-clock.mp3";
       $audio.src = direc; 

     if(e.target.matches(".Ial")){
        alarmaT = setTimeout(()=>{
            $audio.play();
        },2000)
        e.target.disabled = true;
    }
    $detenerA.addEventListener("click",(e) =>{

        
        if(e.target.matches(".Dal")){
            //para detener la alrma o el audio hay que usar:
            //paused y currentTime para volver el audio desde 0 
            $audio.pause();
            clearTimeout(".Ial");
            $audio.currentTime = 0;
            
            $iniciarA.disabled = false;
        }
        
    })
        
})