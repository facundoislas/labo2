using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Ejercicio61_2
{
    public class PersonaDAO
    {
        
        private static SqlConnection conexion;
        private static SqlCommand comando;
        //private static string connectionStr = "Data Source=NT-990537\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True";

        public PersonaDAO() { }

        static PersonaDAO()
        {
            conexion = new SqlConnection("Data Source=NT-9900537\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public bool Guardar(Persona p)
        {
            string consulta;
            consulta = "INSERT INTO Personas (nombre,apellido) VALUES('"+p._nombre+"','"+p._apellido+"')";
            comando.CommandText = consulta;
            conexion.Open();
            
            comando.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();
           
            comando.CommandText = "SELECT * FROM Personas";
            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();
            Persona p;

            while(oDr.Read())
            {
                p = new Persona(oDr["nombre"].ToString(),oDr["apellido"].ToString(),int.Parse(oDr["id"].ToString()));
                listaPersonas.Add(p);
            }
            //comando.ExecuteNonQuery();
            conexion.Close();

            return listaPersonas;
        }
        
        
        public Persona LeerPorID(Persona p)
        {
            conexion.Open();
            comando.CommandText = "SELECT * FROM Personas where nombre ='" + p._nombre+"'";
            
            SqlDataReader oDr = comando.ExecuteReader();
            while(oDr.Read())
            {
                
                p._nombre = oDr["nombre"].ToString();
                p._apellido = oDr["apellido"].ToString();
                p._id = (int)oDr["id"];
            }
            conexion.Close();

            return p;
        }
        
        public bool Modificar(Persona p)
        {
            conexion.Open();
            comando.CommandText = "UPDATE Personas SET nombre='" + p._nombre + "', apellido='"+ p._apellido+"' where id="+p._id;
            comando.ExecuteNonQuery();
            
            conexion.Close();

            return true;
        }
        
        public bool Borrar(Persona p)
        {
            conexion.Open();
            comando.CommandText = "DELETE FROM Personas where id =" + p._id;
            
            comando.ExecuteNonQuery();
            conexion.Close();
    
            return true;
        }
        
    }
}
