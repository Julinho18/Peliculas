using BlazorApp1.Shared.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//Esta es la ruta, y la clase de abajo ereda de ControllerBase
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles ="admin")]
    public class GenerosController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        //vamos a utlizar inyeccion de dependencias para inyectar una instancia de nuestro AppDBcontext en nuestro controlador
        public GenerosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Genero>>> Get()
        {
            return await context.Generos.ToListAsync();//TOLisTasync Me trae todos los registros de la base datos
        }

        //me permite buscar por su id
        [HttpGet("{id}")]
        public async Task<ActionResult<Genero>> Get(int id )
        {
            return await context.Generos.FirstOrDefaultAsync(x => x.Id == id);
        }

        //Crearemos una accion, llamada Post
        [HttpPost]
        public async Task<ActionResult<int>> Post(Genero genero)
        {//el <int> indica que podemos retornar un entero
            //Vamos a utilizar entityFrame.Cor para crear un genero en nuestra basededatos
            context.Add(genero);//Estamos diciendo que queremos añadir un genero hacia nuestra DB
            await context.SaveChangesAsync(); //Lo de arriba no se realiza hasta que digamos SaveChangesAsync
            return genero.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Genero genero)
        {
            context.Attach(genero).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();// no regresa ningun tipo de contenido 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Generos.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Genero { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
