namespace POS_Alessandro.NewFolder1
{
    partial class FrmCaixaClosed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixaClosed));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarOperarCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarOperarCaixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_Alessandro.Properties.Resources.doe;
            this.pictureBox1.Location = new System.Drawing.Point(313, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(290, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(957, 811);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(36, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAIXA FECHADO ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTime.Location = new System.Drawing.Point(25, 381);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(150, 55);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "15:45";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarOperarCaixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarOperarCaixaToolStripMenuItem
            // 
            this.voltarOperarCaixaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.voltarOperarCaixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarOperarCaixaToolStripMenuItem1,
            this.trocarUsuarioToolStripMenuItem});
            this.voltarOperarCaixaToolStripMenuItem.Name = "voltarOperarCaixaToolStripMenuItem";
            this.voltarOperarCaixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.voltarOperarCaixaToolStripMenuItem.Text = "Caixa";
            this.voltarOperarCaixaToolStripMenuItem.Click += new System.EventHandler(this.voltarOperarCaixaToolStripMenuItem_Click);
            // 
            // voltarOperarCaixaToolStripMenuItem1
            // 
            this.voltarOperarCaixaToolStripMenuItem1.Name = "voltarOperarCaixaToolStripMenuItem1";
            this.voltarOperarCaixaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.voltarOperarCaixaToolStripMenuItem1.Text = "Voltar Operar Caixa";
            this.voltarOperarCaixaToolStripMenuItem1.Click += new System.EventHandler(this.voltarOperarCaixaToolStripMenuItem1_Click);
            // 
            // trocarUsuarioToolStripMenuItem
            // 
            this.trocarUsuarioToolStripMenuItem.Name = "trocarUsuarioToolStripMenuItem";
            this.trocarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarUsuarioToolStripMenuItem.Text = "Trocar Usuario";
            this.trocarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuarioToolStripMenuItem_Click);
            // 
            // FrmCaixaClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 810);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCaixaClosed";
            this.Text = "Caixa Fechado \" Alguarde Ser Atendido \" ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarOperarCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarOperarCaixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuarioToolStripMenuItem;
    }
}