using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Permitir el ingreso de dos números en controles de tipo TextBox y mediante dos controles de tipo 
RadioButton permitir seleccionar si queremos sumarlos o restarlos. Al presionar un botón mostrar el 
resultado de la operación seleccionada.*/

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int suma = numero1 + numero2;
            int resta = numero1 - numero2;

            if (radioButton1.Checked== true)
            {
                label1.Text = "La resta es: " + resta;
            }
            else
            {
                if (radioButton2.Checked==true)
                {
                    label1.Text = "La suma es: " + suma;
                }
                else
                {
                    label1.Text = "Seleccione una opcion";
                }
            }
        }

        
    }
}
