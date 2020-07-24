namespace POS_Test.View
{
    partial class ProdutoNovo
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtxEAN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.numVenda = new System.Windows.Forms.NumericUpDown();
            this.numCusto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxEAN);
            this.groupBox1.Location = new System.Drawing.Point(35, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EAN";
            // 
            // txtxEAN
            // 
            this.txtxEAN.Location = new System.Drawing.Point(6, 19);
            this.txtxEAN.Name = "txtxEAN";
            this.txtxEAN.Size = new System.Drawing.Size(100, 20);
            this.txtxEAN.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Location = new System.Drawing.Point(41, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descricao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 19);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(248, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numCusto);
            this.groupBox3.Location = new System.Drawing.Point(41, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numVenda);
            this.groupBox4.Location = new System.Drawing.Point(180, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Venda";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbUnidade);
            this.groupBox5.Location = new System.Drawing.Point(204, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Unidade";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(3, 16);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(109, 21);
            this.cmbUnidade.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(384, 29);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(163, 88);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(384, 123);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(163, 88);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // numVenda
            // 
            this.numVenda.DecimalPlaces = 3;
            this.numVenda.Location = new System.Drawing.Point(6, 19);
            this.numVenda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numVenda.Name = "numVenda";
            this.numVenda.Size = new System.Drawing.Size(103, 20);
            this.numVenda.TabIndex = 7;
            this.numVenda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCusto
            // 
            this.numCusto.DecimalPlaces = 3;
            this.numCusto.Location = new System.Drawing.Point(6, 19);
            this.numCusto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numCusto.Name = "numCusto";
            this.numCusto.Size = new System.Drawing.Size(103, 20);
            this.numCusto.TabIndex = 8;
            this.numCusto.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // ProdutoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProdutoNovo";
            this.Size = new System.Drawing.Size(591, 259);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtxEAN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.NumericUpDown numCusto;
        private System.Windows.Forms.NumericUpDown numVenda;
    }
}
