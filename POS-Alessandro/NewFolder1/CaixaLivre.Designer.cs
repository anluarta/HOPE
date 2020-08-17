namespace POS_Alessandro.NewFolder1
{
    partial class FrmCaixaLivre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixaLivre));
            this.LblHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TmHora = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Transparent;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.DimGray;
            this.LblHora.Location = new System.Drawing.Point(1035, 45);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(145, 55);
            this.LblHora.TabIndex = 1;
            this.LblHora.Text = "15:03";
            this.LblHora.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label4.Location = new System.Drawing.Point(1087, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(1084, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Para Vender ";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1029, 809);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(167, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAIXA LIVRE";
            // 
            // TmHora
            // 
            this.TmHora.Enabled = true;
            this.TmHora.Tick += new System.EventHandler(this.TmHora_Tick);
            // 
            // FrmCaixaLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1254, 810);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmCaixaLivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaixaLivre";
            this.Load += new System.EventHandler(this.FrmCaixaLivre_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        internal ns1.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TmHora;
    }
}