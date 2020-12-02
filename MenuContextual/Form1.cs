using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuContextual
{
    public partial class Form1 : Form
    {
        Color colorUtil;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton_Click(object sender, EventArgs e)
        {

        }

        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boton.Height = boton.Height * 2;
            boton.Width = boton.Width * 2;
        }

        private void pequeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boton.Height = boton.Height / 2;
            boton.Width = boton.Width / 2;
        }

        public Color seleccionarColor()
        {
            return colorUtil;
        }

        ColorDialog objColor = new ColorDialog();

        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(objColor.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objColor.Color;
                boton.BackColor = seleccionarColor();
            }
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boton.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
        }
    }
}
