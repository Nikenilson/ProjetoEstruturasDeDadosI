namespace MatrizEsparsa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOperacoes2 = new System.Windows.Forms.GroupBox();
            this.nkMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.lblColuna2 = new System.Windows.Forms.Label();
            this.nLinhaMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.nColunaMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.lblLinha2 = new System.Windows.Forms.Label();
            this.btnSomarK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gBGerarMatriz = new System.Windows.Forms.GroupBox();
            this.lMatriz2 = new System.Windows.Forms.Button();
            this.lMatriz1 = new System.Windows.Forms.Button();
            this.btnLerArquivoMatriz2 = new System.Windows.Forms.Button();
            this.btnLerArquivoMatriz1 = new System.Windows.Forms.Button();
            this.btnGerarMatriz2 = new System.Windows.Forms.Button();
            this.btnGerarMatriz1 = new System.Windows.Forms.Button();
            this.nLinhas = new System.Windows.Forms.NumericUpDown();
            this.lblLinhas1 = new System.Windows.Forms.Label();
            this.lblColunas1 = new System.Windows.Forms.Label();
            this.nColunas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMatriz3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOperacoes1 = new System.Windows.Forms.GroupBox();
            this.nkMatriz1 = new System.Windows.Forms.NumericUpDown();
            this.lblColuna1 = new System.Windows.Forms.Label();
            this.nLinha = new System.Windows.Forms.NumericUpDown();
            this.nColuna = new System.Windows.Forms.NumericUpDown();
            this.lblLinha1 = new System.Windows.Forms.Label();
            this.btnSomarKMatriz1 = new System.Windows.Forms.Button();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            this.lblk = new System.Windows.Forms.Label();
            this.btnRemoverValorMatriz1 = new System.Windows.Forms.Button();
            this.lblValorMatriz1 = new System.Windows.Forms.Label();
            this.btnAcessarValorMatriz1 = new System.Windows.Forms.Button();
            this.gbOperacoes2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nkMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLinhaMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColunaMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            this.gBGerarMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz3)).BeginInit();
            this.gbOperacoes1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nkMatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColuna)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(5, -21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(808, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "◤◢◤◢◣◥◣ ◢◤◢◣◥◣◥◤◢◤◢◣◥◣◥";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(579, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(822, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "◣◥◣◥◤◢◤ ◥◣◥◤◢◤ ◢◣◥◣◥◤◢◤◢";
            // 
            // gbOperacoes2
            // 
            this.gbOperacoes2.Controls.Add(this.nkMatriz2);
            this.gbOperacoes2.Controls.Add(this.lblColuna2);
            this.gbOperacoes2.Controls.Add(this.nLinhaMatriz2);
            this.gbOperacoes2.Controls.Add(this.nColunaMatriz2);
            this.gbOperacoes2.Controls.Add(this.lblLinha2);
            this.gbOperacoes2.Controls.Add(this.btnSomarK);
            this.gbOperacoes2.Controls.Add(this.label9);
            this.gbOperacoes2.Controls.Add(this.button3);
            this.gbOperacoes2.Controls.Add(this.valor);
            this.gbOperacoes2.Controls.Add(this.button2);
            this.gbOperacoes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacoes2.Location = new System.Drawing.Point(12, 380);
            this.gbOperacoes2.Name = "gbOperacoes2";
            this.gbOperacoes2.Size = new System.Drawing.Size(450, 142);
            this.gbOperacoes2.TabIndex = 6;
            this.gbOperacoes2.TabStop = false;
            this.gbOperacoes2.Text = "Operações da Matriz 2";
            this.gbOperacoes2.Visible = false;
            // 
            // nkMatriz2
            // 
            this.nkMatriz2.Location = new System.Drawing.Point(39, 103);
            this.nkMatriz2.Name = "nkMatriz2";
            this.nkMatriz2.Size = new System.Drawing.Size(49, 31);
            this.nkMatriz2.TabIndex = 21;
            // 
            // lblColuna2
            // 
            this.lblColuna2.AutoSize = true;
            this.lblColuna2.Location = new System.Drawing.Point(6, 27);
            this.lblColuna2.Name = "lblColuna2";
            this.lblColuna2.Size = new System.Drawing.Size(86, 25);
            this.lblColuna2.TabIndex = 19;
            this.lblColuna2.Text = "Coluna:";
            // 
            // nLinhaMatriz2
            // 
            this.nLinhaMatriz2.Location = new System.Drawing.Point(98, 65);
            this.nLinhaMatriz2.Name = "nLinhaMatriz2";
            this.nLinhaMatriz2.Size = new System.Drawing.Size(49, 31);
            this.nLinhaMatriz2.TabIndex = 16;
            this.nLinhaMatriz2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nColunaMatriz2
            // 
            this.nColunaMatriz2.Location = new System.Drawing.Point(98, 25);
            this.nColunaMatriz2.Name = "nColunaMatriz2";
            this.nColunaMatriz2.Size = new System.Drawing.Size(49, 31);
            this.nColunaMatriz2.TabIndex = 16;
            this.nColunaMatriz2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLinha2
            // 
            this.lblLinha2.AutoSize = true;
            this.lblLinha2.Location = new System.Drawing.Point(7, 67);
            this.lblLinha2.Name = "lblLinha2";
            this.lblLinha2.Size = new System.Drawing.Size(71, 25);
            this.lblLinha2.TabIndex = 16;
            this.lblLinha2.Text = "Linha:";
            // 
            // btnSomarK
            // 
            this.btnSomarK.Location = new System.Drawing.Point(93, 99);
            this.btnSomarK.Name = "btnSomarK";
            this.btnSomarK.Size = new System.Drawing.Size(114, 36);
            this.btnSomarK.TabIndex = 18;
            this.btnSomarK.Text = "Somar k";
            this.btnSomarK.UseVisualStyleBackColor = true;
            this.btnSomarK.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "k:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(153, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "Remover valor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(337, 49);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(62, 25);
            this.valor.TabIndex = 11;
            this.valor.Text = "Valor";
            this.valor.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Acessar valor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz2.Location = new System.Drawing.Point(705, 37);
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.Size = new System.Drawing.Size(231, 485);
            this.dgvMatriz2.TabIndex = 7;
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz1.Location = new System.Drawing.Point(468, 37);
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.Size = new System.Drawing.Size(231, 485);
            this.dgvMatriz1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // gBGerarMatriz
            // 
            this.gBGerarMatriz.Controls.Add(this.lMatriz2);
            this.gBGerarMatriz.Controls.Add(this.lMatriz1);
            this.gBGerarMatriz.Controls.Add(this.btnLerArquivoMatriz2);
            this.gBGerarMatriz.Controls.Add(this.btnLerArquivoMatriz1);
            this.gBGerarMatriz.Controls.Add(this.btnGerarMatriz2);
            this.gBGerarMatriz.Controls.Add(this.btnGerarMatriz1);
            this.gBGerarMatriz.Controls.Add(this.nLinhas);
            this.gBGerarMatriz.Controls.Add(this.lblLinhas1);
            this.gBGerarMatriz.Controls.Add(this.lblColunas1);
            this.gBGerarMatriz.Controls.Add(this.nColunas);
            this.gBGerarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBGerarMatriz.Location = new System.Drawing.Point(12, 22);
            this.gBGerarMatriz.Name = "gBGerarMatriz";
            this.gBGerarMatriz.Size = new System.Drawing.Size(450, 161);
            this.gBGerarMatriz.TabIndex = 18;
            this.gBGerarMatriz.TabStop = false;
            this.gBGerarMatriz.Text = "Gerar Matriz ";
            // 
            // lMatriz2
            // 
            this.lMatriz2.Location = new System.Drawing.Point(328, 67);
            this.lMatriz2.Name = "lMatriz2";
            this.lMatriz2.Size = new System.Drawing.Size(116, 41);
            this.lMatriz2.TabIndex = 17;
            this.lMatriz2.Text = "Liberar 2";
            this.lMatriz2.UseVisualStyleBackColor = true;
            this.lMatriz2.Visible = false;
            this.lMatriz2.Click += new System.EventHandler(this.lMatriz2_Click);
            // 
            // lMatriz1
            // 
            this.lMatriz1.Location = new System.Drawing.Point(328, 19);
            this.lMatriz1.Name = "lMatriz1";
            this.lMatriz1.Size = new System.Drawing.Size(116, 42);
            this.lMatriz1.TabIndex = 16;
            this.lMatriz1.Text = "Liberar 1";
            this.lMatriz1.UseVisualStyleBackColor = true;
            this.lMatriz1.Visible = false;
            this.lMatriz1.Click += new System.EventHandler(this.lMatriz1_Click);
            // 
            // btnLerArquivoMatriz2
            // 
            this.btnLerArquivoMatriz2.Location = new System.Drawing.Point(222, 116);
            this.btnLerArquivoMatriz2.Name = "btnLerArquivoMatriz2";
            this.btnLerArquivoMatriz2.Size = new System.Drawing.Size(222, 39);
            this.btnLerArquivoMatriz2.TabIndex = 15;
            this.btnLerArquivoMatriz2.Text = "Ler Arquivo Matriz 2";
            this.btnLerArquivoMatriz2.UseVisualStyleBackColor = true;
            this.btnLerArquivoMatriz2.Click += new System.EventHandler(this.btnLerArquivoMatriz2_Click);
            // 
            // btnLerArquivoMatriz1
            // 
            this.btnLerArquivoMatriz1.Location = new System.Drawing.Point(3, 116);
            this.btnLerArquivoMatriz1.Name = "btnLerArquivoMatriz1";
            this.btnLerArquivoMatriz1.Size = new System.Drawing.Size(213, 39);
            this.btnLerArquivoMatriz1.TabIndex = 15;
            this.btnLerArquivoMatriz1.Text = "Ler Arquivo Matriz 1";
            this.btnLerArquivoMatriz1.UseVisualStyleBackColor = true;
            this.btnLerArquivoMatriz1.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnGerarMatriz2
            // 
            this.btnGerarMatriz2.Location = new System.Drawing.Point(164, 68);
            this.btnGerarMatriz2.Name = "btnGerarMatriz2";
            this.btnGerarMatriz2.Size = new System.Drawing.Size(158, 42);
            this.btnGerarMatriz2.TabIndex = 7;
            this.btnGerarMatriz2.Text = "Gerar Matriz 2";
            this.btnGerarMatriz2.UseVisualStyleBackColor = true;
            this.btnGerarMatriz2.Click += new System.EventHandler(this.btnGerarMatriz2_Click);
            // 
            // btnGerarMatriz1
            // 
            this.btnGerarMatriz1.Location = new System.Drawing.Point(164, 19);
            this.btnGerarMatriz1.Name = "btnGerarMatriz1";
            this.btnGerarMatriz1.Size = new System.Drawing.Size(158, 43);
            this.btnGerarMatriz1.TabIndex = 7;
            this.btnGerarMatriz1.Text = "Gerar Matriz 1";
            this.btnGerarMatriz1.UseVisualStyleBackColor = true;
            this.btnGerarMatriz1.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // nLinhas
            // 
            this.nLinhas.Location = new System.Drawing.Point(109, 73);
            this.nLinhas.Name = "nLinhas";
            this.nLinhas.Size = new System.Drawing.Size(49, 31);
            this.nLinhas.TabIndex = 9;
            this.nLinhas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLinhas1
            // 
            this.lblLinhas1.AutoSize = true;
            this.lblLinhas1.Location = new System.Drawing.Point(6, 75);
            this.lblLinhas1.Name = "lblLinhas1";
            this.lblLinhas1.Size = new System.Drawing.Size(82, 25);
            this.lblLinhas1.TabIndex = 8;
            this.lblLinhas1.Text = "Linhas:";
            // 
            // lblColunas1
            // 
            this.lblColunas1.AutoSize = true;
            this.lblColunas1.Location = new System.Drawing.Point(6, 28);
            this.lblColunas1.Name = "lblColunas1";
            this.lblColunas1.Size = new System.Drawing.Size(97, 25);
            this.lblColunas1.TabIndex = 7;
            this.lblColunas1.Text = "Colunas:";
            // 
            // nColunas
            // 
            this.nColunas.Location = new System.Drawing.Point(109, 26);
            this.nColunas.Name = "nColunas";
            this.nColunas.Size = new System.Drawing.Size(49, 31);
            this.nColunas.TabIndex = 7;
            this.nColunas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(514, -21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(808, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "◤◢◤◢◣◥◣ ◢◤◢◣◥◣◥◤◢◤◢◣◥◣◥";
            // 
            // dgvMatriz3
            // 
            this.dgvMatriz3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz3.Location = new System.Drawing.Point(942, 37);
            this.dgvMatriz3.Name = "dgvMatriz3";
            this.dgvMatriz3.Size = new System.Drawing.Size(231, 485);
            this.dgvMatriz3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(2, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(822, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "◣◥◣◥◤◢◤ ◥◣◥◤◢◤ ◢◣◥◣◥◤◢◤◢";
            // 
            // gbOperacoes1
            // 
            this.gbOperacoes1.Controls.Add(this.nkMatriz1);
            this.gbOperacoes1.Controls.Add(this.lblColuna1);
            this.gbOperacoes1.Controls.Add(this.nLinha);
            this.gbOperacoes1.Controls.Add(this.nColuna);
            this.gbOperacoes1.Controls.Add(this.lblLinha1);
            this.gbOperacoes1.Controls.Add(this.btnSomarKMatriz1);
            this.gbOperacoes1.Controls.Add(this.btnSomarMatrizes);
            this.gbOperacoes1.Controls.Add(this.btnMultiplicarMatrizes);
            this.gbOperacoes1.Controls.Add(this.lblk);
            this.gbOperacoes1.Controls.Add(this.btnRemoverValorMatriz1);
            this.gbOperacoes1.Controls.Add(this.lblValorMatriz1);
            this.gbOperacoes1.Controls.Add(this.btnAcessarValorMatriz1);
            this.gbOperacoes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacoes1.Location = new System.Drawing.Point(12, 189);
            this.gbOperacoes1.Name = "gbOperacoes1";
            this.gbOperacoes1.Size = new System.Drawing.Size(450, 185);
            this.gbOperacoes1.TabIndex = 22;
            this.gbOperacoes1.TabStop = false;
            this.gbOperacoes1.Text = "Operações da Matriz 1";
            this.gbOperacoes1.Visible = false;
            // 
            // nkMatriz1
            // 
            this.nkMatriz1.Location = new System.Drawing.Point(39, 105);
            this.nkMatriz1.Name = "nkMatriz1";
            this.nkMatriz1.Size = new System.Drawing.Size(39, 31);
            this.nkMatriz1.TabIndex = 21;
            // 
            // lblColuna1
            // 
            this.lblColuna1.AutoSize = true;
            this.lblColuna1.Location = new System.Drawing.Point(6, 27);
            this.lblColuna1.Name = "lblColuna1";
            this.lblColuna1.Size = new System.Drawing.Size(86, 25);
            this.lblColuna1.TabIndex = 19;
            this.lblColuna1.Text = "Coluna:";
            // 
            // nLinha
            // 
            this.nLinha.Location = new System.Drawing.Point(98, 66);
            this.nLinha.Name = "nLinha";
            this.nLinha.Size = new System.Drawing.Size(49, 31);
            this.nLinha.TabIndex = 16;
            this.nLinha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nColuna
            // 
            this.nColuna.Location = new System.Drawing.Point(98, 25);
            this.nColuna.Name = "nColuna";
            this.nColuna.Size = new System.Drawing.Size(49, 31);
            this.nColuna.TabIndex = 16;
            this.nColuna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLinha1
            // 
            this.lblLinha1.AutoSize = true;
            this.lblLinha1.Location = new System.Drawing.Point(10, 66);
            this.lblLinha1.Name = "lblLinha1";
            this.lblLinha1.Size = new System.Drawing.Size(71, 25);
            this.lblLinha1.TabIndex = 16;
            this.lblLinha1.Text = "Linha:";
            // 
            // btnSomarKMatriz1
            // 
            this.btnSomarKMatriz1.Location = new System.Drawing.Point(84, 100);
            this.btnSomarKMatriz1.Name = "btnSomarKMatriz1";
            this.btnSomarKMatriz1.Size = new System.Drawing.Size(114, 38);
            this.btnSomarKMatriz1.TabIndex = 18;
            this.btnSomarKMatriz1.Text = "Somar k";
            this.btnSomarKMatriz1.UseVisualStyleBackColor = true;
            this.btnSomarKMatriz1.Click += new System.EventHandler(this.btnSomarKMatriz1_Click);
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.Enabled = false;
            this.btnSomarMatrizes.Location = new System.Drawing.Point(6, 139);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(180, 39);
            this.btnSomarMatrizes.TabIndex = 17;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = true;
            this.btnSomarMatrizes.Click += new System.EventHandler(this.btnSomarMatrizes_Click);
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.Enabled = false;
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(192, 139);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(219, 39);
            this.btnMultiplicarMatrizes.TabIndex = 16;
            this.btnMultiplicarMatrizes.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatrizes.Click += new System.EventHandler(this.btnMultiplicarMatrizes_Click);
            // 
            // lblk
            // 
            this.lblk.AutoSize = true;
            this.lblk.Location = new System.Drawing.Point(6, 107);
            this.lblk.Name = "lblk";
            this.lblk.Size = new System.Drawing.Size(29, 25);
            this.lblk.TabIndex = 14;
            this.lblk.Text = "k:";
            // 
            // btnRemoverValorMatriz1
            // 
            this.btnRemoverValorMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverValorMatriz1.Location = new System.Drawing.Point(153, 61);
            this.btnRemoverValorMatriz1.Name = "btnRemoverValorMatriz1";
            this.btnRemoverValorMatriz1.Size = new System.Drawing.Size(150, 37);
            this.btnRemoverValorMatriz1.TabIndex = 12;
            this.btnRemoverValorMatriz1.Text = "Remover Valor";
            this.btnRemoverValorMatriz1.UseVisualStyleBackColor = true;
            this.btnRemoverValorMatriz1.Click += new System.EventHandler(this.btnRemoverValorMatriz1_Click);
            // 
            // lblValorMatriz1
            // 
            this.lblValorMatriz1.AutoSize = true;
            this.lblValorMatriz1.Location = new System.Drawing.Point(323, 68);
            this.lblValorMatriz1.Name = "lblValorMatriz1";
            this.lblValorMatriz1.Size = new System.Drawing.Size(62, 25);
            this.lblValorMatriz1.TabIndex = 11;
            this.lblValorMatriz1.Text = "Valor";
            this.lblValorMatriz1.Visible = false;
            // 
            // btnAcessarValorMatriz1
            // 
            this.btnAcessarValorMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessarValorMatriz1.Location = new System.Drawing.Point(153, 20);
            this.btnAcessarValorMatriz1.Name = "btnAcessarValorMatriz1";
            this.btnAcessarValorMatriz1.Size = new System.Drawing.Size(150, 40);
            this.btnAcessarValorMatriz1.TabIndex = 10;
            this.btnAcessarValorMatriz1.Text = "Acessar Valor";
            this.btnAcessarValorMatriz1.UseVisualStyleBackColor = true;
            this.btnAcessarValorMatriz1.Click += new System.EventHandler(this.btnAcessarValorMatriz1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1193, 572);
            this.Controls.Add(this.gbOperacoes1);
            this.Controls.Add(this.dgvMatriz3);
            this.Controls.Add(this.gBGerarMatriz);
            this.Controls.Add(this.dgvMatriz1);
            this.Controls.Add(this.dgvMatriz2);
            this.Controls.Add(this.gbOperacoes2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Matrizes Esparsas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOperacoes2.ResumeLayout(false);
            this.gbOperacoes2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nkMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLinhaMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColunaMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            this.gBGerarMatriz.ResumeLayout(false);
            this.gBGerarMatriz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz3)).EndInit();
            this.gbOperacoes1.ResumeLayout(false);
            this.gbOperacoes1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nkMatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbOperacoes2;
        private System.Windows.Forms.DataGridView dgvMatriz2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvMatriz1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gBGerarMatriz;
        private System.Windows.Forms.Button btnLerArquivoMatriz1;
        private System.Windows.Forms.Button btnGerarMatriz1;
        private System.Windows.Forms.NumericUpDown nLinhas;
        private System.Windows.Forms.Label lblLinhas1;
        private System.Windows.Forms.Label lblColunas1;
        private System.Windows.Forms.NumericUpDown nColunas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMatriz3;
        private System.Windows.Forms.Label lblLinha2;
        private System.Windows.Forms.Button btnSomarK;
        private System.Windows.Forms.NumericUpDown nLinhaMatriz2;
        private System.Windows.Forms.NumericUpDown nColunaMatriz2;
        private System.Windows.Forms.Label lblColuna2;
        private System.Windows.Forms.NumericUpDown nkMatriz2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLerArquivoMatriz2;
        private System.Windows.Forms.Button btnGerarMatriz2;
        private System.Windows.Forms.GroupBox gbOperacoes1;
        private System.Windows.Forms.NumericUpDown nkMatriz1;
        private System.Windows.Forms.Label lblColuna1;
        private System.Windows.Forms.NumericUpDown nLinha;
        private System.Windows.Forms.NumericUpDown nColuna;
        private System.Windows.Forms.Label lblLinha1;
        private System.Windows.Forms.Button btnSomarKMatriz1;
        private System.Windows.Forms.Button btnSomarMatrizes;
        private System.Windows.Forms.Button btnMultiplicarMatrizes;
        private System.Windows.Forms.Label lblk;
        private System.Windows.Forms.Button btnRemoverValorMatriz1;
        private System.Windows.Forms.Label lblValorMatriz1;
        private System.Windows.Forms.Button btnAcessarValorMatriz1;
        private System.Windows.Forms.Button lMatriz2;
        private System.Windows.Forms.Button lMatriz1;
    }
}

