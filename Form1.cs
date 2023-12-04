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
            textBox5.Text = x1.descargar();
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = x1.descargar();
        }

        private void tRANSPUESTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.transp(ref x2);
            textBox7.Text = x2.descargar();
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
    
        private void bUSQSECUENCIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox6.Text=string.Concat(x1.busqsec(int.Parse(textBox1.Text)));
        }

        private void tODOIGUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.todoiguales());
        }

        private void hALLARPOSICIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = x1.hallar_posicion(int.Parse(textBox1.Text));
        }

        private void hALLARPOS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b;
            a = x1.hallarposfila(int.Parse(textBox1.Text));
            b = x1.hallarposcolumna(int.Parse(textBox1.Text));
            textBox6.Text ="fila: "+a+ "   columna: "+b;
        }

        private void tODASLASPOSICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = x1.hallar_posicion2(int.Parse(textBox1.Text));
        }

        private void cARGARAPIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.cargar(4, 4, 1, 9);
            textBox5.Text = x1.descargar();
            
        }

        private void mENORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.num_menor());
        }

        private void pARESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.serie_pares(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = x1.descargar();
        }

        private void iMPARESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.serie_impares(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = x1.descargar();
        }

        private void fIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.serie_fibonacci(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = x1.descargar();
        }

        private void mAYORFILASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.mayfils();
            textBox7.Text = x1.descargar();
        }

        private void oRDCOLUMNASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordcols();
            textBox7.Text = x1.descargar();
        }

        private void vERIFORDASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.verifordasc());
        }

        private void vERORDASCRANGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.verifordascrango(int.Parse(textBox1.Text)));
        }

        private void iNTERFILSMAYORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.interfilsmay();
            textBox7.Text = x1.descargar();
        }

        private void sERIEENTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            x1.serie_enteros(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = x1.descargar();
        }

        private void sERIEENTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.serie_enteros2(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = x1.descargar();
        }

        private void sERIEENT3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.serie_enteros3(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = x1.descargar();
        }

        private void sERIEENT4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.serie_enteros4(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = x1.descargar();
        }

        private void iNTERCALARPARNOPARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.intercalarparNpar();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.ordenamientoXCOLS2();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenamientoXCOLS1();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.ordenamientoXCOLS4();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.ordenamientoXCOLS3();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.ordenamientoFIL1();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenamientoFIL2();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenamientoFIL3();
            textBox7.Text = x1.descargar();
        }

        private void oRDENAR4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenamientoFIL4();
            textBox7.Text = x1.descargar();
        }

        private void mENORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.num_menor());
        }

        private void cARGAR2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            x1.cargar2(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void pARIMPARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            x1.segmentarparimpar(); textBox7.Text = x1.descargar();
        }

        private void sUPDERECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenarTSD1(); textBox7.Text = x1.descargar();
        }

        private void sUPDERECHAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.segmparimparTSD1(); textBox7.Text = x1.descargar();
        }

        private void aSENDENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordDP1(); textBox7.Text = x1.descargar();
        }

        private void aCSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordDS1(); textBox7.Text = x1.descargar();
        }

        private void dESENDENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordDP2(); textBox7.Text = x1.descargar();
        }

        private void mAYORCOLUMNASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.maycols(); textBox7.Text = x1.descargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void sUPDERECHAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            x1.ordenarTSD2(); textBox7.Text = x1.descargar();
        }

        private void sUPIZQUIERDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.ordenarTSI1(); textBox7.Text = x1.descargar();
        }

        private void sUPIZQUIERDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenarTSI1(); textBox7.Text = x1.descargar();
        }

        private void iNFIZQUIERDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenarTII1(); textBox7.Text = x1.descargar();
        }

        private void iNFDERECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ordenarTID1(); textBox7.Text = x1.descargar();
        }
        private void fILASMAYORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.interfilsmay(); textBox7.Text = x1.descargar();
        }
        private void cOLSMAYORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.intercolsmay(); textBox7.Text = x1.descargar();
        }

        private void fILASMENORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.interfilsmayDES(); textBox7.Text = x1.descargar();
        }

        private void cOLSMENORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.intercolsmayDES(); textBox7.Text = x1.descargar();
        }

        private void iNTERCALARPARNOPARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            x1.intercalarparNpar(); textBox7.Text = x1.descargar();
        }

        private void pRIMONOPRIMOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.intercalarprimoNopri(); textBox7.Text = x1.descargar();
        }

        private void fIBONACCIYNOFIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.intercalarfiboNofibo(); textBox7.Text = x1.descargar();
        }

        private void cAPICUANOCAPICUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.intercalarcapicuaNOcap(); textBox7.Text = x1.descargar();
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
