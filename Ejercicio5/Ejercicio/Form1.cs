using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Disponer tres objetos de la clase CheckBox con nombres de navegadores web. 
 * Cuando se presione un botón mostrar en un label los programas seleccionados.*/

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "Google";
            }
            else if (checkBox1.Checked == false)
            {
                label1.Text = " ";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                label1.Text = "Opera";

            }
            else if (checkBox2.Checked== false)
            {
                label1.Text = " ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {
                label1.Text= "Brave";
            }
            else if (checkBox3.Checked== false)
            {
                label1.Text = " ";
            }
        }
    }
}
