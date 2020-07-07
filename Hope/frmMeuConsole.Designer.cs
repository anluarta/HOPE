namespace Hope
{
    partial class frmMeuConsole
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
            this.txtLosa = new System.Windows.Forms.RichTextBox();
            this.officeDataSet_DEBUG = new Hope.OfficeDataSet();
            this.posDataSet_DEBUG = new Hope.PosDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.officeDataSet_DEBUG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet_DEBUG)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLosa
            // 
            this.txtLosa.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtLosa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLosa.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLosa.Location = new System.Drawing.Point(5, 5);
            this.txtLosa.Margin = new System.Windows.Forms.Padding(5);
            this.txtLosa.Name = "txtLosa";
            this.txtLosa.Size = new System.Drawing.Size(790, 440);
            this.txtLosa.TabIndex = 0;
            this.txtLosa.Text = "";
            // 
            // officeDataSet_DEBUG
            // 
            this.officeDataSet_DEBUG.DataSetName = "OfficeDataSet";
            this.officeDataSet_DEBUG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posDataSet_DEBUG
            // 
            this.posDataSet_DEBUG.DataSetName = "PosDataSet";
            this.posDataSet_DEBUG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMeuConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLosa);
            this.Name = "frmMeuConsole";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "HopeConsoleDebug";
            this.Activated += new System.EventHandler(this.frmMeuConsole_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.officeDataSet_DEBUG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet_DEBUG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLosa;
        internal OfficeDataSet officeDataSet_DEBUG;
        internal PosDataSet posDataSet_DEBUG;
    }
}