using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Helpers
{
    public interface IAlmacenadorDeArchivos
    {
        Task<string> EditarArchivo(byte[] contenido, string extension, string nombreContenedor, string rutaArchivoActual);
        Task EliminarArchivo(string ruta, string nombreContenedor);
        Task<string> GuardarArchivo(byte[] contenido, string extension, string nombreContenedor);
        //Luego una clase puede implementar esta interfaz
    }
}
