namespace POS_Test.View
{
    partial class CupomCliente
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
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtTermoClient = new System.Windows.Forms.TextBox();
            this.cmbLocalConsultaClien = new System.Windows.Forms.ComboBox();
            this.btnFiltraCliente = new System.Windows.Forms.Button();
            this.cmbOperacaoConsultaClient = new System.Windows.Forms.ComboBox();
            this.cmbOrdenConsultaClient = new System.Windows.Forms.ComboBox();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoRazaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.iClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.btnAdicionarCliente);
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.cmbLocalConsultaClien);
            this.groupBox19.Controls.Add(this.btnFiltraCliente);
            this.groupBox19.Controls.Add(this.cmbOperacaoConsultaClient);
            this.groupBox19.Controls.Add(this.cmbOrdenConsultaClient);
            this.groupBox19.Location = new System.Drawing.Point(3, 3);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(611, 106);
            this.groupBox19.TabIndex = 13;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Filtrar";
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(496, 32);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(109, 38);
            this.btnAdicionarCliente.TabIndex = 12;
            this.btnAdicionarCliente.Text = "Adicionar Itenselecionado";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtTermoClient);
            this.groupBox20.Location = new System.Drawing.Point(6, 52);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(458, 48);
            this.groupBox20.TabIndex = 4;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Termo";
            // 
            // txtTermoClient
            // 
            this.txtTermoClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTermoClient.Location = new System.Drawing.Point(3, 16);
            this.txtTermoClient.Name = "txtTermoClient";
            this.txtTermoClient.Size = new System.Drawing.Size(452, 20);
            this.txtTermoClient.TabIndex = 0;
            // 
            // cmbLocalConsultaClien
            // 
            this.cmbLocalConsultaClien.FormattingEnabled = true;
            this.cmbLocalConsultaClien.Location = new System.Drawing.Point(134, 17);
            this.cmbLocalConsultaClien.Name = "cmbLocalConsultaClien";
            this.cmbLocalConsultaClien.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalConsultaClien.TabIndex = 3;
            this.cmbLocalConsultaClien.Text = "Local";
            // 
            // btnFiltraCliente
            // 
            this.btnFiltraCliente.Location = new System.Drawing.Point(388, 17);
            this.btnFiltraCliente.Name = "btnFiltraCliente";
            this.btnFiltraCliente.Size = new System.Drawing.Size(76, 21);
            this.btnFiltraCliente.TabIndex = 2;
            this.btnFiltraCliente.Text = "Filtrar";
            this.btnFiltraCliente.UseVisualStyleBackColor = true;
            this.btnFiltraCliente.Click += new System.EventHandler(this.btnFiltraCliente_Click);
            // 
            // cmbOperacaoConsultaClient
            // 
            this.cmbOperacaoConsultaClient.FormattingEnabled = true;
            this.cmbOperacaoConsultaClient.Location = new System.Drawing.Point(6, 18);
            this.cmbOperacaoConsultaClient.Name = "cmbOperacaoConsultaClient";
            this.cmbOperacaoConsultaClient.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacaoConsultaClient.TabIndex = 1;
            this.cmbOperacaoConsultaClient.Text = "Operacao";
            // 
            // cmbOrdenConsultaClient
            // 
            this.cmbOrdenConsultaClient.FormattingEnabled = true;
            this.cmbOrdenConsultaClient.Location = new System.Drawing.Point(261, 18);
            this.cmbOrdenConsultaClient.Name = "cmbOrdenConsultaClient";
            this.cmbOrdenConsultaClient.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenConsultaClient.TabIndex = 0;
            this.cmbOrdenConsultaClient.Text = "Ordenar Por";
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AllowUserToAddRows = false;
            this.dgvListaCliente.AllowUserToDeleteRows = false;
            this.dgvListaCliente.AutoGenerateColumns = false;
            this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewCheckBoxColumn,
            this.cpfCnpjDataGridViewTextBoxColumn,
            this.nomeCompletoRazaoDataGridViewTextBoxColumn,
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
            this.dgvListaCliente.DataSource = this.iClienteBindingSource;
            this.dgvListaCliente.Location = new System.Drawing.Point(3, 115);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.RowHeadersVisible = false;
            this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCliente.Size = new System.Drawing.Size(605, 172);
            this.dgvListaCliente.TabIndex = 12;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apelidoFantasiaDataGridViewTextBoxColumn
            // 
            this.apelidoFantasiaDataGridViewTextBoxColumn.DataPropertyName = "Apelido_Fantasia";
            this.apelidoFantasiaDataGridViewTextBoxColumn.HeaderText = "Apelido_Fantasia";
            this.apelidoFantasiaDataGridViewTextBoxColumn.Name = "apelidoFantasiaDataGridViewTextBoxColumn";
            this.apelidoFantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefone1DataGridViewTextBoxColumn
            // 
            this.telefone1DataGridViewTextBoxColumn.DataPropertyName = "Telefone_1";
            this.telefone1DataGridViewTextBoxColumn.HeaderText = "Telefone_1";
            this.telefone1DataGridViewTextBoxColumn.Name = "telefone1DataGridViewTextBoxColumn";
            this.telefone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefone2DataGridViewTextBoxColumn
            // 
            this.telefone2DataGridViewTextBoxColumn.DataPropertyName = "Telefone_2";
            this.telefone2DataGridViewTextBoxColumn.HeaderText = "Telefone_2";
            this.telefone2DataGridViewTextBoxColumn.Name = "telefone2DataGridViewTextBoxColumn";
            this.telefone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "Municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            this.municipioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contaClienteDataGridViewCheckBoxColumn
            // 
            this.contaClienteDataGridViewCheckBoxColumn.DataPropertyName = "Conta_Cliente";
            this.contaClienteDataGridViewCheckBoxColumn.HeaderText = "Conta_Cliente";
            this.contaClienteDataGridViewCheckBoxColumn.Name = "contaClienteDataGridViewCheckBoxColumn";
            this.contaClienteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // limiteCupomDataGridViewTextBoxColumn
            // 
            this.limiteCupomDataGridViewTextBoxColumn.DataPropertyName = "Limite_Cupom";
            this.limiteCupomDataGridViewTextBoxColumn.HeaderText = "Limite_Cupom";
            this.limiteCupomDataGridViewTextBoxColumn.Name = "limiteCupomDataGridViewTextBoxColumn";
            this.limiteCupomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limiteMensalDataGridViewTextBoxColumn
            // 
            this.limiteMensalDataGridViewTextBoxColumn.DataPropertyName = "Limite_Mensal";
            this.limiteMensalDataGridViewTextBoxColumn.HeaderText = "Limite_Mensal";
            this.limiteMensalDataGridViewTextBoxColumn.Name = "limiteMensalDataGridViewTextBoxColumn";
            this.limiteMensalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semanaVencimentoDataGridViewTextBoxColumn
            // 
            this.semanaVencimentoDataGridViewTextBoxColumn.DataPropertyName = "semanaVencimento";
            this.semanaVencimentoDataGridViewTextBoxColumn.HeaderText = "semanaVencimento";
            this.semanaVencimentoDataGridViewTextBoxColumn.Name = "semanaVencimentoDataGridViewTextBoxColumn";
            this.semanaVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoVemcimentoDataGridViewTextBoxColumn
            // 
            this.tipoVemcimentoDataGridViewTextBoxColumn.DataPropertyName = "TipoVemcimento";
            this.tipoVemcimentoDataGridViewTextBoxColumn.HeaderText = "TipoVemcimento";
            this.tipoVemcimentoDataGridViewTextBoxColumn.Name = "tipoVemcimentoDataGridViewTextBoxColumn";
            this.tipoVemcimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaVencimentoDataGridViewTextBoxColumn
            // 
            this.diaVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DiaVencimento";
            this.diaVencimentoDataGridViewTextBoxColumn.HeaderText = "DiaVencimento";
            this.diaVencimentoDataGridViewTextBoxColumn.Name = "diaVencimentoDataGridViewTextBoxColumn";
            this.diaVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iClienteBindingSource
            // 
            this.iClienteBindingSource.DataSource = typeof(Hope.Controle.ICliente_Ent_c);
            // 
            // CupomCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.dgvListaCliente);
            this.Name = "CupomCliente";
            this.Size = new System.Drawing.Size(622, 297);
            this.groupBox19.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox txtTermoClient;
        private System.Windows.Forms.ComboBox cmbLocalConsultaClien;
        private System.Windows.Forms.Button btnFiltraCliente;
        private System.Windows.Forms.ComboBox cmbOperacaoConsultaClient;
        private System.Windows.Forms.ComboBox cmbOrdenConsultaClient;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fornecedorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoRazaoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource iClienteBindingSource;
    }
}
