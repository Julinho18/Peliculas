using BlazorApp1.Client.Shared;
using BlazorApp1.Shared.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server
{
    public class ApplicationDbContext: IdentityDbContext
    {
        //crearemos un contructor
        //Al cual le vamos a pasar un DbContextOptions
        //Y como parametro de tipo le vamos a pasar ApplicationDbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) //y todo eso le vamos a pasar a la clase base options
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //aquí colocaremos nuestra configuracion de llave compuesta 
            //Dentro del {} estamos diciendo que la llave primaria esta conformada por ambos campos
            modelBuilder.Entity<GeneroPelicula>().HasKey(x => new { x.GeneroId, x.PeliculaId });
            //Dentro del {} estamos diciendo que la llave primaria esta conformada por ambos campos
            modelBuilder.Entity<PeliculaActor>().HasKey(x => new { x.PeliculaId, x.PersonaId });
            // para colocar el Id= .... vas a la pagina Online GUID Generator y le das en el boton generator some guid
            var roleAdmin = new IdentityRole()
            { Id = "37a98291-cb58-4325-99f5-79a15943c538", Name = "admin", NormalizedName = "admin" };
            modelBuilder.Entity<IdentityRole>().HasData(roleAdmin); 
            
            base.OnModelCreating(modelBuilder);           

        }
        //Apartir de los DbSet yo digo a partir de que modelos yo quiero crear mi base de datos
        public DbSet<GeneroPelicula> GenerosPeliculas { get; set; } //El nombre de la tabla será GenerosPeliculas
        public DbSet<Pelicula> Peliculas { get; set; }//El nombre de la tabla será Peliculas
        public DbSet<Genero> Generos { get; set; }//El nombre de la tabla será Generos
        public DbSet<Persona> Personas { get; set; }//El nombre de la tabla será Personas
        public DbSet<PeliculaActor> PeliculasActores { get; set; } //El nombre de la tabla será PeliculaActor
        public DbSet<VotoPelicula> VotosPeliculas { get; set; }



    }
}
