using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avance_de_matriz
{
    public partial class Form1 : Form
    {
        matriz x1, x2, x3;

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = x1.descargar();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new matriz();
            x2 = new matriz();
            x3 = new matriz();
        }
    }
}
