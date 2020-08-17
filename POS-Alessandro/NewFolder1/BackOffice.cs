using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Alessandro.NewFolder1
{
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        private void BnfBtnPdv_Click(object sender, EventArgs e)
        {
            FrmFrenteDeCaixa frenteDeCaixa = new FrmFrenteDeCaixa();
            frenteDeCaixa.ShowDialog();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEntrarTRans_Click(object sender, EventArgs e)
        {
            FrmLoginTrans frmLogin = new FrmLoginTrans();
            frmLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.app.bbcloud.com.br/acesso/login");
        }

        private void BackOffice_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
