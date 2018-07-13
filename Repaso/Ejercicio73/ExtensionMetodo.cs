using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    public static class ExtensionMetodo
    {
        public static int CantidadDeDigitos(this long valor)
        {
            int total = valor.ToString().Count();
            return total;
        }
    }
}
