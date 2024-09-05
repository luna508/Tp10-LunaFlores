using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Confeccionar un programa que muestre 3 objetos de la clase RadioButton que permitan configurar el 
ancho y alto del Form. Cuando se presione un botón actualizar el ancho y alto.*/

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                this.Width = 600;
                this.Height = 400;
                this.BackColor = Color.Green;
            }
            if (radioButton2.Checked == true)
            {
                this.Width = 800;
                this.Height = 500;
                this.BackColor = Color.Red;
            }
            if (radioButton4.Checked== true)
            {
                this.Width = 300;
                this.Height = 2000;
                this.BackColor = Color.Yellow;
            }
            button1.Enabled = true;

        }

       
    }
}
