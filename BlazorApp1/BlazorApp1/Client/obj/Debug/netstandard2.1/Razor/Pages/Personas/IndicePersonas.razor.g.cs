#pragma checksum "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e15364091709eb0d943d2e52456fa8701a732c8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Pages.Personas
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
#nullable restore
#line 5 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas")]
    public partial class IndicePersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>IndicePersonas</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-info\" href=\"personas/crear/\">Crear Persona</a>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<BlazorApp1.Client.Shared.Paginacion>(2);
            __builder.AddAttribute(3, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                          paginaActual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 13 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                                                            paginaSeleccionada

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                            paginasTotales

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __Blazor.BlazorApp1.Client.Pages.Personas.IndicePersonas.TypeInference.CreateListadoGenerico_0(__builder, 7, 8, 
#nullable restore
#line 17 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                          Personas

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "table");
                __builder2.AddAttribute(12, "class", "table table-striped");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Nombre </th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(15, "tbody");
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 27 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                 foreach (var item in Personas)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                    ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "td");
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "href", "personas/editar/" + (
#nullable restore
#line 31 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "class", "btn btn-success");
                __builder2.AddContent(25, "Editar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                                                ()=> BorrarPersona(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "class", "btn btn-danger");
                __builder2.AddContent(30, "Borrar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "td");
                __builder2.AddContent(34, 
#nullable restore
#line 34 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                             item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n");
#nullable restore
#line 36 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(37, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Pages\Personas\IndicePersonas.razor"
       
    public List<Persona> Personas { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;

    protected async override Task OnInitializedAsync()
    {
        await Cargar();
    }

    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await Cargar(pagina);
    }

    private async Task Cargar(int pagina = 1)
    {
        var responseHttp = await repositorio.Get<List<Persona>>($"api/personas?pagina={pagina}");
        if (!responseHttp.Error)
        {
            Personas = responseHttp.Response;
            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();
            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());
        }

    }

    private async Task BorrarPersona(Persona persona)
    {
        var responseHttp = await repositorio.Delete($"api/personas/{persona.Id}");
        if (responseHttp.Error)
        {
            await mostrarMensajes.MostrarMensajeError(await responseHttp.GetBody());
        }
        else
        {
            await Cargar();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
namespace __Blazor.BlazorApp1.Client.Pages.Personas.IndicePersonas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorApp1.Client.Shared.ListadoGenerico<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistrosCompleto", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
