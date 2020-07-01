using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    public class Persona
    {
        public int Id {get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public string Foto { get; set; }
        [Required] 
        public DateTime FechaNacimiento { get; set; }

        public List<PeliculaActor> PeliculasActor { get; set; }

        [NotMapped]
        public string Personaje { get; set; }

        //determina cuando una persona es igual a otra
        public override bool Equals(object obj)
        {
            if (obj is Persona p2)
            { 
                //cuando comparten el mismo ID
                return Id == p2.Id;
            }
            //de lo contrario no son la misma persona
            return false;
        }

        //Se recomenda usar el Gethascode cuando se usa el Equals
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
