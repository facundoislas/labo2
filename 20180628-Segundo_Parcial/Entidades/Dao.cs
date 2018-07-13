using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {

        public Votacion Leer(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(string nombre, Votacion vot)
        {
            bool flag = false;
            SqlConnection conexion = new SqlConnection("Data Source = NT-9900537\\SQLEXPRESS; Initial Catalog=votacion-sp-2018; Integrated Security= true");
            SqlCommand comando = new SqlCommand();
            try
            {
                
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                string consulta = "INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('";
                consulta = consulta + vot.NombreLey + "','" + vot.ContadorAfirmativo + "','" + vot.ContadorNegativo + "','" + vot.ContadorAbstencion + "','Facundo')";
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                flag = true;
            }
            catch(ErrorArchivoExpcepcion e)
            {
                Console.WriteLine(e.mensaje, e);
            }
            finally
            {
                conexion.Close();
            }
            return flag;
        }

    }
}
