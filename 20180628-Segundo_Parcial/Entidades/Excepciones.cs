using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorArchivoExpcepcion: Exception
    {
        public string mensaje;

        public ErrorArchivoExpcepcion(string msj):this(msj,null)
        {

        }

        public ErrorArchivoExpcepcion(string msj, Exception innerException):base(msj,null)
        {

        }
    }
}
