namespace TesteHope.View
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.btnfechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblFinalizado = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblIdCaixa = new System.Windows.Forms.Label();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.getDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getQuantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSubTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getUnidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iItemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorItem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnItemAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnItemEditar = new System.Windows.Forms.ToolStripButton();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnFecharVenda = new System.Windows.Forms.Button();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iItemeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorItem)).BeginInit();
            this.bindingNavigatorItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(644, 3);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTroco);
            this.groupBox1.Controls.Add(this.lblFinalizado);
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.lblIdCaixa);
            this.groupBox1.Controls.Add(this.lblRecebido);
            this.groupBox1.Controls.Add(this.lblColaborador);
            this.groupBox1.Controls.Add(this.lblIndex);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecalho";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(477, 55);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(52, 13);
            this.lblTroco.TabIndex = 9;
            this.lblTroco.Text = "Troco {0}";
            // 
            // lblFinalizado
            // 
            this.lblFinalizado.AutoSize = true;
            this.lblFinalizado.Location = new System.Drawing.Point(223, 41);
            this.lblFinalizado.Name = "lblFinalizado";
            this.lblFinalizado.Size = new System.Drawing.Size(71, 13);
            this.lblFinalizado.TabIndex = 3;
            this.lblFinalizado.Text = "Finalizado {0}";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(477, 42);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 8;
            this.lblDesconto.Text = "Desconto {0}";
            // 
            // lblIdCaixa
            // 
            this.lblIdCaixa.AutoSize = true;
            this.lblIdCaixa.Location = new System.Drawing.Point(102, 16);
            this.lblIdCaixa.Name = "lblIdCaixa";
            this.lblIdCaixa.Size = new System.Drawing.Size(64, 13);
            this.lblIdCaixa.TabIndex = 2;
            this.lblIdCaixa.Text = "ID Caixa {0}";
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Location = new System.Drawing.Point(477, 29);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(70, 13);
            this.lblRecebido.TabIndex = 4;
            this.lblRecebido.Text = "Recebido {0}";
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Location = new System.Drawing.Point(6, 41);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(81, 13);
            this.lblColaborador.TabIndex = 1;
            this.lblColaborador.Text = "Colaborador {0}";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(6, 16);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(50, 13);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Index {0}";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AutoGenerateColumns = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getDescricaoDataGridViewTextBoxColumn,
            this.getQuantidadeDataGridViewTextBoxColumn,
            this.getSubTotalDataGridViewTextBoxColumn,
            this.getUnidadeDataGridViewTextBoxColumn,
            this.getVendaDataGridViewTextBoxColumn});
            this.dgvItem.DataSource = this.iItemeBindingSource;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.Location = new System.Drawing.Point(3, 41);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(372, 221);
            this.dgvItem.TabIndex = 2;
            // 
            // getDescricaoDataGridViewTextBoxColumn
            // 
            this.getDescricaoDataGridViewTextBoxColumn.DataPropertyName = "Get_Descricao";
            this.getDescricaoDataGridViewTextBoxColumn.HeaderText = "Get_Descricao";
            this.getDescricaoDataGridViewTextBoxColumn.Name = "getDescricaoDataGridViewTextBoxColumn";
            this.getDescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getQuantidadeDataGridViewTextBoxColumn
            // 
            this.getQuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Get_Quantidade";
            this.getQuantidadeDataGridViewTextBoxColumn.HeaderText = "Get_Quantidade";
            this.getQuantidadeDataGridViewTextBoxColumn.Name = "getQuantidadeDataGridViewTextBoxColumn";
            this.getQuantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getSubTotalDataGridViewTextBoxColumn
            // 
            this.getSubTotalDataGridViewTextBoxColumn.DataPropertyName = "Get_Sub_Total";
            this.getSubTotalDataGridViewTextBoxColumn.HeaderText = "Get_Sub_Total";
            this.getSubTotalDataGridViewTextBoxColumn.Name = "getSubTotalDataGridViewTextBoxColumn";
            this.getSubTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getUnidadeDataGridViewTextBoxColumn
            // 
            this.getUnidadeDataGridViewTextBoxColumn.DataPropertyName = "Get_Unidade";
            this.getUnidadeDataGridViewTextBoxColumn.HeaderText = "Get_Unidade";
            this.getUnidadeDataGridViewTextBoxColumn.Name = "getUnidadeDataGridViewTextBoxColumn";
            this.getUnidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getVendaDataGridViewTextBoxColumn
            // 
            this.getVendaDataGridViewTextBoxColumn.DataPropertyName = "Get_Venda";
            this.getVendaDataGridViewTextBoxColumn.HeaderText = "Get_Venda";
            this.getVendaDataGridViewTextBoxColumn.Name = "getVendaDataGridViewTextBoxColumn";
            this.getVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iItemeBindingSource
            // 
            this.iItemeBindingSource.DataSource = typeof(Hope.Interface.IItem_e);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItem);
            this.groupBox2.Controls.Add(this.bindingNavigatorItem);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 265);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Items";
            // 
            // bindingNavigatorItem
            // 
            this.bindingNavigatorItem.AddNewItem = null;
            this.bindingNavigatorItem.BindingSource = this.iItemeBindingSource;
            this.bindingNavigatorItem.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorItem.DeleteItem = null;
            this.bindingNavigatorItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnItemAdicionar,
            this.btnItemEditar});
            this.bindingNavigatorItem.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorItem.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorItem.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorItem.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorItem.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorItem.Name = "bindingNavigatorItem";
            this.bindingNavigatorItem.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorItem.Size = new System.Drawing.Size(372, 25);
            this.bindingNavigatorItem.TabIndex = 0;
            this.bindingNavigatorItem.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnItemAdicionar
            // 
            this.btnItemAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItemAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdicionar.Image")));
            this.btnItemAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemAdicionar.Name = "btnItemAdicionar";
            this.btnItemAdicionar.Size = new System.Drawing.Size(62, 22);
            this.btnItemAdicionar.Text = "Adicionar";
            this.btnItemAdicionar.Click += new System.EventHandler(this.btnItemAdicionar_Click);
            // 
            // btnItemEditar
            // 
            this.btnItemEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItemEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnItemEditar.Image")));
            this.btnItemEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemEditar.Name = "btnItemEditar";
            this.btnItemEditar.Size = new System.Drawing.Size(41, 22);
            this.btnItemEditar.Text = "Editar";
            this.btnItemEditar.Click += new System.EventHandler(this.btnItemEditar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(644, 58);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 61);
            this.btngravar.TabIndex = 4;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(437, 211);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(242, 61);
            this.btnPagamento.TabIndex = 6;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnFecharVenda
            // 
            this.btnFecharVenda.Location = new System.Drawing.Point(437, 278);
            this.btnFecharVenda.Name = "btnFecharVenda";
            this.btnFecharVenda.Size = new System.Drawing.Size(242, 61);
            this.btnFecharVenda.TabIndex = 7;
            this.btnFecharVenda.Text = "Finalizar Venda";
            this.btnFecharVenda.UseVisualStyleBackColor = true;
            this.btnFecharVenda.Click += new System.EventHandler(this.btnFecharVenda_Click);
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(478, 165);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(160, 25);
            this.lblTotalVenda.TabIndex = 4;
            this.lblTotalVenda.Text = "Total Venda {0}";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(396, 367);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(10, 13);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "-";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(644, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 20);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.btnFecharVenda);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnfechar);
            this.Name = "Vender";
            this.Size = new System.Drawing.Size(722, 402);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iItemeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorItem)).EndInit();
            this.bindingNavigatorItem.ResumeLayout(false);
            this.bindingNavigatorItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFinalizado;
        private System.Windows.Forms.Label lblIdCaixa;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.BindingSource iItemeBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.Button btngravar;
        public System.Windows.Forms.Button btnPagamento;
        public System.Windows.Forms.Button btnFecharVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.ToolStripButton btnItemAdicionar;
        private System.Windows.Forms.ToolStripButton btnItemEditar;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.DataGridViewTextBoxColumn getDescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getQuantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getSubTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getUnidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblresultado;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
