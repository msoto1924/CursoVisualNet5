using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPersonas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Crear EL Objeto Persona
            ClasePersona persona1 = new ClasePersona(txtNombre.Text, int.Parse(txtEdad.Text));
            if (persona1.Edad >= 18)
            {
                MessageBox.Show("La Edad De " + persona1.Nombre + " Es " + persona1.Edad + " Mayor De Edad");
            }
            else
            {
                MessageBox.Show("La Edad De " + persona1.Nombre + " Es " + persona1.Edad + " Menor De Edad");
            }
        }
    }
}
