using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="El campo {0} es requerido")]
        public string Nombre { get; set; }
        //Para crear la relacion entre generoPeliculas y genero se puede realizar con List o coleccion
        public List<GeneroPelicula> GeneroPeliculas { get; set; }
    }
}
