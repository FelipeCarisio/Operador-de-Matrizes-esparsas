namespace _18181_18185_Projeto1ED
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSomaMatriz = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.dgvDois = new System.Windows.Forms.DataGridView();
            this.dgvUm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttColuna = new System.Windows.Forms.ToolTip(this.components);
            this.ttValor = new System.Windows.Forms.ToolTip(this.components);
            this.ttLinha = new System.Windows.Forms.ToolTip(this.components);
            this.ttAdd = new System.Windows.Forms.ToolTip(this.components);
            this.ttCriar = new System.Windows.Forms.ToolTip(this.components);
            this.ttRemover = new System.Windows.Forms.ToolTip(this.components);
            this.ttLer = new System.Windows.Forms.ToolTip(this.components);
            this.ttGet = new System.Windows.Forms.ToolTip(this.components);
            this.ttSoma = new System.Windows.Forms.ToolTip(this.components);
            this.ttAcionarConst = new System.Windows.Forms.ToolTip(this.components);
            this.ttDelete = new System.Windows.Forms.ToolTip(this.components);
            this.ttMultiplicar = new System.Windows.Forms.ToolTip(this.components);
            this.ofdLeitura = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(227, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "inserir";
            this.ttAdd.SetToolTip(this.btnAdd, "Adicione um valor em um local específico da matriz.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(227, 61);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "remover";
            this.ttRemover.SetToolTip(this.btnRemover, "Remove um item de uma posição específica da matriz.");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(308, 32);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "novo";
            this.ttCriar.SetToolTip(this.btnCriar, "Crie uma nova matriz.");
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(308, 61);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "ler";
            this.ttLer.SetToolTip(this.btnRead, "Leia uma matriz de um arquivo.");
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(227, 90);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "buscar";
            this.ttGet.SetToolTip(this.btnReturn, "retorna um valor de uma posição especificada.");
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSomaMatriz
            // 
            this.btnSomaMatriz.Enabled = false;
            this.btnSomaMatriz.Location = new System.Drawing.Point(389, 61);
            this.btnSomaMatriz.Name = "btnSomaMatriz";
            this.btnSomaMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnSomaMatriz.TabIndex = 9;
            this.btnSomaMatriz.Text = "somar";
            this.ttSoma.SetToolTip(this.btnSomaMatriz, "Soma duas matrizes e exibe o resultado.");
            this.btnSomaMatriz.UseVisualStyleBackColor = true;
            this.btnSomaMatriz.Click += new System.EventHandler(this.btnSomaMatriz_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(109, 119);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.Enabled = false;
            this.btnDeleta.Location = new System.Drawing.Point(308, 90);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(75, 23);
            this.btnDeleta.TabIndex = 7;
            this.btnDeleta.Text = "deletar";
            this.ttDelete.SetToolTip(this.btnDeleta, "Deleta a matriz atual.");
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.Location = new System.Drawing.Point(389, 90);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "multiplicar";
            this.ttMultiplicar.SetToolTip(this.btnMultiplicar, "Multiplica as duas matrizes.");
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Enabled = false;
            this.btnAddAll.Location = new System.Drawing.Point(389, 32);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 5;
            this.btnAddAll.Text = "somar K";
            this.ttAcionarConst.SetToolTip(this.btnAddAll, "Adiciona um valor em todos valores de uma coluna da matriz.");
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtLinha
            // 
            this.txtLinha.Enabled = false;
            this.txtLinha.Location = new System.Drawing.Point(12, 34);
            this.txtLinha.MaxLength = 5;
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(190, 20);
            this.txtLinha.TabIndex = 11;
            this.ttLinha.SetToolTip(this.txtLinha, "Digite aqui o índice da linha.");
            this.txtLinha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColuna_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(12, 93);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(190, 20);
            this.txtValor.TabIndex = 12;
            this.ttValor.SetToolTip(this.txtValor, "Digite aqui o valor.");
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtColuna
            // 
            this.txtColuna.Enabled = false;
            this.txtColuna.Location = new System.Drawing.Point(12, 64);
            this.txtColuna.MaxLength = 5;
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(190, 20);
            this.txtColuna.TabIndex = 13;
            this.ttColuna.SetToolTip(this.txtColuna, "Digite aqui o índice da linha.");
            this.txtColuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColuna_KeyPress);
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Location = new System.Drawing.Point(593, 61);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.Size = new System.Drawing.Size(338, 354);
            this.DgvResult.TabIndex = 14;
            this.DgvResult.Visible = false;
            // 
            // dgvDois
            // 
            this.dgvDois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDois.Location = new System.Drawing.Point(276, 198);
            this.dgvDois.Name = "dgvDois";
            this.dgvDois.Size = new System.Drawing.Size(240, 217);
            this.dgvDois.TabIndex = 15;
            this.dgvDois.Visible = false;
            // 
            // dgvUm
            // 
            this.dgvUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUm.Location = new System.Drawing.Point(12, 198);
            this.dgvUm.Name = "dgvUm";
            this.dgvUm.Size = new System.Drawing.Size(240, 217);
            this.dgvUm.TabIndex = 16;
            this.dgvUm.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Resultado:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Matriz 2:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Matriz1:";
            this.label3.Visible = false;
            // 
            // ttColuna
            // 
            this.ttColuna.Tag = "";
            this.ttColuna.ToolTipTitle = "coluna da matriz";
            // 
            // ofdLeitura
            // 
            this.ofdLeitura.DefaultExt = "txt";
            this.ofdLeitura.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUm);
            this.Controls.Add(this.dgvDois);
            this.Controls.Add(this.DgvResult);
            this.Controls.Add(this.txtColuna);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSomaMatriz);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSomaMatriz;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.DataGridView dgvDois;
        private System.Windows.Forms.DataGridView dgvUm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ttColuna;
        private System.Windows.Forms.ToolTip ttValor;
        private System.Windows.Forms.ToolTip ttLinha;
        private System.Windows.Forms.ToolTip ttAdd;
        private System.Windows.Forms.ToolTip ttCriar;
        private System.Windows.Forms.ToolTip ttRemover;
        private System.Windows.Forms.ToolTip ttLer;
        private System.Windows.Forms.ToolTip ttGet;
        private System.Windows.Forms.ToolTip ttSoma;
        private System.Windows.Forms.ToolTip ttDelete;
        private System.Windows.Forms.ToolTip ttAcionarConst;
        private System.Windows.Forms.ToolTip ttMultiplicar;
        private System.Windows.Forms.OpenFileDialog ofdLeitura;
    }
}

