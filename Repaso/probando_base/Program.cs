using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace probando_base
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionStr = 'Data Source=NT-990537\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True";

            Persona p1 = new Persona("Nicolas", "Rodriguez");
            Persona p2 = new Persona("Charly", "Garcia");

            SqlConnection conexion = new SqlConnection("Data Source=NT-9900537\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            string consulta;
            //consulta = "INSERT INTO Personas (nombre, apellido) VALUES('"+p2._nombre+"','"+ p2._apellido+"')";
            consulta = "UPDATE Personas set apellido='Pepe' where id=1";
            //consulta = "DELETE from Personas where id=1";
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
            Console.WriteLine("Se agrego P1");

            Console.ReadLine();


        }
    }
}
