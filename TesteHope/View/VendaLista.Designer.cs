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
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnfechar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iVendereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getIDCaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTotalItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorRecebidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getValorTrocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripButton1,
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "toolStripButton1";
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
            this.getColaboradorDataGridViewTextBoxColumn,
            this.getFinishDataGridViewTextBoxColumn,
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
            // iVendereBindingSource
            // 
            this.iVendereBindingSource.DataSource = typeof(Hope.Interface.IVender_e);
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
            // getColaboradorDataGridViewTextBoxColumn
            // 
            this.getColaboradorDataGridViewTextBoxColumn.DataPropertyName = "Get_Colaborador";
            this.getColaboradorDataGridViewTextBoxColumn.HeaderText = "Get_Colaborador";
            this.getColaboradorDataGridViewTextBoxColumn.Name = "getColaboradorDataGridViewTextBoxColumn";
            this.getColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getFinishDataGridViewTextBoxColumn
            // 
            this.getFinishDataGridViewTextBoxColumn.DataPropertyName = "Get_Finish";
            this.getFinishDataGridViewTextBoxColumn.HeaderText = "Get_Finish";
            this.getFinishDataGridViewTextBoxColumn.Name = "getFinishDataGridViewTextBoxColumn";
            this.getFinishDataGridViewTextBoxColumn.ReadOnly = true;
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
        private System.Windows.Forms.BindingSource iVendereBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
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
    }
}
