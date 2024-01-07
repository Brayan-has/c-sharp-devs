//ajax de la forma con XMLHttpRequest

(()=>{

    //INSTANCIA
    const xhr = new XMLHttpRequest();
    //caputrar y crear datos
    const $div = document.getElementById("xml"),
    $fragment = document.createDocumentFragment();

    //evento del xhr
    xhr.addEventListener("readystatechange",(e)=>{
        if(xhr.readyState !== 4) return;

        if(xhr.status >= 200 && xhr.status <300){
            let json = JSON.parse(xhr.responseText)
            json.forEach((el)=>{
                let $li = document.createElement("li");
                $li.innerHTML = ` ${el.name} ${el.email} ${el.phone}`;
                $fragment.appendChild($li);

            })

            $div.appendChild($fragment);
        }else{
            // alert("Error");
            let message = xhr.statusText;
            $div.innerHTML = `Error ${xhr.status} ${message}`;

        }
    });

    xhr.open("GET","https://jsonplaceholder.typicode.com/users");

    xhr.send();

})();


//ejemplo con axios

(()=>{
    const $axios = document.getElementById("axios"),
    $fragment = document.createDocumentFragment();
    
    axios("https://jsonplaceholder.typicode.com/users")
    .then(res=>{
        let json = res.data;
        json.forEach((el)=>{
            const $li = document.createElement("li");
            $li.innerHTML = `${el.name} ${el.email} ${el.phone}`;
            $fragment.appendChild($li);
        })

        $axios.appendChild($fragment);

    }).catch(()=>{
        let message = err.response.statusText || "Ocurrió un error";
        $axios.innerHTML = `Error ${err.response.status} ${message}`;
    }).finally(()=>{
        alert("esto se ejecutará siemrpe");
    });
})();













//ajax segunda forma con fetch y promesas (es decir .then)

(()=>{
    //creo y almaceno los elementos del dom con los que 
    //vamos a trabajar
    const $div = document.getElementById("fetch"),
    $fragment = document.createDocumentFragment();

    //intentamos consumir la "api"
    fetch("https://jsonplaceholder.typicode.com/users")
    /*
      y con la promesa validamos que la respuesta ok sea true
      y en caso de ser true entonces pasa el elemento
      o su conteniod de json a objeto javaScript
      de lo contrario rechazamos la promesa
      */
    .then((res)=>res.ok ? res.json() : Promise.reject(res))
    /*
      luego recorrerémos el contendio del archivo 
      convertido en
      objeto y almacenar su contenido en una promesa
      y esta en un elemento del dom
    */
    .then((json)=>{
        json.forEach((el)=>{
            //vamos a crear un elemento del dom
            let $li = document.createElement("li");
            $li.innerHTML = `${el.name} ${el.email} ${el.phone}`;

            //agregamos el li en el fragmento
            $fragment.appendChild($li);
        })
        //ahora almacenaremos el fragmento en el elemento 
        //nativo del dom
        $div.appendChild($fragment);
    })
    //capturamos los posibles errores o las excepciones
    .catch((err)=>{
        let message = err.statusText || `Ocurrió un error`;
        $div.innerHTML = `Error ${err.status} ${message}`;
    })
    //y por último se ejecutaría el finally
    .finally(()=>{
        // alert("¡¡Así se aprende ajax!!");
    })
})()