using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading;
using System.Data;

namespace EntidadesPP
{
    public abstract class Base
    {

        private static int version;
        private static int subversion;

        static Base()
        {
            Base.version = 1;
            Base.subversion = 0;
        }


        public string Version
        {
            get
            {
                return Base.version.ToString();
            }

            set
            {
                int aux;
                if (int.TryParse(value, out aux))
                    Base.version = aux;
            }
        }

        public abstract string VersionFull { get; }


        public Base(int ver, int sub)
        {
            Base.version = ver;
            Base.subversion = sub;
        }

        public virtual string MostrarVersion()
        {
            return string.Format("{0}.{1}", Base.version, Base.subversion);
        }

        public static string operator ~ (Base b)
        {
            return string.Format("{1}.{0}", Base.version, Base.subversion);
        }

        public override int GetHashCode()
        {
            return Base.version + Base.subversion;
        }

        public static bool GuardarDatos<T>(T dato) where T : Base
        {

            bool flag = true;

            SqlConnection conexion = new SqlConnection("Data Source = NT-9900537\\SQLEXPRESS; Initial Catalog = final-20171207; Integrated Security = True");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.Connection = conexion;

            try
            {
                comando.CommandText = "INSERT INTO Datos (version, subversion, revision, derivada) VALUES ('"+ dato.Version +"','"+ dato.Version +"','"+ dato.Version +"','"+ dato.Version +"')";
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch
            {
                flag = false;
            }
            finally
            {
                if (flag)
                    conexion.Close();
            }

            return flag;
        }
        /*
        public static Queue<T> LeerDatos<T>() where T:Base
        {
            Queue<T> cola = new Queue<T>();

            SqlConnection conexion = new SqlConnection("DataSource = NT-9900537\\SQLEXPRESS; Initial Catalog = final-20171207 Integrated Security = True");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.Connection = conexion;
            T b;

            try
            {
                conexion.Open();
                SqlDataReader read = comando.ExecuteReader();
                
                while (read.Read())
                {
                    Base.version = int.Parse(read["version"].ToString());
                    Base.subversion = int.Parse(read["subversion"].ToString());
                   
                    cola.Enqueue(Base.version);
                }


            }
            catch
            {
                throw new NotImplementedException();
            }
            finally
            {
                conexion.Close();
            }

            return cola;
        }
        */

        public static void EjecutarEvento(List<Base> lista)
        {
            foreach(Base aux in lista)
            {
                GuardarDatos<Base>(aux);
            }

        }
    }
}
