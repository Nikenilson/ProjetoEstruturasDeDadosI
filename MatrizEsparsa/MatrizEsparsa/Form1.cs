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
        ListaCruzada matriz1;
        ListaCruzada matriz2;
        ListaCruzada matrizResultado;

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz1 = new ListaCruzada(linhas, colunas);

            btnGerarMatriz1.Visible = false;
            lMatriz1.Visible = true;
            gbOperacoes1.Visible = true;
            matriz1.Exibir(ref dgvMatriz1);
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            matriz1 = new ListaCruzada();
            matriz1.LerArquivo(openFileDialog1.FileName);

            btnLerArquivoMatriz1.Visible = false;
            btnGerarMatriz1.Visible = false;
            matriz1.Exibir(ref dgvMatriz1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            valor.Visible = true;
            valor.Text = matriz2.AcessarValor(linhas,colunas) + "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            valor.Text ="0";
            matriz2.ExcluirCelula(linhas, colunas);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int colunas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            matriz2.SomarK(colunas, Convert.ToDouble(nkMatriz2.Value));
            matriz2.Exibir(ref dgvMatriz2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void btnGerarMatriz2_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz2 = new ListaCruzada(linhas, colunas);

            lMatriz2.Visible = true;
            gbOperacoes2.Visible = true;
            btnGerarMatriz2.Visible = false;
            matriz2.Exibir(ref dgvMatriz2);
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

        private void lMatriz1_Click(object sender, EventArgs e)
        {
            matriz1.DesalocarMemoria();
            btnLerArquivoMatriz1.Visible = true;
            btnGerarMatriz1.Visible = true;
            gbOperacoes1.Visible = false;
            lMatriz1.Visible = false;

            matriz1.Exibir(ref dgvMatriz1);
        }

        private void lMatriz2_Click(object sender, EventArgs e)
        {
            matriz2.DesalocarMemoria();
            btnLerArquivoMatriz2.Visible = true;
            btnGerarMatriz2.Visible = true;
            gbOperacoes2.Visible = false;
            lMatriz2.Visible = false;

            matriz2.Exibir(ref dgvMatriz2);
        }

        private void btnLerArquivoMatriz2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            matriz2 = new ListaCruzada();
            matriz2.LerArquivo(openFileDialog1.FileName);

            btnLerArquivoMatriz2.Visible = false;
            btnGerarMatriz2.Visible = false;
            matriz2.Exibir(ref dgvMatriz2);
        }

        private void btnAcessarValorMatriz1_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            valor.Visible = true;
            valor.Text = matriz1.AcessarValor(linhas, colunas) + "";
        }

        private void btnRemoverValorMatriz1_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            valor.Text = "0";
            matriz1.ExcluirCelula(linhas, colunas);
            matriz1.Exibir(ref dgvMatriz1);
        }

        private void btnSomarKMatriz1_Click(object sender, EventArgs e)
        {
            int colunas = Convert.ToInt32(Math.Round(nColuna.Value, 0));

            matriz1.SomarK(colunas, Convert.ToDouble(nkMatriz1.Value));
            matriz1.Exibir(ref dgvMatriz1);
        }

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {
            matrizResultado = matriz1.SomarMatrizes(matriz1, matriz2);
            matrizResultado.Exibir(ref dgvMatriz3);
        }

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            matrizResultado = matriz1.MultiplicarMatrizes(matriz1, matriz2);
            matrizResultado.Exibir(ref dgvMatriz3);
        }
    }
}
