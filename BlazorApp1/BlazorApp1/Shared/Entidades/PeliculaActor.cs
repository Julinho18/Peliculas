using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    public class PeliculaActor
    {
        public int PersonaId { get; set; }
        public int PeliculaId { get; set; }
        //Con estas 2 propiedades siguientes : se nos hace más fácil ir a los datos que hay en pelicula y personas
        public Pelicula Pelicula { get; set; }
        public Persona Persona { get; set; }
        //Lo siguiente es el nombre del personaje que protagoniza
        public string Personaje { get; set; }
        //Me va a permitir en que orden quiero que aparescan los actores cuando visualicemos la pelicula
        public int Orden { get; set; }
    }
}
