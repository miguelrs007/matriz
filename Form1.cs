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

        private void tRANSPUESTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.transp(ref x2);
            textBox5.Text = x2.descargar();
        }

        private void cARGAR1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.cargar1(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void cARGAR2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.cargar2(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void pROMEDIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.prom());
        }

        private void mAYORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.myor());
        }

        private void fRECUENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.frecuencia(int.Parse(textBox1.Text)));
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = x2.descargar();
        }

        private void oRDENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenamiento();
            textBox5.Text = x1.descargar();
        }

        private void bUSQSECUENCIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox6.Text=string.Concat(x1.busqsec(int.Parse(textBox1.Text)));
        }

        private void tODOIGUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.todoiguales());
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
