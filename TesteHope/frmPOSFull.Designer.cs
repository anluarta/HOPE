namespace TesteHope
{
    partial class frmPOSFull
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autenticarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logouthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixaFechamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixaSangria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixaSuprimento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixaLeitura = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixaLista = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbldatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCaixaResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.preLoadHopeCarrgarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autenticarToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.preLoadHopeCarrgarDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autenticarToolStripMenuItem
            // 
            this.autenticarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logouthToolStripMenuItem});
            this.autenticarToolStripMenuItem.Name = "autenticarToolStripMenuItem";
            this.autenticarToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.autenticarToolStripMenuItem.Text = "Autenticar";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logouthToolStripMenuItem
            // 
            this.logouthToolStripMenuItem.Name = "logouthToolStripMenuItem";
            this.logouthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logouthToolStripMenuItem.Text = "Logouth";
            this.logouthToolStripMenuItem.Click += new System.EventHandler(this.logouthToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCaixaNovo,
            this.btnCaixaFechamento,
            this.btnCaixaSangria,
            this.btnCaixaSuprimento,
            this.btnCaixaLeitura,
            this.btnCaixaLista});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // btnCaixaNovo
            // 
            this.btnCaixaNovo.Name = "btnCaixaNovo";
            this.btnCaixaNovo.Size = new System.Drawing.Size(140, 22);
            this.btnCaixaNovo.Text = "Novo";
            this.btnCaixaNovo.Click += new System.EventHandler(this.BtnCaixaNovo_Click);
            // 
            // btnCaixaFechamento
            // 
            this.btnCaixaFechamento.Name = "btnCaixaFechamento";
            this.btnCaixaFechamento.Size = new System.Drawing.Size(140, 22);
            this.btnCaixaFechamento.Text = "Fechamento";
            this.btnCaixaFechamento.Click += new System.EventHandler(this.BtnCaixaFechamento_Click);
            // 
            // btnCaixaSangria
            // 
            this.btnCaixaSangria.Name = "btnCaixaSangria";
            this.btnCaixaSangria.Size = new System.Drawing.Size(140, 22);
            this.btnCaixaSangria.Text = "Sangria";
            this.btnCaixaSangria.Click += new System.EventHandler(this.BtnCaixaSangria_Click);
            // 
            // btnCaixaSuprimento
            // 
            this.btnCaixaSuprimento.Name = "btnCaixaSuprimento";
            this.btnCaixaSuprimento.Size = new System.Drawing.Size(140, 22);
            this.btnCaixaSuprimento.Text = "Suprimento";
            this.btnCaixaSuprimento.Click += new System.EventHandler(this.BtnCaixaSuprimento_Click);
            // 
            // btnCaixaLeitura
            // 
            this.btnCaixaLeitura.Name = "btnCaixaLeitura";
            this.btnCaixaLeitura.Size = new System.Drawing.Size(140, 22);
            this.btnCaixaLeitura.Text = "Leitura";
            this.btnCaixaLeitura.Click += new System.EventHandler(this.BtnCaixaLeitura_Click);
            // 
            // btnCaixaLista
            // 
            this.btnCaixaLista.Name = "btnCaixaLista";
            this.btnCaixaLista.Size = new System.Drawing.Size(140, 22);
            this.btnCaixaLista.Text = "Lista";
            this.btnCaixaLista.Click += new System.EventHandler(this.btnCaixaLista_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaVenda,
            this.btnListaVenda});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(103, 22);
            this.btnNovaVenda.Text = "Novo";
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnListaVenda
            // 
            this.btnListaVenda.Name = "btnListaVenda";
            this.btnListaVenda.Size = new System.Drawing.Size(103, 22);
            this.btnListaVenda.Text = "Lista";
            this.btnListaVenda.Click += new System.EventHandler(this.btnListaVenda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbldatetime,
            this.lblCaixaResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbldatetime
            // 
            this.lbldatetime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(54, 17);
            this.lbldatetime.Text = "datetime";
            // 
            // lblCaixaResult
            // 
            this.lblCaixaResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCaixaResult.Name = "lblCaixaResult";
            this.lblCaixaResult.Size = new System.Drawing.Size(91, 17);
            this.lblCaixaResult.Text = "Caixa Resultado";
            // 
            // pnlView
            // 
            this.pnlView.BackgroundImage = global::TesteHope.Properties.Resources.GrassandSky;
            this.pnlView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 24);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(722, 382);
            this.pnlView.TabIndex = 5;
            // 
            // preLoadHopeCarrgarDadosToolStripMenuItem
            // 
            this.preLoadHopeCarrgarDadosToolStripMenuItem.Name = "preLoadHopeCarrgarDadosToolStripMenuItem";
            this.preLoadHopeCarrgarDadosToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.preLoadHopeCarrgarDadosToolStripMenuItem.Text = "PreLoadHopeCarrgarDados";
            this.preLoadHopeCarrgarDadosToolStripMenuItem.Click += new System.EventHandler(this.preLoadHopeCarrgarDadosToolStripMenuItem_Click);
            // 
            // frmPOSFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 428);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPOSFull";
            this.Text = "HOPE POS Full";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbldatetime;
        private System.Windows.Forms.ToolStripMenuItem autenticarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logouthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCaixaNovo;
        private System.Windows.Forms.ToolStripMenuItem btnCaixaFechamento;
        private System.Windows.Forms.ToolStripMenuItem btnCaixaSangria;
        private System.Windows.Forms.ToolStripMenuItem btnCaixaSuprimento;
        private System.Windows.Forms.ToolStripMenuItem btnCaixaLeitura;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem btnListaVenda;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ToolStripStatusLabel lblCaixaResult;
        private System.Windows.Forms.ToolStripMenuItem btnCaixaLista;
        private System.Windows.Forms.ToolStripMenuItem preLoadHopeCarrgarDadosToolStripMenuItem;
    }
}

