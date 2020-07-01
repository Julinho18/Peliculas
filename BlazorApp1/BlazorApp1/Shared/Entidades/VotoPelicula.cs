using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    //Esta clase servirá para darle puntuación a la pelicula
    public class VotoPelicula
    {
        public int Id { get; set; }
        public int Voto { get; set; }
        public DateTime FechaVoto { get; set; }
        public int PeliculaId { get; set; }
        //Lo siguiente sive para acceder más rápdio a Peliculas
        public Pelicula Pelicula { get; set; }
        public string UserId { get; set; }//para identificar a que usuario pertenece un voto
    }
}
