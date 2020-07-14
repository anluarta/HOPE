namespace POS_Test.View
{
    partial class CupomProduto
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
            this.components = new System.ComponentModel.Container();
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btnCadasraProduto = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.txtTermoCultaProd = new System.Windows.Forms.TextBox();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.cmbLocalConsultaProd = new System.Windows.Forms.ComboBox();
            this.btnFiltraProduto = new System.Windows.Forms.Button();
            this.cmbOperacaConsultaProd = new System.Windows.Forms.ComboBox();
            this.cmbOrdenConsultaprod = new System.Windows.Forms.ComboBox();
            this.iProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.AllowUserToAddRows = false;
            this.dgvListaProduto.AllowUserToDeleteRows = false;
            this.dgvListaProduto.AutoGenerateColumns = false;
            this.dgvListaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdutoDataGridViewTextBoxColumn,
            this.eANDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.custoDataGridViewTextBoxColumn,
            this.vendaDataGridViewTextBoxColumn});
            this.dgvListaProduto.DataSource = this.iProdutoBindingSource;
            this.dgvListaProduto.Location = new System.Drawing.Point(3, 115);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.ReadOnly = true;
            this.dgvListaProduto.RowHeadersVisible = false;
            this.dgvListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProduto.Size = new System.Drawing.Size(611, 172);
            this.dgvListaProduto.TabIndex = 16;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.btnCadasraProduto);
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.btnAlterarProduto);
            this.groupBox17.Controls.Add(this.cmbLocalConsultaProd);
            this.groupBox17.Controls.Add(this.btnFiltraProduto);
            this.groupBox17.Controls.Add(this.cmbOperacaConsultaProd);
            this.groupBox17.Controls.Add(this.cmbOrdenConsultaprod);
            this.groupBox17.Location = new System.Drawing.Point(3, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(611, 106);
            this.groupBox17.TabIndex = 15;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Filtrar";
            // 
            // btnCadasraProduto
            // 
            this.btnCadasraProduto.Location = new System.Drawing.Point(470, 16);
            this.btnCadasraProduto.Name = "btnCadasraProduto";
            this.btnCadasraProduto.Size = new System.Drawing.Size(135, 22);
            this.btnCadasraProduto.TabIndex = 14;
            this.btnCadasraProduto.Text = "Cadastra Iten";
            this.btnCadasraProduto.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.txtTermoCultaProd);
            this.groupBox18.Location = new System.Drawing.Point(6, 46);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(458, 48);
            this.groupBox18.TabIndex = 4;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Termo";
            // 
            // txtTermoCultaProd
            // 
            this.txtTermoCultaProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTermoCultaProd.Location = new System.Drawing.Point(3, 16);
            this.txtTermoCultaProd.Name = "txtTermoCultaProd";
            this.txtTermoCultaProd.Size = new System.Drawing.Size(452, 20);
            this.txtTermoCultaProd.TabIndex = 0;
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Location = new System.Drawing.Point(470, 46);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(135, 54);
            this.btnAlterarProduto.TabIndex = 13;
            this.btnAlterarProduto.Text = "Adionar Iten Selecionado";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // cmbLocalConsultaProd
            // 
            this.cmbLocalConsultaProd.FormattingEnabled = true;
            this.cmbLocalConsultaProd.Location = new System.Drawing.Point(261, 19);
            this.cmbLocalConsultaProd.Name = "cmbLocalConsultaProd";
            this.cmbLocalConsultaProd.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalConsultaProd.TabIndex = 3;
            this.cmbLocalConsultaProd.Text = "Local";
            // 
            // btnFiltraProduto
            // 
            this.btnFiltraProduto.Location = new System.Drawing.Point(388, 18);
            this.btnFiltraProduto.Name = "btnFiltraProduto";
            this.btnFiltraProduto.Size = new System.Drawing.Size(76, 22);
            this.btnFiltraProduto.TabIndex = 2;
            this.btnFiltraProduto.Text = "Filtrar";
            this.btnFiltraProduto.UseVisualStyleBackColor = true;
            // 
            // cmbOperacaConsultaProd
            // 
            this.cmbOperacaConsultaProd.FormattingEnabled = true;
            this.cmbOperacaConsultaProd.Location = new System.Drawing.Point(131, 18);
            this.cmbOperacaConsultaProd.Name = "cmbOperacaConsultaProd";
            this.cmbOperacaConsultaProd.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacaConsultaProd.TabIndex = 1;
            this.cmbOperacaConsultaProd.Text = "Operacao";
            // 
            // cmbOrdenConsultaprod
            // 
            this.cmbOrdenConsultaprod.FormattingEnabled = true;
            this.cmbOrdenConsultaprod.Location = new System.Drawing.Point(6, 19);
            this.cmbOrdenConsultaprod.Name = "cmbOrdenConsultaprod";
            this.cmbOrdenConsultaprod.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenConsultaprod.TabIndex = 0;
            this.cmbOrdenConsultaprod.Text = "Ordenar Por";
            // 
            // iProdutoBindingSource
            // 
            this.iProdutoBindingSource.DataSource = typeof(Hope.Entidade.IProduto);
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            this.iDProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoDataGridViewTextBoxColumn
            // 
            this.custoDataGridViewTextBoxColumn.DataPropertyName = "Custo";
            this.custoDataGridViewTextBoxColumn.HeaderText = "Custo";
            this.custoDataGridViewTextBoxColumn.Name = "custoDataGridViewTextBoxColumn";
            this.custoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendaDataGridViewTextBoxColumn
            // 
            this.vendaDataGridViewTextBoxColumn.DataPropertyName = "Venda";
            this.vendaDataGridViewTextBoxColumn.HeaderText = "Venda";
            this.vendaDataGridViewTextBoxColumn.Name = "vendaDataGridViewTextBoxColumn";
            this.vendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CupomProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvListaProduto);
            this.Controls.Add(this.groupBox17);
            this.Name = "CupomProduto";
            this.Size = new System.Drawing.Size(624, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button btnCadasraProduto;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox txtTermoCultaProd;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.ComboBox cmbLocalConsultaProd;
        private System.Windows.Forms.Button btnFiltraProduto;
        private System.Windows.Forms.ComboBox cmbOperacaConsultaProd;
        private System.Windows.Forms.ComboBox cmbOrdenConsultaprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iProdutoBindingSource;
    }
}
