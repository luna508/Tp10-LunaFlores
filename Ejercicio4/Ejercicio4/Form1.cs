using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Disponer un control Label que muestre el siguiente mensaje: "Está de acuerdo con las normas del servicio?", 
 * luego un CheckBox y finalmente un objeto de tipo Button desactivo (propiedad Enabled con false). 
 * Cuando se tilde el CheckBox debemos activar el botón (para esto debemos responder al evento) */

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text= "¿Esta de acuerdo con las normas de servicio?"
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                button1.Enabled = false;
            }

        }

        
    }
}



    


