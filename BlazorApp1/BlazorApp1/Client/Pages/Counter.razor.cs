﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;
using static BlazorApp1.Client.Shared.MainLayout;

namespace BlazorApp1.Client.Pages
{
    public class CounterBase: ComponentBase
    {
        [Inject] protected ServicioTransient Transient { get; set; }
        [Inject] protected ServicioSingleton Singleton { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }
        [CascadingParameter] private Task<AuthenticationState> authenticationState { get; set; }

        protected int currentCount = 0;
        static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            var authState = await authenticationState;
            var usuario = authState.User;

            if(usuario.Identity.IsAuthenticated)
            {
                currentCount++;
                currentCountStatic++;
            }
            else
            {
                currentCount--;
                currentCountStatic-- ;
            } 

            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic"); 
        }

        public async Task IncrementCountJavascript()
        {
            //Es invocar la funcion que creamos en el utilidades que es de javascript
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia",
                                     DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
