namespace POS_Test.View
{
    partial class VendaNovoRegistro
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
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.dgvVendaItem = new System.Windows.Forms.DataGridView();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.lblCupomTotalQuantItem = new System.Windows.Forms.Label();
            this.btnCupomExcluirItem = new System.Windows.Forms.Button();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.lblCupomTroco = new System.Windows.Forms.Label();
            this.btnCupomalteraItem = new System.Windows.Forms.Button();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.lblCupomDesconto = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.lblCupomTotalRecebido = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.lblCupomTotal = new System.Windows.Forms.Label();
            this.btnVendaPagar = new System.Windows.Forms.Button();
            this.btnVendaAdicionarProduto = new System.Windows.Forms.Button();
            this.btnCupomComprador = new System.Windows.Forms.Button();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.lblResultadoComprador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaItem)).BeginInit();
            this.groupBox29.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.dgvVendaItem);
            this.groupBox28.Location = new System.Drawing.Point(22, 62);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(427, 260);
            this.groupBox28.TabIndex = 16;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Item Cupom";
            // 
            // dgvVendaItem
            // 
            this.dgvVendaItem.AllowUserToAddRows = false;
            this.dgvVendaItem.AllowUserToDeleteRows = false;
            this.dgvVendaItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendaItem.Location = new System.Drawing.Point(10, 22);
            this.dgvVendaItem.Name = "dgvVendaItem";
            this.dgvVendaItem.ReadOnly = true;
            this.dgvVendaItem.RowHeadersVisible = false;
            this.dgvVendaItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendaItem.Size = new System.Drawing.Size(407, 232);
            this.dgvVendaItem.TabIndex = 6;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.lblCupomTotalQuantItem);
            this.groupBox29.Location = new System.Drawing.Point(478, 256);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(123, 36);
            this.groupBox29.TabIndex = 17;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Total Item";
            // 
            // lblCupomTotalQuantItem
            // 
            this.lblCupomTotalQuantItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCupomTotalQuantItem.Location = new System.Drawing.Point(3, 16);
            this.lblCupomTotalQuantItem.Name = "lblCupomTotalQuantItem";
            this.lblCupomTotalQuantItem.Size = new System.Drawing.Size(117, 17);
            this.lblCupomTotalQuantItem.TabIndex = 0;
            this.lblCupomTotalQuantItem.Text = "{0}";
            this.lblCupomTotalQuantItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCupomExcluirItem
            // 
            this.btnCupomExcluirItem.Location = new System.Drawing.Point(454, 298);
            this.btnCupomExcluirItem.Name = "btnCupomExcluirItem";
            this.btnCupomExcluirItem.Size = new System.Drawing.Size(70, 24);
            this.btnCupomExcluirItem.TabIndex = 10;
            this.btnCupomExcluirItem.Text = "Excluir";
            this.btnCupomExcluirItem.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.lblCupomTroco);
            this.groupBox27.Location = new System.Drawing.Point(481, 209);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(123, 43);
            this.groupBox27.TabIndex = 15;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Troco";
            // 
            // lblCupomTroco
            // 
            this.lblCupomTroco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCupomTroco.Location = new System.Drawing.Point(3, 16);
            this.lblCupomTroco.Name = "lblCupomTroco";
            this.lblCupomTroco.Size = new System.Drawing.Size(117, 24);
            this.lblCupomTroco.TabIndex = 0;
            this.lblCupomTroco.Text = "R$ {0}";
            this.lblCupomTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCupomalteraItem
            // 
            this.btnCupomalteraItem.Location = new System.Drawing.Point(537, 298);
            this.btnCupomalteraItem.Name = "btnCupomalteraItem";
            this.btnCupomalteraItem.Size = new System.Drawing.Size(70, 24);
            this.btnCupomalteraItem.TabIndex = 7;
            this.btnCupomalteraItem.Text = "Alterar";
            this.btnCupomalteraItem.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.lblCupomDesconto);
            this.groupBox26.Location = new System.Drawing.Point(478, 160);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(123, 43);
            this.groupBox26.TabIndex = 13;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Desconto";
            // 
            // lblCupomDesconto
            // 
            this.lblCupomDesconto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCupomDesconto.Location = new System.Drawing.Point(3, 16);
            this.lblCupomDesconto.Name = "lblCupomDesconto";
            this.lblCupomDesconto.Size = new System.Drawing.Size(117, 24);
            this.lblCupomDesconto.TabIndex = 0;
            this.lblCupomDesconto.Text = "R$ {0}";
            this.lblCupomDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.lblCupomTotalRecebido);
            this.groupBox25.Location = new System.Drawing.Point(481, 111);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(123, 43);
            this.groupBox25.TabIndex = 11;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Total Recebido";
            // 
            // lblCupomTotalRecebido
            // 
            this.lblCupomTotalRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCupomTotalRecebido.Location = new System.Drawing.Point(3, 16);
            this.lblCupomTotalRecebido.Name = "lblCupomTotalRecebido";
            this.lblCupomTotalRecebido.Size = new System.Drawing.Size(117, 24);
            this.lblCupomTotalRecebido.TabIndex = 0;
            this.lblCupomTotalRecebido.Text = "R$ {0}";
            this.lblCupomTotalRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.lblCupomTotal);
            this.groupBox24.Location = new System.Drawing.Point(481, 62);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(123, 43);
            this.groupBox24.TabIndex = 8;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Total Cupom";
            // 
            // lblCupomTotal
            // 
            this.lblCupomTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCupomTotal.Location = new System.Drawing.Point(3, 16);
            this.lblCupomTotal.Name = "lblCupomTotal";
            this.lblCupomTotal.Size = new System.Drawing.Size(117, 24);
            this.lblCupomTotal.TabIndex = 0;
            this.lblCupomTotal.Text = "R$ {0}";
            this.lblCupomTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVendaPagar
            // 
            this.btnVendaPagar.Location = new System.Drawing.Point(481, 19);
            this.btnVendaPagar.Name = "btnVendaPagar";
            this.btnVendaPagar.Size = new System.Drawing.Size(100, 37);
            this.btnVendaPagar.TabIndex = 14;
            this.btnVendaPagar.Text = "Pagar";
            this.btnVendaPagar.UseVisualStyleBackColor = true;
            // 
            // btnVendaAdicionarProduto
            // 
            this.btnVendaAdicionarProduto.Location = new System.Drawing.Point(364, 19);
            this.btnVendaAdicionarProduto.Name = "btnVendaAdicionarProduto";
            this.btnVendaAdicionarProduto.Size = new System.Drawing.Size(111, 37);
            this.btnVendaAdicionarProduto.TabIndex = 12;
            this.btnVendaAdicionarProduto.Text = "Adicionar Produto";
            this.btnVendaAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCupomComprador
            // 
            this.btnCupomComprador.Location = new System.Drawing.Point(247, 19);
            this.btnCupomComprador.Name = "btnCupomComprador";
            this.btnCupomComprador.Size = new System.Drawing.Size(111, 37);
            this.btnCupomComprador.TabIndex = 9;
            this.btnCupomComprador.Text = "Adicionar Cliente";
            this.btnCupomComprador.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.lblResultadoComprador);
            this.groupBox23.Location = new System.Drawing.Point(13, 13);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(228, 43);
            this.groupBox23.TabIndex = 6;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Comprador";
            // 
            // lblResultadoComprador
            // 
            this.lblResultadoComprador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoComprador.Location = new System.Drawing.Point(3, 16);
            this.lblResultadoComprador.Name = "lblResultadoComprador";
            this.lblResultadoComprador.Size = new System.Drawing.Size(222, 24);
            this.lblResultadoComprador.TabIndex = 0;
            this.lblResultadoComprador.Text = "Resultado";
            this.lblResultadoComprador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "finalizar venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Grava venda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VendaNovoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox28);
            this.Controls.Add(this.groupBox29);
            this.Controls.Add(this.btnCupomExcluirItem);
            this.Controls.Add(this.groupBox27);
            this.Controls.Add(this.btnCupomalteraItem);
            this.Controls.Add(this.groupBox26);
            this.Controls.Add(this.groupBox25);
            this.Controls.Add(this.groupBox24);
            this.Controls.Add(this.btnVendaPagar);
            this.Controls.Add(this.btnVendaAdicionarProduto);
            this.Controls.Add(this.btnCupomComprador);
            this.Controls.Add(this.groupBox23);
            this.Name = "VendaNovoRegistro";
            this.Size = new System.Drawing.Size(697, 482);
            this.groupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaItem)).EndInit();
            this.groupBox29.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.DataGridView dgvVendaItem;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Label lblCupomTotalQuantItem;
        private System.Windows.Forms.Button btnCupomExcluirItem;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Label lblCupomTroco;
        private System.Windows.Forms.Button btnCupomalteraItem;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Label lblCupomDesconto;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label lblCupomTotalRecebido;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Label lblCupomTotal;
        private System.Windows.Forms.Button btnVendaPagar;
        private System.Windows.Forms.Button btnVendaAdicionarProduto;
        private System.Windows.Forms.Button btnCupomComprador;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Label lblResultadoComprador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
