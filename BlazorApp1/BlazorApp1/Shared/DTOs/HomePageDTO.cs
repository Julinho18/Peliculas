using BlazorApp1.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.DTOs
{
    public class HomePageDTO
    {
        public List<Pelicula> PeliculasEnCartelera { get; set; }
        public List<Pelicula> ProximosEstrenos { get; set; }

    }
}
