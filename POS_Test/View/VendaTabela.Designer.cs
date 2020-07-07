namespace POS_Test.View
{
    partial class VendaTabela
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
            this.listTabPreco = new System.Windows.Forms.ListBox();
            this.btnConfima = new ns1.BunifuTileButton();
            this.SuspendLayout();
            // 
            // listTabPreco
            // 
            this.listTabPreco.BackColor = System.Drawing.SystemColors.Control;
            this.listTabPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTabPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTabPreco.FormattingEnabled = true;
            this.listTabPreco.ItemHeight = 20;
            this.listTabPreco.Location = new System.Drawing.Point(20, 20);
            this.listTabPreco.Name = "listTabPreco";
            this.listTabPreco.Size = new System.Drawing.Size(231, 100);
            this.listTabPreco.TabIndex = 10;
            // 
            // btnConfima
            // 
            this.btnConfima.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfima.color = System.Drawing.SystemColors.HotTrack;
            this.btnConfima.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnConfima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnConfima.ForeColor = System.Drawing.Color.White;
            this.btnConfima.Image = global::POS_Test.Properties.Resources.Confimado;
            this.btnConfima.ImagePosition = 0;
            this.btnConfima.ImageZoom = 20;
            this.btnConfima.LabelPosition = 25;
            this.btnConfima.LabelText = "Confimar";
            this.btnConfima.Location = new System.Drawing.Point(20, 121);
            this.btnConfima.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfima.Name = "btnConfima";
            this.btnConfima.Size = new System.Drawing.Size(231, 67);
            this.btnConfima.TabIndex = 9;
            // 
            // VendaTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTabPreco);
            this.Controls.Add(this.btnConfima);
            this.Name = "VendaTabela";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(271, 208);
            this.ResumeLayout(false);

        }

        #endregion

        public ns1.BunifuTileButton btnConfima;
        public System.Windows.Forms.ListBox listTabPreco;
    }
}
