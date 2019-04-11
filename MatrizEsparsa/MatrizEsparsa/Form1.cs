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

        //----------------------------------------------------------------------------------------------------------------------------------
        //Matriz 1
        //----------------------------------------------------------------------------------------------------------------------------------
        private void btnGerar_Click(object sender, EventArgs e) //Gera a Matriz 1 por meio do "teclado"
        {
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz1 = new ListaCruzada(linhas, colunas);
            dgvMatriz1.RowCount = linhas;
            dgvMatriz1.ColumnCount = colunas;
            foreach (DataGridViewRow row in dgvMatriz1.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;

            //Altera a visibilidade de outros elementos 
            btnGerarMatriz1.Visible = false;
            lMatriz1.Visible = true;
            gbOperacoes1.Visible = true;
        }
        private void btnLerArquivo_Click(object sender, EventArgs e) //Gera a Matriz 1 por meio da leitura de um arquivo
        {
            openFileDialog1.ShowDialog();
            matriz1 = new ListaCruzada();
            matriz1.LerArquivo(openFileDialog1.FileName);
            matriz1.Exibir(ref dgvMatriz1);

            //Altera a visibilidade de outros elementos 
            btnLerArquivoMatriz1.Visible = false;
            btnGerarMatriz1.Visible = false;
        }
        private void lMatriz1_Click(object sender, EventArgs e) //Desaloca a memoria da matriz 1
        {
            matriz1.DesalocarMemoria();
            foreach (DataGridViewRow row in dgvMatriz1.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;

            //Altera a visibilidade de outros elementos
            btnLerArquivoMatriz1.Visible = true;
            btnGerarMatriz1.Visible = true;
            gbOperacoes1.Visible = false;
            lMatriz1.Visible = false;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        //Matriz 2
        //----------------------------------------------------------------------------------------------------------------------------------
        private void btnGerarMatriz2_Click(object sender, EventArgs e) //Gera a matriz 2 por meio do "teclado"
        {
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz2 = new ListaCruzada(linhas, colunas);
            matriz2.Exibir(ref dgvMatriz2);

            //Altera a visibilidade de outros elementos 
            lMatriz2.Visible = true;
            gbOperacoes2.Visible = true;
            btnGerarMatriz2.Visible = false;
        }
        private void btnLerArquivoMatriz2_Click(object sender, EventArgs e) //Gera a matriz 2 por meio da leitura de um arquivo
        {
            openFileDialog1.ShowDialog();
            matriz2 = new ListaCruzada();
            matriz2.LerArquivo(openFileDialog1.FileName);
            matriz2.Exibir(ref dgvMatriz2);

            //Altera a visibilidade de outros elementos 
            btnLerArquivoMatriz2.Visible = false;
            btnGerarMatriz2.Visible = false;
        }
        private void lMatriz2_Click(object sender, EventArgs e) //Desaloca a memoria da matriz 1
        {
            matriz2.DesalocarMemoria();
            foreach (DataGridViewRow row in dgvMatriz2.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;

            //Altera a visibilidade de outros elementos 
            btnLerArquivoMatriz2.Visible = true;
            btnGerarMatriz2.Visible = true;
            gbOperacoes2.Visible = false;
            lMatriz2.Visible = false;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        //MatrizResultado
        //----------------------------------------------------------------------------------------------------------------------------------

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
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
