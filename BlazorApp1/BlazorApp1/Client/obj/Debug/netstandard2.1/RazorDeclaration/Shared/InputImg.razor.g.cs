#pragma checksum "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\InputImg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9962470f44c746dd21142bfb9b68984231ca387a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\InputImg.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\InputImg.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Julinho\source\repos\BlazorApp1\BlazorApp1\Client\Shared\InputImg.razor"
       
    [Parameter] public string Label { get; set; } = "Imagen";
    [Parameter] public string ImagenTemporal { get; set; }
    [Parameter] public EventCallback<string> ImagenSeleccionada { get; set; }
    private string imagenBase64;

    ElementReference inputElement;//Podemos hacer referencia a un elemento de html
    async Task ImageFileSelected()
    {
        foreach(var file in await fileeaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using (MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4 * 1024))//4 kbs
            {
                var bytesImagen = new byte[memoryStream.Length];
                memoryStream.Read(bytesImagen, 0, (int)memoryStream.Length);
                imagenBase64 = Convert.ToBase64String(bytesImagen);
                //avisarle al componente padre q la imagen a sido seleccionada
                await ImagenSeleccionada.InvokeAsync(imagenBase64);
                ImagenTemporal = null;
                StateHasChanged();//avisarle a blazor, que ha ocurrido un cambio
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileeaderService { get; set; }
    }
}
#pragma warning restore 1591
