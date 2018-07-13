using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPP;
using System.Threading;

namespace formulario
{
    public partial class Form1 : Form
    {

        public List<Base> listaElementos;



        public Form1()
        {
            InitializeComponent();
            this.listaElementos = new List<Base>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Formulario Facundo"; // cambio nombre del formulario
        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {

            Base derUno1 = new DerivadaUno(10, 11, 12);
            DerivadaUno derUno2 = new DerivadaUno(1, 2, 3);
            Base derDos1 = new DerivadaDos();

            listaElementos.Add(derUno1);
            listaElementos.Add(derUno2);
            listaElementos.Add(derDos1);

            // Generar el código para obtener todos los datos de los elementos de la lista y luego utilizar CargarRichTextBox para mostrarlos
            string auxiliar = "";
            auxiliar += auxiliar + derUno1.MostrarVersion() + derUno2.MostrarVersion() + derDos1.MostrarVersion();

            this.CargarRichTextBox(auxiliar);

            Base.GuardarDatos(listaElementos[0]);

        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Primer Parcial","Para Primer Parcial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {

        }


        delegate void CargarRichTextBoxCallback(string datos);

        private void CargarRichTextBox (string datos)
        {

            /* el hilo en el que está actualmente esa llamada es diferente al hilo en el que se creó el control, 
             por tanto, creamos un nuevo objeto del tipo del delegado, 
            le indicamos que método debe usar y a continuación llamamos al método Invoke de nuestro formulario, 
             cuando se entre nuevamente en ese método (porque el formulario lo "invoca") 
            el valor que devolverá la propiedad InvokeRequired será False*/


            if (rtbTextoSalida.InvokeRequired)
            {
                CargarRichTextBoxCallback d = new CargarRichTextBoxCallback(CargarRichTextBox);
                this.Invoke(d, new object[] { datos });
            }
            else
            {
                rtbTextoSalida.Text = datos;
            }

        }

        
        
    }
}
