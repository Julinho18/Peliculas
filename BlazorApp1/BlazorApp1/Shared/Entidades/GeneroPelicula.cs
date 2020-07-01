using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    public class GeneroPelicula
    {
        public int PeliculaId { get; set; }
        public int GeneroId { get; set; }
        //Con estas 2 propiedades siguientes : se nos hace más fácil ir a los datos que hay en pelicula y genero
        public Pelicula Pelicula { get; set; } 
        public Genero Genero { get; set; }
    }
}
