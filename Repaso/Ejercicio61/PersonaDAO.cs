using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        /*
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static string connectionStr = "Data Source=NT-990537\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True";

        static PersonaDAO()
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public bool Guardar(Persona p)
        {
            string consulta;
            consulta = "INSERT INTO Personas (nombre) VALUES('"+p._nombre+"')";
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public List<Persona> Leer()
        {
               List<Persona> listaPersonas = new List<Persona>();
            comando.CommandText = "SELECT * FROM Persona";
            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();

            while(oDr.Read())
            {
                new Persona(oDr["id"],oDr["nombre"],oDr["apellido"]);
                listaPersonas.Add(oDr[ID] =
            }


            return listaPersonas;
        }
        }

        public bool LeerPorID(int id)
        {

        }

        public bool Modificar(int id)
        {

        }

        public bool Borrar(int id)
        {

        }
        */
    }
}
