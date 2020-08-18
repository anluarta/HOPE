namespace TesteHope.View
{
    partial class VendaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendaLista));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVisualizarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnCarregarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnDevolucao = new System.Windows.Forms.ToolStripButton();
            this.btnfechar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.getIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getIDCaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTotalItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorRecebidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorTrocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVendereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVendereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.iVendereBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnVisualizarRegistro,
            this.btnCarregarRegistro,
            this.btnDevolucao,
            this.btnfechar});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(847, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // btnVisualizarRegistro
            // 
            this.btnVisualizarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnVisualizarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarRegistro.Image")));
            this.btnVisualizarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizarRegistro.Name = "btnVisualizarRegistro";
            this.btnVisualizarRegistro.Size = new System.Drawing.Size(112, 22);
            this.btnVisualizarRegistro.Text = "Visualizar Regisatro";
            this.btnVisualizarRegistro.Click += new System.EventHandler(this.btnVisualizarRegistro_Click);
            // 
            // btnCarregarRegistro
            // 
            this.btnCarregarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCarregarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarRegistro.Image")));
            this.btnCarregarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarregarRegistro.Name = "btnCarregarRegistro";
            this.btnCarregarRegistro.Size = new System.Drawing.Size(102, 22);
            this.btnCarregarRegistro.Text = "Carregar Registro";
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucao.Image")));
            this.btnDevolucao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(67, 22);
            this.btnDevolucao.Text = "Devolucao";
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(46, 22);
            this.btnfechar.Text = "Fechar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getIDDataGridViewTextBoxColumn,
            this.getIDCaixaDataGridViewTextBoxColumn,
            this.getTotalItemDataGridViewTextBoxColumn,
            this.getValorTotalDataGridViewTextBoxColumn,
            this.getValorRecebidoDataGridViewTextBoxColumn,
            this.getValorDescontoDataGridViewTextBoxColumn,
            this.getValorTrocoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iVendereBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(847, 451);
            this.dataGridView1.TabIndex = 1;
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
            // getIDDataGridViewTextBoxColumn
            // 
            this.getIDDataGridViewTextBoxColumn.DataPropertyName = "Get_ID";
            this.getIDDataGridViewTextBoxColumn.HeaderText = "Get_ID";
            this.getIDDataGridViewTextBoxColumn.Name = "getIDDataGridViewTextBoxColumn";
            this.getIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getIDCaixaDataGridViewTextBoxColumn
            // 
            this.getIDCaixaDataGridViewTextBoxColumn.DataPropertyName = "Get_ID_Caixa";
            this.getIDCaixaDataGridViewTextBoxColumn.HeaderText = "Get_ID_Caixa";
            this.getIDCaixaDataGridViewTextBoxColumn.Name = "getIDCaixaDataGridViewTextBoxColumn";
            this.getIDCaixaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getTotalItemDataGridViewTextBoxColumn
            // 
            this.getTotalItemDataGridViewTextBoxColumn.DataPropertyName = "Get_Total_Item";
            this.getTotalItemDataGridViewTextBoxColumn.HeaderText = "Get_Total_Item";
            this.getTotalItemDataGridViewTextBoxColumn.Name = "getTotalItemDataGridViewTextBoxColumn";
            this.getTotalItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getValorTotalDataGridViewTextBoxColumn
            // 
            this.getValorTotalDataGridViewTextBoxColumn.DataPropertyName = "Get_Valor_Total";
            this.getValorTotalDataGridViewTextBoxColumn.HeaderText = "Get_Valor_Total";
            this.getValorTotalDataGridViewTextBoxColumn.Name = "getValorTotalDataGridViewTextBoxColumn";
            this.getValorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getValorRecebidoDataGridViewTextBoxColumn
            // 
            this.getValorRecebidoDataGridViewTextBoxColumn.DataPropertyName = "Get_Valor_Recebido";
            this.getValorRecebidoDataGridViewTextBoxColumn.HeaderText = "Get_Valor_Recebido";
            this.getValorRecebidoDataGridViewTextBoxColumn.Name = "getValorRecebidoDataGridViewTextBoxColumn";
            this.getValorRecebidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getValorDescontoDataGridViewTextBoxColumn
            // 
            this.getValorDescontoDataGridViewTextBoxColumn.DataPropertyName = "Get_Valor_Desconto";
            this.getValorDescontoDataGridViewTextBoxColumn.HeaderText = "Get_Valor_Desconto";
            this.getValorDescontoDataGridViewTextBoxColumn.Name = "getValorDescontoDataGridViewTextBoxColumn";
            this.getValorDescontoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getValorTrocoDataGridViewTextBoxColumn
            // 
            this.getValorTrocoDataGridViewTextBoxColumn.DataPropertyName = "Get_Valor_Troco";
            this.getValorTrocoDataGridViewTextBoxColumn.HeaderText = "Get_Valor_Troco";
            this.getValorTrocoDataGridViewTextBoxColumn.Name = "getValorTrocoDataGridViewTextBoxColumn";
            this.getValorTrocoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iVendereBindingSource
            // 
            this.iVendereBindingSource.DataSource = typeof(Hope.Interface.IVender_e);
            // 
            // VendaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "VendaLista";
            this.Size = new System.Drawing.Size(847, 476);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVendereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnVisualizarRegistro;
        public System.Windows.Forms.ToolStripButton btnfechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn getIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getIDCaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTotalItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getValorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getValorRecebidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getValorDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getValorTrocoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton btnDevolucao;
        internal System.Windows.Forms.BindingSource iVendereBindingSource;
        internal System.Windows.Forms.ToolStripButton btnCarregarRegistro;
    }
}
