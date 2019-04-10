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
        ListaCruzada novaMatriz;


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
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            novaMatriz = new ListaCruzada(linhas, colunas);
           
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            novaMatriz.LerArquivo(openFileDialog1.FileName);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            valor.Visible = true;
            valor.Text = novaMatriz.AcessarValor(linhas,colunas) + "";
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            valor.Text ="0";
            novaMatriz.ExcluirCelula(linhas, colunas);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int colunas = Convert.ToInt32(Math.Round(num4.Value, 0));
            
            novaMatriz.SomarK(colunas, Convert.ToDouble(num3.Value));
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // novaMatriz.SomarMatrizes(novaMatriz, lista1);
        }
    }
}
