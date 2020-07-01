using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.DTOs
{
    public class Paginacion
    {
        //esta clase la utilizaremos como tipo de entrada de nuestra accion GET en el personasController
        public int Pagina { get; set; } = 1;
        public int CantidadRegistros { get; set; } = 10;

    }
}
