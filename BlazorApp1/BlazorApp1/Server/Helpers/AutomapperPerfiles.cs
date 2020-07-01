using AutoMapper;
using BlazorApp1.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Helpers
{
    public class AutomapperPerfiles: Profile
    {
        //atraves de esto podremos definir las reglas de mapeo entre diferentes tipos de datos 
        public AutomapperPerfiles()
        {
            CreateMap<Persona, Persona>()
                .ForMember(x => x.Foto, option => option.Ignore());
            CreateMap<Pelicula, Pelicula>()  
                .ForMember(x => x.Poster , option => option.Ignore());
        }
    }
}
