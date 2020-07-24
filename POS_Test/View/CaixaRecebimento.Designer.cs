namespace POS_Test.View
{
    partial class CaixaRecebimento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRecebimento = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecebidoValor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFormaRcebimento = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblClienteRes = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.cmbCondicaoConsultaCliente = new System.Windows.Forms.ComboBox();
            this.numLimitConsultaCliente = new System.Windows.Forms.NumericUpDown();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtTermoCliente = new System.Windows.Forms.TextBox();
            this.cmbColunaConsultaCliente = new System.Windows.Forms.ComboBox();
            this.btnFiltraCliente = new System.Windows.Forms.Button();
            this.cmbComandoConsualtaCliente = new System.Windows.Forms.ComboBox();
            this.cmbOrdenConsultaCliente = new System.Windows.Forms.ComboBox();
            this.btnAdcionarCliente = new System.Windows.Forms.Button();
            this.iClienteEntcBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitConsultaCliente)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteEntcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRecebimento);
            this.groupBox1.Location = new System.Drawing.Point(4, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recebimento";
            // 
            // cmbRecebimento
            // 
            this.cmbRecebimento.FormattingEnabled = true;
            this.cmbRecebimento.Location = new System.Drawing.Point(6, 19);
            this.cmbRecebimento.Name = "cmbRecebimento";
            this.cmbRecebimento.Size = new System.Drawing.Size(121, 21);
            this.cmbRecebimento.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecebidoValor);
            this.groupBox2.Location = new System.Drawing.Point(145, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Recebido";
            // 
            // txtRecebidoValor
            // 
            this.txtRecebidoValor.Location = new System.Drawing.Point(6, 19);
            this.txtRecebidoValor.Name = "txtRecebidoValor";
            this.txtRecebidoValor.Size = new System.Drawing.Size(121, 20);
            this.txtRecebidoValor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFormaRcebimento);
            this.groupBox3.Location = new System.Drawing.Point(286, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma Recebida";
            // 
            // cmbFormaRcebimento
            // 
            this.cmbFormaRcebimento.FormattingEnabled = true;
            this.cmbFormaRcebimento.Location = new System.Drawing.Point(6, 19);
            this.cmbFormaRcebimento.Name = "cmbFormaRcebimento";
            this.cmbFormaRcebimento.Size = new System.Drawing.Size(121, 21);
            this.cmbFormaRcebimento.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblClienteRes);
            this.groupBox4.Location = new System.Drawing.Point(10, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 42);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // lblClienteRes
            // 
            this.lblClienteRes.AutoSize = true;
            this.lblClienteRes.Location = new System.Drawing.Point(6, 16);
            this.lblClienteRes.Name = "lblClienteRes";
            this.lblClienteRes.Size = new System.Drawing.Size(50, 13);
            this.lblClienteRes.TabIndex = 2;
            this.lblClienteRes.Text = "resultado";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(487, 96);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 31);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(487, 48);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(147, 42);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvListaCliente);
            this.groupBox5.Controls.Add(this.groupBox19);
            this.groupBox5.Location = new System.Drawing.Point(10, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(624, 316);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cliente";
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
            this.dgvListaCliente.DataSource = this.iClienteEntcBindingSource;
            this.dgvListaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaCliente.Location = new System.Drawing.Point(3, 122);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.RowHeadersVisible = false;
            this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCliente.Size = new System.Drawing.Size(618, 191);
            this.dgvListaCliente.TabIndex = 10;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.btnAdcionarCliente);
            this.groupBox19.Controls.Add(this.cmbCondicaoConsultaCliente);
            this.groupBox19.Controls.Add(this.numLimitConsultaCliente);
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.cmbColunaConsultaCliente);
            this.groupBox19.Controls.Add(this.btnFiltraCliente);
            this.groupBox19.Controls.Add(this.cmbComandoConsualtaCliente);
            this.groupBox19.Controls.Add(this.cmbOrdenConsultaCliente);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox19.Location = new System.Drawing.Point(3, 16);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(618, 106);
            this.groupBox19.TabIndex = 11;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Filtrar";
            // 
            // cmbCondicaoConsultaCliente
            // 
            this.cmbCondicaoConsultaCliente.FormattingEnabled = true;
            this.cmbCondicaoConsultaCliente.Location = new System.Drawing.Point(235, 20);
            this.cmbCondicaoConsultaCliente.Name = "cmbCondicaoConsultaCliente";
            this.cmbCondicaoConsultaCliente.Size = new System.Drawing.Size(92, 21);
            this.cmbCondicaoConsultaCliente.TabIndex = 6;
            this.cmbCondicaoConsultaCliente.Text = "Condicao";
            // 
            // numLimitConsultaCliente
            // 
            this.numLimitConsultaCliente.Location = new System.Drawing.Point(422, 21);
            this.numLimitConsultaCliente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLimitConsultaCliente.Name = "numLimitConsultaCliente";
            this.numLimitConsultaCliente.Size = new System.Drawing.Size(53, 20);
            this.numLimitConsultaCliente.TabIndex = 5;
            this.numLimitConsultaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLimitConsultaCliente.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtTermoCliente);
            this.groupBox20.Location = new System.Drawing.Point(6, 46);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(465, 48);
            this.groupBox20.TabIndex = 4;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Termo";
            // 
            // txtTermoCliente
            // 
            this.txtTermoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTermoCliente.Location = new System.Drawing.Point(3, 16);
            this.txtTermoCliente.Name = "txtTermoCliente";
            this.txtTermoCliente.Size = new System.Drawing.Size(459, 20);
            this.txtTermoCliente.TabIndex = 0;
            // 
            // cmbColunaConsultaCliente
            // 
            this.cmbColunaConsultaCliente.FormattingEnabled = true;
            this.cmbColunaConsultaCliente.Location = new System.Drawing.Point(137, 19);
            this.cmbColunaConsultaCliente.Name = "cmbColunaConsultaCliente";
            this.cmbColunaConsultaCliente.Size = new System.Drawing.Size(92, 21);
            this.cmbColunaConsultaCliente.TabIndex = 3;
            this.cmbColunaConsultaCliente.Text = "Coluna";
            // 
            // btnFiltraCliente
            // 
            this.btnFiltraCliente.Location = new System.Drawing.Point(474, 55);
            this.btnFiltraCliente.Name = "btnFiltraCliente";
            this.btnFiltraCliente.Size = new System.Drawing.Size(137, 32);
            this.btnFiltraCliente.TabIndex = 2;
            this.btnFiltraCliente.Text = "Filtrar";
            this.btnFiltraCliente.UseVisualStyleBackColor = true;
            this.btnFiltraCliente.Click += new System.EventHandler(this.btnFiltraCliente_Click);
            // 
            // cmbComandoConsualtaCliente
            // 
            this.cmbComandoConsualtaCliente.FormattingEnabled = true;
            this.cmbComandoConsualtaCliente.Location = new System.Drawing.Point(6, 19);
            this.cmbComandoConsualtaCliente.Name = "cmbComandoConsualtaCliente";
            this.cmbComandoConsualtaCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbComandoConsualtaCliente.TabIndex = 1;
            this.cmbComandoConsualtaCliente.Text = "Comando Consulta";
            // 
            // cmbOrdenConsultaCliente
            // 
            this.cmbOrdenConsultaCliente.FormattingEnabled = true;
            this.cmbOrdenConsultaCliente.Location = new System.Drawing.Point(333, 20);
            this.cmbOrdenConsultaCliente.Name = "cmbOrdenConsultaCliente";
            this.cmbOrdenConsultaCliente.Size = new System.Drawing.Size(83, 21);
            this.cmbOrdenConsultaCliente.TabIndex = 0;
            this.cmbOrdenConsultaCliente.Text = "Ordenar Por";
            // 
            // btnAdcionarCliente
            // 
            this.btnAdcionarCliente.Location = new System.Drawing.Point(477, 17);
            this.btnAdcionarCliente.Name = "btnAdcionarCliente";
            this.btnAdcionarCliente.Size = new System.Drawing.Size(137, 32);
            this.btnAdcionarCliente.TabIndex = 7;
            this.btnAdcionarCliente.Text = "Adicionar Cliente";
            this.btnAdcionarCliente.UseVisualStyleBackColor = true;
            this.btnAdcionarCliente.Click += new System.EventHandler(this.btnAdcionarCliente_Click);
            // 
            // iClienteEntcBindingSource
            // 
            this.iClienteEntcBindingSource.DataSource = typeof(Hope.Entidade.IComprador_Ent_c);
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
            this.tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fornecedorDataGridViewCheckBoxColumn
            // 
            this.fornecedorDataGridViewCheckBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewCheckBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewCheckBoxColumn.Name = "fornecedorDataGridViewCheckBoxColumn";
            this.fornecedorDataGridViewCheckBoxColumn.ReadOnly = true;
            this.fornecedorDataGridViewCheckBoxColumn.Visible = false;
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
            // CaixaRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CaixaRecebimento";
            this.Size = new System.Drawing.Size(655, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLimitConsultaCliente)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iClienteEntcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRecebimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecebidoValor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFormaRcebimento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblClienteRes;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.ComboBox cmbCondicaoConsultaCliente;
        private System.Windows.Forms.NumericUpDown numLimitConsultaCliente;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox txtTermoCliente;
        private System.Windows.Forms.ComboBox cmbColunaConsultaCliente;
        private System.Windows.Forms.Button btnFiltraCliente;
        private System.Windows.Forms.ComboBox cmbComandoConsualtaCliente;
        private System.Windows.Forms.ComboBox cmbOrdenConsultaCliente;
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
        private System.Windows.Forms.BindingSource iClienteEntcBindingSource;
        private System.Windows.Forms.Button btnAdcionarCliente;
    }
}
