using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string apellido = textBox1.Text;

            SqlConnection conexion = new SqlConnection("Data Source=NT-9900537\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            string consulta;
            consulta = "INSERT INTO Personas (nombre, apellido) VALUES('"+nombre+"','"+ apellido+"')";
            //consulta = "UPDATE Personas set apellido='Pepe' where id=1";
            //consulta = "DELETE from Personas where id=1";
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se ha guardado los datos");
            Close();
        }


    }
}
