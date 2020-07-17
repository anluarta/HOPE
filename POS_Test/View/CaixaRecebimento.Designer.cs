namespace POS_Test.View
{
    partial class CaixaRecebimento
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
            this.lblRecebimentoRes = new System.Windows.Forms.Label();
            this.cmbRecebimento = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRecebidoREs = new System.Windows.Forms.Label();
            this.txtRecebidoValor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFormaRes = new System.Windows.Forms.Label();
            this.cmbFormaRcebimento = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbColunaConsultaCliente = new System.Windows.Forms.ComboBox();
            this.lblClienteRes = new System.Windows.Forms.Label();
            this.btnLocalizarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecebimentoRes);
            this.groupBox1.Controls.Add(this.cmbRecebimento);
            this.groupBox1.Location = new System.Drawing.Point(48, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recebimento";
            // 
            // lblRecebimentoRes
            // 
            this.lblRecebimentoRes.AutoSize = true;
            this.lblRecebimentoRes.Location = new System.Drawing.Point(6, 43);
            this.lblRecebimentoRes.Name = "lblRecebimentoRes";
            this.lblRecebimentoRes.Size = new System.Drawing.Size(50, 13);
            this.lblRecebimentoRes.TabIndex = 3;
            this.lblRecebimentoRes.Text = "resultado";
            // 
            // cmbRecebimento
            // 
            this.cmbRecebimento.FormattingEnabled = true;
            this.cmbRecebimento.Location = new System.Drawing.Point(6, 19);
            this.cmbRecebimento.Name = "cmbRecebimento";
            this.cmbRecebimento.Size = new System.Drawing.Size(121, 21);
            this.cmbRecebimento.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRecebidoREs);
            this.groupBox2.Controls.Add(this.txtRecebidoValor);
            this.groupBox2.Location = new System.Drawing.Point(65, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Recebido";
            // 
            // lblRecebidoREs
            // 
            this.lblRecebidoREs.AutoSize = true;
            this.lblRecebidoREs.Location = new System.Drawing.Point(6, 42);
            this.lblRecebidoREs.Name = "lblRecebidoREs";
            this.lblRecebidoREs.Size = new System.Drawing.Size(50, 13);
            this.lblRecebidoREs.TabIndex = 3;
            this.lblRecebidoREs.Text = "resultado";
            // 
            // txtRecebidoValor
            // 
            this.txtRecebidoValor.Location = new System.Drawing.Point(6, 19);
            this.txtRecebidoValor.Name = "txtRecebidoValor";
            this.txtRecebidoValor.Size = new System.Drawing.Size(100, 20);
            this.txtRecebidoValor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFormaRes);
            this.groupBox3.Controls.Add(this.cmbFormaRcebimento);
            this.groupBox3.Location = new System.Drawing.Point(271, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 75);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma Recebida";
            // 
            // lblFormaRes
            // 
            this.lblFormaRes.AutoSize = true;
            this.lblFormaRes.Location = new System.Drawing.Point(11, 43);
            this.lblFormaRes.Name = "lblFormaRes";
            this.lblFormaRes.Size = new System.Drawing.Size(50, 13);
            this.lblFormaRes.TabIndex = 3;
            this.lblFormaRes.Text = "resultado";
            // 
            // cmbFormaRcebimento
            // 
            this.cmbFormaRcebimento.FormattingEnabled = true;
            this.cmbFormaRcebimento.Location = new System.Drawing.Point(14, 19);
            this.cmbFormaRcebimento.Name = "cmbFormaRcebimento";
            this.cmbFormaRcebimento.Size = new System.Drawing.Size(121, 21);
            this.cmbFormaRcebimento.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbColunaConsultaCliente);
            this.groupBox4.Controls.Add(this.lblClienteRes);
            this.groupBox4.Controls.Add(this.btnLocalizarCliente);
            this.groupBox4.Controls.Add(this.txtCliente);
            this.groupBox4.Location = new System.Drawing.Point(48, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 88);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // cmbColunaConsultaCliente
            // 
            this.cmbColunaConsultaCliente.FormattingEnabled = true;
            this.cmbColunaConsultaCliente.Location = new System.Drawing.Point(6, 16);
            this.cmbColunaConsultaCliente.Name = "cmbColunaConsultaCliente";
            this.cmbColunaConsultaCliente.Size = new System.Drawing.Size(105, 21);
            this.cmbColunaConsultaCliente.TabIndex = 3;
            this.cmbColunaConsultaCliente.Text = "Coluna";
            // 
            // lblClienteRes
            // 
            this.lblClienteRes.AutoSize = true;
            this.lblClienteRes.Location = new System.Drawing.Point(6, 50);
            this.lblClienteRes.Name = "lblClienteRes";
            this.lblClienteRes.Size = new System.Drawing.Size(50, 13);
            this.lblClienteRes.TabIndex = 2;
            this.lblClienteRes.Text = "resultado";
            // 
            // btnLocalizarCliente
            // 
            this.btnLocalizarCliente.Location = new System.Drawing.Point(237, 16);
            this.btnLocalizarCliente.Name = "btnLocalizarCliente";
            this.btnLocalizarCliente.Size = new System.Drawing.Size(154, 23);
            this.btnLocalizarCliente.TabIndex = 1;
            this.btnLocalizarCliente.Text = "Localizar Conta Cliente";
            this.btnLocalizarCliente.UseVisualStyleBackColor = true;
            this.btnLocalizarCliente.Click += new System.EventHandler(this.btnLocalizarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(117, 16);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(383, 25);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 66);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(280, 25);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(97, 66);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // CaixaRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CaixaRecebimento";
            this.Size = new System.Drawing.Size(517, 348);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRecebimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecebidoValor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFormaRcebimento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblClienteRes;
        private System.Windows.Forms.Button btnLocalizarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox cmbColunaConsultaCliente;
        private System.Windows.Forms.Label lblRecebimentoRes;
        private System.Windows.Forms.Label lblRecebidoREs;
        private System.Windows.Forms.Label lblFormaRes;
        public System.Windows.Forms.Button btnVoltar;
    }
}
