using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

///
/// Samuel Gomes de Lima Dias - 18169
/// Guilherme Salim de Barros - 18188
///

namespace MatrizEsparsa
{
    public partial class Form1 : Form
    {
        ListaCruzada matriz1;
        bool m1Existe = false;
        ListaCruzada matriz2;
        bool m2Existe = false;
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
            m1Existe = true;
            if (m2Existe)
            {
                btnSomarMatrizes.Enabled = true;
                btnMultiplicarMatrizes.Enabled = true;
            }
            btnGerarMatriz1.Enabled = false;
            lMatriz1.Enabled = true;
            gbOperacoes1.Visible = true;
        }
        private void btnLerArquivo_Click(object sender, EventArgs e) //Gera a Matriz 1 por meio da leitura de um arquivo
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var arquivo = new StreamReader(openFileDialog1.FileName);

                int linhasArq = int.Parse(arquivo.ReadLine());
                int colunasArq = int.Parse(arquivo.ReadLine());

                matriz1 = new ListaCruzada(linhasArq, colunasArq);

                string linha = arquivo.ReadLine();
                linha = linha.Replace('(', ' ');
                linha = linha.Replace(')', ' ');
                linha = linha.Replace('{', ' ');
                linha = linha.Replace('}', ' ');
                linha.Trim();
                string[] matrizString = linha.Split(',');
                for (int i = 0; i < matrizString.Length; i++)
                {
                    string whatsInside = matrizString[i];
                    int linhaCelula = int.Parse(matrizString[i]);
                    i++;
                    int colunaCelula = int.Parse(matrizString[i]);
                    i++;
                    double valor = double.Parse(matrizString[i]);
                    i++;

                    matriz1.InserirCelula(linhaCelula, colunaCelula, valor);
                }
                arquivo.Close();
                matriz1.Exibir(ref dgvMatriz1);

                //Altera a visibilidade de outros elementos 
                btnLerArquivoMatriz1.Enabled = false;
                btnGerarMatriz1.Enabled = false;
                lMatriz1.Enabled = true;
                gbOperacoes1.Visible = true;

            }
        }

        private void btnAcessarValorMatriz1_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            lblValorMatriz1.Visible = true;
            lblValorMatriz1.Text = matriz1.AcessarValor(linhas, colunas) + "";
        }

        private void btnRemoverValorMatriz1_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            lblValorMatriz2.Text = "0";
            matriz1.ExcluirCelula(linhas, colunas);
            matriz1.Exibir(ref dgvMatriz1);
        }

        private void btnSomarKMatriz1_Click(object sender, EventArgs e)
        {
            int colunas = Convert.ToInt32(Math.Round(nColuna.Value, 0));

            matriz1.SomarK(colunas, Convert.ToDouble(txtValorkMatriz.Text));
            matriz1.Exibir(ref dgvMatriz1);
        }
        private void btnInserirValorMatriz1_Click(object sender, EventArgs e)
        {
            matriz1.InserirCelula(Convert.ToInt32(Math.Round(nLinha.Value, 0)), Convert.ToInt32(Math.Round(nColuna.Value, 0)), Convert.ToDouble(txtValorMatriz1.Text));
            matriz1.Exibir(ref dgvMatriz1);
        }
        private void lMatriz1_Click(object sender, EventArgs e) //Desaloca a memoria da matriz 1
        {
            m1Existe = false;
            matriz1.DesalocarMemoria();
            dgvMatriz1.RowCount = 1;
            dgvMatriz1.ColumnCount = 1;

            //Altera a visibilidade de outros elementos
            btnLerArquivoMatriz1.Enabled = true;
            btnGerarMatriz1.Enabled = true;
            gbOperacoes1.Visible = false;
            lMatriz1.Enabled = false;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        //Matriz 2
        //----------------------------------------------------------------------------------------------------------------------------------
        private void btnGerarMatriz2_Click(object sender, EventArgs e) //Gera a matriz 2 por meio do "teclado"
        {
            m2Existe = true;
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz2 = new ListaCruzada(linhas, colunas);
            foreach (DataGridViewRow row in dgvMatriz1.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;

            //Altera a visibilidade de outros elementos 
            if (m1Existe)
            {
                btnSomarMatrizes.Enabled = true;
                btnMultiplicarMatrizes.Enabled = true;
            }
            lMatriz2.Enabled = true;
            gbOperacoes2.Visible = true;
            btnGerarMatriz2.Enabled = false;
        }
        private void btnLerArquivoMatriz2_Click(object sender, EventArgs e) //Gera a matriz 2 por meio da leitura de um arquivo
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var arquivo = new StreamReader(openFileDialog1.FileName);

                int linhasArq = int.Parse(arquivo.ReadLine());
                int colunasArq = int.Parse(arquivo.ReadLine());

                matriz2 = new ListaCruzada(linhasArq, colunasArq);

                string linha = arquivo.ReadLine();
                linha = linha.Replace('(', ' ');
                linha = linha.Replace(')', ' ');
                linha = linha.Replace('{', ' ');
                linha = linha.Replace('}', ' ');
                linha.Trim();
                string[] matrizString = linha.Split(',');
                for (int i = 0; i < matrizString.Length;)
                {
                    int linhaCelula = int.Parse(matrizString[i]);
                    i++;
                    int colunaCelula = int.Parse(matrizString[i]);
                    i++;
                    double valor = double.Parse(matrizString[i]);
                    i++;

                    matriz2.InserirCelula(linhaCelula, colunaCelula, valor);
                }
                arquivo.Close();
                matriz2.Exibir(ref dgvMatriz2);

                //Altera a visibilidade de outros elementos 
                btnLerArquivoMatriz2.Enabled = false;
                btnGerarMatriz2.Enabled = false;
                lMatriz2.Enabled = true;
                gbOperacoes2.Visible = true;
            }
        }
        private void btnRemoverValorMatriz2_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            lblValorMatriz2.Text = "0";
            matriz2.ExcluirCelula(linhas, colunas);
        }
        private void btnAcessarValorMatriz2_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            lblValorMatriz2.Visible = true;
            lblValorMatriz2.Text = matriz2.AcessarValor(linhas, colunas) + "";
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            int colunas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            matriz2.SomarK(colunas, Convert.ToDouble(txtValorkMatriz2.Text));
            matriz2.Exibir(ref dgvMatriz2);
        }
        private void btnInserirValorMatriz2_Click(object sender, EventArgs e)
        {
            matriz2.InserirCelula(Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0)), Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0)), Convert.ToDouble(txtValorMatriz2.Text));
            matriz2.Exibir(ref dgvMatriz2);
        }
        private void lMatriz2_Click(object sender, EventArgs e) //Desaloca a memoria da matriz 2
        {
            matriz2.DesalocarMemoria();

            dgvMatriz2.RowCount = 1;
            dgvMatriz2.ColumnCount = 1;

            //Altera a visibilidade de outros elementos 
            m2Existe = false;
            btnLerArquivoMatriz2.Enabled = true;
            btnGerarMatriz2.Enabled = true;
            gbOperacoes2.Visible = false;
            lMatriz2.Enabled = false;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        //MatrizResultado
        //----------------------------------------------------------------------------------------------------------------------------------
        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {
            matrizResultado = matriz1.SomarMatrizes(matriz1, matriz2);
            matrizResultado.Exibir(ref dgvMatriz3);
            lMatrizResultado.Enabled = true;
        }

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            matrizResultado = matriz1.MultiplicarMatrizes(matriz1, matriz2);
            matrizResultado.Exibir(ref dgvMatriz3);
            lMatrizResultado.Enabled = true;
        }

        private void lMatrizResultado_Click(object sender, EventArgs e)
        {
            matrizResultado.DesalocarMemoria();
            dgvMatriz3.RowCount = 0;
            dgvMatriz3.ColumnCount = 0;

            lMatrizResultado.Enabled = false;
        }
    }
}
