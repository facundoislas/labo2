using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    public class Persona
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public Persona(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }

        public string Mostrar()
        {
            return this.Nombre + " " + this.Apellido;
        }

    }

    public delegate void DelegadoString(string msg);
}
