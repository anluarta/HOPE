namespace POS_Test.View
{
    partial class CupomPagar
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
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.cmbTipoRecebimento = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAplicadesconto = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecebido);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor Recebido";
            // 
            // txtRecebido
            // 
            this.txtRecebido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRecebido.Location = new System.Drawing.Point(3, 16);
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(194, 20);
            this.txtRecebido.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAplicadesconto);
            this.groupBox2.Controls.Add(this.txtDesconto);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDesconto.Location = new System.Drawing.Point(3, 16);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(194, 20);
            this.txtDesconto.TabIndex = 0;
            // 
            // cmbTipoRecebimento
            // 
            this.cmbTipoRecebimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbTipoRecebimento.FormattingEnabled = true;
            this.cmbTipoRecebimento.Location = new System.Drawing.Point(3, 16);
            this.cmbTipoRecebimento.Name = "cmbTipoRecebimento";
            this.cmbTipoRecebimento.Size = new System.Drawing.Size(194, 21);
            this.cmbTipoRecebimento.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTipoRecebimento);
            this.groupBox3.Location = new System.Drawing.Point(3, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 52);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Recebimento";
            // 
            // btnAplicadesconto
            // 
            this.btnAplicadesconto.Location = new System.Drawing.Point(203, 16);
            this.btnAplicadesconto.Name = "btnAplicadesconto";
            this.btnAplicadesconto.Size = new System.Drawing.Size(75, 23);
            this.btnAplicadesconto.TabIndex = 1;
            this.btnAplicadesconto.Text = "Aplicar";
            this.btnAplicadesconto.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 213);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Receber Valor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gravar Pagamaneto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CupomPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CupomPagar";
            this.Size = new System.Drawing.Size(532, 333);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox cmbTipoRecebimento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAplicadesconto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
