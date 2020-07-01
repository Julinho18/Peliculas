using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
        //Luego se crea una clase la cual va a implementar esta interfaz
        Task MostrarMensajeExitoso(string mensaje);
    }
}
