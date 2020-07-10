namespace POS_Test.View
{
    partial class ClienteLista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoRazaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelidoFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaClienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.limiteCupomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteMensalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanaVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVemcimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iClienteVarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTermo = new System.Windows.Forms.TextBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.btnFiltar = new System.Windows.Forms.Button();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteVarBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.cpfCnpjDataGridViewTextBoxColumn,
            this.nomeCompletoRazaoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.apelidoFantasiaDataGridViewTextBoxColumn,
            this.telefone1DataGridViewTextBoxColumn,
            this.telefone2DataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.municipioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.contaClienteDataGridViewCheckBoxColumn,
            this.limiteCupomDataGridViewTextBoxColumn,
            this.limiteMensalDataGridViewTextBoxColumn,
            this.semanaVencimentoDataGridViewTextBoxColumn,
            this.tipoVemcimentoDataGridViewTextBoxColumn,
            this.diaVencimentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iClienteVarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfCnpjDataGridViewTextBoxColumn
            // 
            this.cpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "Cpf_Cnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.HeaderText = "Cpf_Cnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.Name = "cpfCnpjDataGridViewTextBoxColumn";
            this.cpfCnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCompletoRazaoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoRazaoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto_Razao";
            this.nomeCompletoRazaoDataGridViewTextBoxColumn.HeaderText = "NomeCompleto_Razao";
            this.nomeCompletoRazaoDataGridViewTextBoxColumn.Name = "nomeCompletoRazaoDataGridViewTextBoxColumn";
            this.nomeCompletoRazaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewCheckBoxColumn
            // 
            this.fornecedorDataGridViewCheckBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewCheckBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewCheckBoxColumn.Name = "fornecedorDataGridViewCheckBoxColumn";
            this.fornecedorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // apelidoFantasiaDataGridViewTextBoxColumn
            // 
            this.apelidoFantasiaDataGridViewTextBoxColumn.DataPropertyName = "Apelido_Fantasia";
            this.apelidoFantasiaDataGridViewTextBoxColumn.HeaderText = "Apelido_Fantasia";
            this.apelidoFantasiaDataGridViewTextBoxColumn.Name = "apelidoFantasiaDataGridViewTextBoxColumn";
            this.apelidoFantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.apelidoFantasiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefone1DataGridViewTextBoxColumn
            // 
            this.telefone1DataGridViewTextBoxColumn.DataPropertyName = "Telefone_1";
            this.telefone1DataGridViewTextBoxColumn.HeaderText = "Telefone_1";
            this.telefone1DataGridViewTextBoxColumn.Name = "telefone1DataGridViewTextBoxColumn";
            this.telefone1DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefone1DataGridViewTextBoxColumn.Visible = false;
            // 
            // telefone2DataGridViewTextBoxColumn
            // 
            this.telefone2DataGridViewTextBoxColumn.DataPropertyName = "Telefone_2";
            this.telefone2DataGridViewTextBoxColumn.HeaderText = "Telefone_2";
            this.telefone2DataGridViewTextBoxColumn.Name = "telefone2DataGridViewTextBoxColumn";
            this.telefone2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefone2DataGridViewTextBoxColumn.Visible = false;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            this.cepDataGridViewTextBoxColumn.Visible = false;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            this.logradouroDataGridViewTextBoxColumn.Visible = false;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "Municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            this.municipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.municipioDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // contaClienteDataGridViewCheckBoxColumn
            // 
            this.contaClienteDataGridViewCheckBoxColumn.DataPropertyName = "Conta_Cliente";
            this.contaClienteDataGridViewCheckBoxColumn.HeaderText = "Conta_Cliente";
            this.contaClienteDataGridViewCheckBoxColumn.Name = "contaClienteDataGridViewCheckBoxColumn";
            this.contaClienteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.contaClienteDataGridViewCheckBoxColumn.Visible = false;
            // 
            // limiteCupomDataGridViewTextBoxColumn
            // 
            this.limiteCupomDataGridViewTextBoxColumn.DataPropertyName = "Limite_Cupom";
            this.limiteCupomDataGridViewTextBoxColumn.HeaderText = "Limite_Cupom";
            this.limiteCupomDataGridViewTextBoxColumn.Name = "limiteCupomDataGridViewTextBoxColumn";
            this.limiteCupomDataGridViewTextBoxColumn.ReadOnly = true;
            this.limiteCupomDataGridViewTextBoxColumn.Visible = false;
            // 
            // limiteMensalDataGridViewTextBoxColumn
            // 
            this.limiteMensalDataGridViewTextBoxColumn.DataPropertyName = "Limite_Mensal";
            this.limiteMensalDataGridViewTextBoxColumn.HeaderText = "Limite_Mensal";
            this.limiteMensalDataGridViewTextBoxColumn.Name = "limiteMensalDataGridViewTextBoxColumn";
            this.limiteMensalDataGridViewTextBoxColumn.ReadOnly = true;
            this.limiteMensalDataGridViewTextBoxColumn.Visible = false;
            // 
            // semanaVencimentoDataGridViewTextBoxColumn
            // 
            this.semanaVencimentoDataGridViewTextBoxColumn.DataPropertyName = "semanaVencimento";
            this.semanaVencimentoDataGridViewTextBoxColumn.HeaderText = "semanaVencimento";
            this.semanaVencimentoDataGridViewTextBoxColumn.Name = "semanaVencimentoDataGridViewTextBoxColumn";
            this.semanaVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.semanaVencimentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoVemcimentoDataGridViewTextBoxColumn
            // 
            this.tipoVemcimentoDataGridViewTextBoxColumn.DataPropertyName = "TipoVemcimento";
            this.tipoVemcimentoDataGridViewTextBoxColumn.HeaderText = "TipoVemcimento";
            this.tipoVemcimentoDataGridViewTextBoxColumn.Name = "tipoVemcimentoDataGridViewTextBoxColumn";
            this.tipoVemcimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoVemcimentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // diaVencimentoDataGridViewTextBoxColumn
            // 
            this.diaVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DiaVencimento";
            this.diaVencimentoDataGridViewTextBoxColumn.HeaderText = "DiaVencimento";
            this.diaVencimentoDataGridViewTextBoxColumn.Name = "diaVencimentoDataGridViewTextBoxColumn";
            this.diaVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaVencimentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // iClienteVarBindingSource
            // 
            this.iClienteVarBindingSource.DataSource = typeof(Hope.Entidade.ICliente);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(475, 45);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 49);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbLocal);
            this.groupBox1.Controls.Add(this.btnFiltar);
            this.groupBox1.Controls.Add(this.cmbOperacao);
            this.groupBox1.Controls.Add(this.cmbOrdenar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 106);
            this.groupBox1.TabIndex = 8;
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
            this.cmbLocal.Location = new System.Drawing.Point(6, 48);
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
            this.cmbOperacao.Location = new System.Drawing.Point(6, 18);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacao.TabIndex = 1;
            this.cmbOperacao.Text = "Operacao";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(6, 75);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 0;
            this.cmbOrdenar.Text = "Ordenar Por";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(475, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(158, 36);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // ClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClienteLista";
            this.Size = new System.Drawing.Size(702, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteVarBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iClienteVarBindingSource;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTermo;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Button btnFiltar;
        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoRazaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fornecedorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contaClienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteCupomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteMensalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanaVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVemcimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaVencimentoDataGridViewTextBoxColumn;
    }
}
