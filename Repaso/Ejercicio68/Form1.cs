using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private event DelegadoString evento;

        

        public Form1()
        {
            InitializeComponent();
        }


        public static void NotificarCambio(string msj)
        {
            MessageBox.Show(msj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            evento += NotificarCambio;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(object.ReferenceEquals(persona, null))
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                btnCrear.Text = "Actualizar";
                evento("Se ha creado la persona: " + persona.Mostrar());
                
            }
            else
            {
                persona.Apellido = txtApellido.Text;
                persona.Nombre = txtNombre.Text;
                evento("Se Modifica la persona: " + persona.Mostrar());
                
            }

            
        }




    }
}
