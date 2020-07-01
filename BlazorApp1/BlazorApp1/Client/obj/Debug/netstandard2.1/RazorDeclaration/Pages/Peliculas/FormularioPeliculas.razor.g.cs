#pragma checksum "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de44a9f6036ed5b31233292e9344fe1a1f7bc8ec"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Client.Pages.Peliculas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    public partial class FormularioPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Peliculas\FormularioPeliculas.razor"
       
    [Parameter] public Pelicula Pelicula { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genero> GenerosSeleccionados { get; set; } = new List<Genero>();
    [Parameter] public List<Genero> GenerosNoSeleccionados { get; set; } = new List<Genero>();
    [Parameter] public List<Persona> ActoresSeleccionados { get; set; } = new List<Persona>();

    private List<SelectorMultipleModel> Seleccionados { get; set; } = new List<SelectorMultipleModel>();
    private List<SelectorMultipleModel> NoSeleccionados { get; set; } = new List<SelectorMultipleModel>();
    private string posterTemporal;

    protected override void OnInitialized()
    {
        Seleccionados = GenerosSeleccionados.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Nombre)).ToList();
        NoSeleccionados = GenerosNoSeleccionados.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Nombre)).ToList();
        if (!string.IsNullOrWhiteSpace(Pelicula.Poster))
        {
            posterTemporal = Pelicula.Poster;
            Pelicula.Poster = null;
        }
    }

    private void ImagenSeleccionada(string imagenBase64)
    {
        Pelicula.Poster = imagenBase64;
    }

    private async Task<IEnumerable<Persona>> BuscarActores(string searchText)
    {
        var responseHttp = await repositorio.Get<List<Persona>>($"api/personas/buscar/{searchText}");
        return responseHttp.Response;
    }

    private async Task OnDataAnnonationsValidated()
    {
        Pelicula.GenerosPelicula = Seleccionados
            .Select(x => new GeneroPelicula { GeneroId = int.Parse(x.Llave) }).ToList();

        Pelicula.PeliculasActor = ActoresSeleccionados
            .Select(x => new PeliculaActor { PersonaId = x.Id, Personaje = x.Personaje }).ToList();

        if (!string.IsNullOrWhiteSpace(Pelicula.Poster)) { posterTemporal = null; }

        await OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591