function pruebaPuntoNetStatic() {
    //dentro de la comilla va el nombre del proyecto, nombre de la funcion
    DotNet.invokeMethodAsync("BlazorApp1.Client", "ObtenerCurrentCount")
        .then(resultado => {//el then es si el mentodo retorna algo
            console.log("conteo desde javascript" + resultado);
        });
}

function pruebaPuntoNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
    //como ese metodo no retorna nada NO ES NECESARIO COLOCAR .then
}