using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        //esta clase nos ayudará para saber si hubo o no error en la peticion Http
        //Y tambien nos dará los datos deserealizado

        //Este es un constructor
        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public bool Error { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        //Con esto no vamos a tener que estar repitiendeo el codigo en toda la aplicación
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
