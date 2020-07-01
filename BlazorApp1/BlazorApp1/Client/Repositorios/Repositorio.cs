using BlazorApp1.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        //inyectamos el HttpClient
        private readonly HttpClient httpClient;

        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        //crearemos un metodo asincrono 
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);

            if(responseHTTP.IsSuccessStatusCode)//si la respuesta es existosa QUEREMOS DISREALIZAR LA RPTA
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP); 
            }
        }


        //Esto envia un mensaje hacia el webAPI, y el que recibe el mensaje es el CONTROLADOR
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            //ahora vamos a hacer la peticion
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<Object>(null, !responseHttp.IsSuccessStatusCode, responseHttp); 
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            //ahora vamos a hacer la peticion
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<Object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }


        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            //ahora vamos a hacer la peticion
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if(responseHttp.IsSuccessStatusCode)
            {
                //si cumple la condicion entonces queremos deherelarizar la respuesta
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions); 
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return    new List<Pelicula>()
             {
            new Pelicula() { Titulo="Spider-Man", 
                             Lanzamiento= new DateTime(2019,7,2),
                             Poster="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSUwilLyU4GtFBLzXkfM7f_KRep_7qXK9e30Zlix6JlO6DOoI82"},
            new Pelicula() { Titulo = "Moana", 
                             Lanzamiento = new DateTime(2016, 11, 23),
                             Poster="https://vignette.wikia.nocookie.net/disney/images/7/76/Moana_official_poster.jpg/revision/latest?cb=20160921035605&path-prefix=es"},
            new Pelicula() { Titulo = "Inception", 
                             Lanzamiento = new DateTime(2010, 7, 16),
                             Poster="https://vignette.wikia.nocookie.net/cineytv/images/7/7f/Inception_ver3.jpg/revision/latest/scale-to-width-down/340?cb=20110515222959&path-prefix=es"}
            };
        }
    }
}
