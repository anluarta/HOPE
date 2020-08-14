namespace TesteHope.View
{
    partial class CaixaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaLista));
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
            this.btnVisualizarLeitura = new System.Windows.Forms.ToolStripButton();
            this.btnfechar = new System.Windows.Forms.ToolStripButton();
            this.dgvListaCaixa = new System.Windows.Forms.DataGridView();
            this.getIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getStartDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getfinishDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCaixaeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCaixaeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.iCaixaeBindingSource;
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
            this.btnVisualizarLeitura,
            this.btnfechar});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(486, 25);
            this.bindingNavigator1.TabIndex = 1;
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
            // btnVisualizarLeitura
            // 
            this.btnVisualizarLeitura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnVisualizarLeitura.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarLeitura.Image")));
            this.btnVisualizarLeitura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizarLeitura.Name = "btnVisualizarLeitura";
            this.btnVisualizarLeitura.Size = new System.Drawing.Size(99, 22);
            this.btnVisualizarLeitura.Text = "Visualizar Leitura";
            this.btnVisualizarLeitura.Click += new System.EventHandler(this.btnVisualizarLeitura_Click);
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
            // dgvListaCaixa
            // 
            this.dgvListaCaixa.AllowUserToAddRows = false;
            this.dgvListaCaixa.AllowUserToDeleteRows = false;
            this.dgvListaCaixa.AutoGenerateColumns = false;
            this.dgvListaCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getIDDataGridViewTextBoxColumn,
            this.getColaboradorDataGridViewTextBoxColumn,
            this.getStartDateTimeDataGridViewTextBoxColumn,
            this.getfinishDateTimeDataGridViewTextBoxColumn});
            this.dgvListaCaixa.DataSource = this.iCaixaeBindingSource;
            this.dgvListaCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaCaixa.Location = new System.Drawing.Point(0, 25);
            this.dgvListaCaixa.Name = "dgvListaCaixa";
            this.dgvListaCaixa.ReadOnly = true;
            this.dgvListaCaixa.RowHeadersVisible = false;
            this.dgvListaCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCaixa.Size = new System.Drawing.Size(486, 268);
            this.dgvListaCaixa.TabIndex = 2;
            // 
            // getIDDataGridViewTextBoxColumn
            // 
            this.getIDDataGridViewTextBoxColumn.DataPropertyName = "Get_ID";
            this.getIDDataGridViewTextBoxColumn.HeaderText = "Get_ID";
            this.getIDDataGridViewTextBoxColumn.Name = "getIDDataGridViewTextBoxColumn";
            this.getIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getColaboradorDataGridViewTextBoxColumn
            // 
            this.getColaboradorDataGridViewTextBoxColumn.DataPropertyName = "Get_Colaborador";
            this.getColaboradorDataGridViewTextBoxColumn.HeaderText = "Get_Colaborador";
            this.getColaboradorDataGridViewTextBoxColumn.Name = "getColaboradorDataGridViewTextBoxColumn";
            this.getColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getStartDateTimeDataGridViewTextBoxColumn
            // 
            this.getStartDateTimeDataGridViewTextBoxColumn.DataPropertyName = "Get_Start_DateTime";
            this.getStartDateTimeDataGridViewTextBoxColumn.HeaderText = "Get_Start_DateTime";
            this.getStartDateTimeDataGridViewTextBoxColumn.Name = "getStartDateTimeDataGridViewTextBoxColumn";
            this.getStartDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getfinishDateTimeDataGridViewTextBoxColumn
            // 
            this.getfinishDateTimeDataGridViewTextBoxColumn.DataPropertyName = "Get_finish_DateTime";
            this.getfinishDateTimeDataGridViewTextBoxColumn.HeaderText = "Get_finish_DateTime";
            this.getfinishDateTimeDataGridViewTextBoxColumn.Name = "getfinishDateTimeDataGridViewTextBoxColumn";
            this.getfinishDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iCaixaeBindingSource
            // 
            this.iCaixaeBindingSource.DataSource = typeof(Hope.Interface.ICaixa_e);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CaixaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvListaCaixa);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "CaixaLista";
            this.Size = new System.Drawing.Size(486, 293);
            this.Load += new System.EventHandler(this.CaixaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCaixaeBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnVisualizarLeitura;
        public System.Windows.Forms.ToolStripButton btnfechar;
        private System.Windows.Forms.DataGridView dgvListaCaixa;
        private System.Windows.Forms.BindingSource iCaixaeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn getIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getStartDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getfinishDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
