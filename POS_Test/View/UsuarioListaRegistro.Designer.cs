namespace POS_Test.View
{
    partial class UsuarioListaRegistro
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
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTermo = new System.Windows.Forms.TextBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.btnFiltar = new System.Windows.Forms.Button();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.iUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaUsuario
            // 
            this.dgvListaUsuario.AllowUserToAddRows = false;
            this.dgvListaUsuario.AllowUserToDeleteRows = false;
            this.dgvListaUsuario.AutoGenerateColumns = false;
            this.dgvListaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.usuarioNomeDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvListaUsuario.DataSource = this.iUsuarioBindingSource;
            this.dgvListaUsuario.Location = new System.Drawing.Point(3, 128);
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.ReadOnly = true;
            this.dgvListaUsuario.RowHeadersVisible = false;
            this.dgvListaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuario.Size = new System.Drawing.Size(640, 298);
            this.dgvListaUsuario.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(485, 16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(158, 36);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbLocal);
            this.groupBox1.Controls.Add(this.btnFiltar);
            this.groupBox1.Controls.Add(this.cmbOperacao);
            this.groupBox1.Controls.Add(this.cmbOrdenar);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTermo);
            this.groupBox2.Location = new System.Drawing.Point(146, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 48);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termo";
            // 
            // txtTermo
            // 
            this.txtTermo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTermo.Location = new System.Drawing.Point(3, 16);
            this.txtTermo.Name = "txtTermo";
            this.txtTermo.Size = new System.Drawing.Size(237, 20);
            this.txtTermo.TabIndex = 0;
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(6, 46);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbLocal.TabIndex = 3;
            this.cmbLocal.Text = "Local";
            // 
            // btnFiltar
            // 
            this.btnFiltar.Location = new System.Drawing.Point(325, 70);
            this.btnFiltar.Name = "btnFiltar";
            this.btnFiltar.Size = new System.Drawing.Size(76, 21);
            this.btnFiltar.TabIndex = 2;
            this.btnFiltar.Text = "Filtrar";
            this.btnFiltar.UseVisualStyleBackColor = true;
            this.btnFiltar.Click += new System.EventHandler(this.btnFiltar_Click);
            // 
            // cmbOperacao
            // 
            this.cmbOperacao.FormattingEnabled = true;
            this.cmbOperacao.Location = new System.Drawing.Point(6, 19);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacao.TabIndex = 1;
            this.cmbOperacao.Text = "Operacao";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(6, 73);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 0;
            this.cmbOrdenar.Text = "Ordenar Por";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(485, 58);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 49);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // iUsuarioBindingSource
            // 
            this.iUsuarioBindingSource.DataSource = typeof(Hope.Entidade.IUsuario);
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioNomeDataGridViewTextBoxColumn
            // 
            this.usuarioNomeDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Nome";
            this.usuarioNomeDataGridViewTextBoxColumn.HeaderText = "Usuario_Nome";
            this.usuarioNomeDataGridViewTextBoxColumn.Name = "usuarioNomeDataGridViewTextBoxColumn";
            this.usuarioNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Completo";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome_Completo";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UsuarioListaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvListaUsuario);
            this.Name = "UsuarioListaRegistro";
            this.Size = new System.Drawing.Size(711, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTermo;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Button btnFiltar;
        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iUsuarioBindingSource;
    }
}
