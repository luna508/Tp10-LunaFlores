﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Text = " ";
            if (checkBox1.Checked== true)
            {
                label1.Text = Text + "Ingles";
            }
            if (checkBox2.Checked)
            {
                label1.Text = Text + "Frances";
            }
            if (checkBox3.Checked==true)
            {
                label1.Text = Text + "Portugües";
            }
        }
    }
}
