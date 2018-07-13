using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61_2
{
    public class Persona
    {

        public  int _id;
        public string _nombre;
        public string _apellido;

        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public Persona(string nombre, string apellido, int id):this(nombre, apellido)
        {
            this._id = id;
        }



    }
}
