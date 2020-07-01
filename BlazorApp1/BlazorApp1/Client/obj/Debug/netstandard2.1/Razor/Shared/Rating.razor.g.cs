#pragma checksum "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea09d1abed24b6668ac9780d0c6b5d488aa344b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Shared
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
    public partial class Rating : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor"
 for (int i = 1; i <= MaximoPuntaje; i++)
{
    var numeroEstrella = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor"
                      () => onclickHandle(numeroEstrella)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor"
                          () => onmouseoverHandle(numeroEstrella)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "style", "cursor:pointer");
            __builder.AddAttribute(5, "class", "fa" + " fa-star" + " " + (
#nullable restore
#line 9 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor"
                              PuntajeSeleccionado >= i ? "checked": null

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 10 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\Rating.razor"
       
    [Parameter] public int MaximoPuntaje { get; set; }
    [Parameter] public int PuntajeSeleccionado { get; set; }
    [Parameter] public EventCallback<int> OnVote { get; set; }
    [CascadingParameter] public Task<AuthenticationState> authenticationState { get; set; }
    private bool votado = false;

    private async Task onclickHandle(int numeroEstrella)
    {
        var authState = await authenticationState;
        if (authState.User.Identity.IsAuthenticated)
        {
            PuntajeSeleccionado = numeroEstrella;
            votado = true;
            await OnVote.InvokeAsync(PuntajeSeleccionado);
        }
        else
        {
            await mostrarMensajes.MostrarMensajeError("Debe de loguearse o registrarse para poder votar");
        }
    }

    private void onmouseoverHandle(int numeroEstrella)
    {
        if (!votado)
        {
            PuntajeSeleccionado = numeroEstrella;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
    }
}
#pragma warning restore 1591
