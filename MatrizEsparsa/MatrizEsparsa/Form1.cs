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
        ListaCruzada matriz2;
        ListaCruzada matrizResultado;

        //Variaveis auxiliares para determinar quando alguns elementos devem ou não estar visiveis
        bool m1Existe = false;
        bool m2Existe = false;

        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        //Matriz 1
        //----------------------------------------------------------------------------------------------------------------------------------
        private void btnGerar_Click(object sender, EventArgs e) //Gera a Matriz 1 por meio do "teclado"
        {
            //Pega as linhas e colunas para criar a matriz
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz1 = new ListaCruzada(linhas, colunas);
            
            //Ajusta o tamanho da matriz e preenche ela com zeros, pois como ela acabou de ser criada, ainda está vazia
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

                //Lê as linhas e colunas do arquivo
                int linhasArq = int.Parse(arquivo.ReadLine());
                int colunasArq = int.Parse(arquivo.ReadLine());

                //Cria a matriz com as linhas e colunas desejadas
                matriz1 = new ListaCruzada(linhasArq, colunasArq);

                //Trata o arquivo lido e insere os valores na matriz em suas respectivas linhas e colunas
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
            //Pega a linhas e coluna a ser acessada
            int linha = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int coluna = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            //Acessa o valor e armazena ele em um label para o usuário 
            lblValorMatriz1.Visible = true;
            lblValorMatriz1.Text = matriz1.AcessarValor(linha, coluna) + "";
        }

        private void btnRemoverValorMatriz1_Click(object sender, EventArgs e)
        {
            //Pega a linhas e coluna a ser removida
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            //Remove o valor e re-exibe a matriz no DataGridView
            lblValorMatriz2.Text = "0";
            matriz1.ExcluirCelula(linhas, colunas);
            matriz1.Exibir(ref dgvMatriz1);
        }

        private void btnSomarKMatriz1_Click(object sender, EventArgs e)
        {
            //Pega a coluna em que a constante será somada
            int colunas = Convert.ToInt32(Math.Round(nColuna.Value, 0));

            //Soma a constante e re-exibe a matriz no DataGridView
            matriz1.SomarK(colunas, Convert.ToDouble(txtValorkMatriz.Text));
            matriz1.Exibir(ref dgvMatriz1);
        }
        private void btnInserirValorMatriz1_Click(object sender, EventArgs e)
        {
            //Insere o valor na linha e coluna desejada e re-exibe a matriz no DataGridView
            matriz1.InserirCelula(Convert.ToInt32(Math.Round(nLinha.Value, 0)), Convert.ToInt32(Math.Round(nColuna.Value, 0)), Convert.ToDouble(txtValorMatriz1.Text));
            matriz1.Exibir(ref dgvMatriz1);
        }
        private void lMatriz1_Click(object sender, EventArgs e) //Desaloca a memoria da matriz 1
        {
            matriz1.DesalocarMemoria();

            //"Limpa" o DataGridView
            dgvMatriz1.RowCount = 1;
            dgvMatriz1.ColumnCount = 1;

            //Altera a visibilidade de outros elementos
            m1Existe = false;
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
            //Pega as linhas e colunas para criar a matriz
            int linhas = Convert.ToInt32(Math.Round(nLinhas.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nColunas.Value, 0));
            matriz2 = new ListaCruzada(linhas, colunas);

            //Preenche a matriz com zeros
            foreach (DataGridViewRow row in dgvMatriz1.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;

            //Altera a visibilidade de outros elementos 
            m2Existe = true;
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

                //Lê as linhas e coluna e gera a matriz
                int linhasArq = int.Parse(arquivo.ReadLine());
                int colunasArq = int.Parse(arquivo.ReadLine());
                matriz2 = new ListaCruzada(linhasArq, colunasArq);

                //Trata o arquivo lido e insere os valores na matriz em suas respectivas linhas e colunas
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
            //Pega a linhas e coluna a ser removida
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            //Remove o valor e re-exibe a matriz no DataGridView
            lblValorMatriz2.Text = "0";
            matriz2.ExcluirCelula(linhas, colunas);
        }
        private void btnAcessarValorMatriz2_Click(object sender, EventArgs e)
        {
            //Pega a linhas e coluna a ser acessada
            int linhas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));
            int colunas = Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0));

            //Acessa o valor e mostra em um label para o usuário
            lblValorMatriz2.Visible = true;
            lblValorMatriz2.Text = matriz2.AcessarValor(linhas, colunas) + "";
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Pega a coluna em que a constante de ser somada
            int colunas = Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0));

            //Soma o valor e re-exibe a matriz no DataGridView
            matriz2.SomarK(colunas, Convert.ToDouble(txtValorkMatriz2.Text));
            matriz2.Exibir(ref dgvMatriz2);
        }
        private void btnInserirValorMatriz2_Click(object sender, EventArgs e)
        {
            //Insere o valor na matriz
            matriz2.InserirCelula(Convert.ToInt32(Math.Round(nLinhaMatriz2.Value, 0)), Convert.ToInt32(Math.Round(nColunaMatriz2.Value, 0)), Convert.ToDouble(txtValorMatriz2.Text));
            matriz2.Exibir(ref dgvMatriz2);
        }
        private void lMatriz2_Click(object sender, EventArgs e) //Desaloca a memoria da matriz 2
        {
            //Desaloca a matriz
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
            //Soma a Matriz1 e Matriz2
            matrizResultado = matriz1.SomarMatrizes(matriz1, matriz2);
            matrizResultado.Exibir(ref dgvMatriz3);
            lMatrizResultado.Enabled = true;
        }

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            //Multiplica a Matriz1 e Matriz2
            matrizResultado = matriz1.MultiplicarMatrizes(matriz1, matriz2);
            matrizResultado.Exibir(ref dgvMatriz3);
            lMatrizResultado.Enabled = true;
        }

        private void lMatrizResultado_Click(object sender, EventArgs e)
        {
            //Libera a matriz Resultado
            matrizResultado.DesalocarMemoria();
            dgvMatriz3.RowCount = 0;
            dgvMatriz3.ColumnCount = 0;

            lMatrizResultado.Enabled = false;
        }
    }
}
