using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61_2
{
    public partial class Form1 : Form
    {

        Persona aux;
        public Form1()
        {
            InitializeComponent();
        }

        private void ltbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            ltbLista.Items.Clear();
            PersonaDAO dao = new PersonaDAO();
            List<Persona> lista = dao.Leer();
            for(int i= 0; i< lista.Count; i++)
            {
                ltbLista.Items.Add(lista[i]._nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNombre.Text.ToString(), txtApellido.Text.ToString());
            PersonaDAO dao = new PersonaDAO();
            if(dao.Guardar(p))
            {
                MessageBox.Show("Se ha guardado a la persona");
            }
            btnLeer_Click(sender, e);
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void ltbLista_DoubleClick(object sender, EventArgs e)
        {
            
            string nombre = ltbLista.Items[ltbLista.SelectedIndex].ToString();
            Persona p = new Persona(nombre, null);
            PersonaDAO dao = new PersonaDAO();
            aux = dao.LeerPorID(p);
            txtNombre.Text = aux._nombre.ToString();
            txtApellido.Text = aux._apellido.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            aux._nombre = txtNombre.Text;
            aux._apellido = txtApellido.Text;
            PersonaDAO dao = new PersonaDAO();
            if (dao.Modificar(aux))
                MessageBox.Show("Se modifico persona");
            btnLeer_Click(sender, e);
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            aux._nombre = txtNombre.Text;
            aux._apellido = txtApellido.Text;
            PersonaDAO dao = new PersonaDAO();
            if (dao.Borrar(aux))
                MessageBox.Show("Se borro persona");
            btnLeer_Click(sender, e);
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
