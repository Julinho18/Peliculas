using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Helpers
{
    //Hemos creado una clase y dentro de esa clase tenemos el metodo de colocarmayusculas
    public class UtilidadesString
    {
        public static string ColocarMayuscula(string valor) => valor.ToUpper();
    }
}
