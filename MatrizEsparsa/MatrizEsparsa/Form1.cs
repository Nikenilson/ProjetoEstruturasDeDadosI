using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// Samuel Gomes de Lima Dias - 18169
/// Guilherme Salim de Barros - 18188
///

namespace MatrizEsparsa
{
    public partial class Form1 : Form
    {
      //  MatrizEsparsa matriz;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(numericLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(numericColunas.Value, 0));
            ListaCruzada novaMatriz = new ListaCruzada(linhas, colunas);
           
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
