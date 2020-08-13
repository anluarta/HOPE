using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Alessandro.NewFolder1
{
    public partial class FrenteDeCaixa : Form
    {
        public FrenteDeCaixa()
        {
            InitializeComponent();
          //  this.Controls.Add(new NewFolder2.Login());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackOffice form2 = new BackOffice();
            form2.ShowDialog();
        }

        private void Pdv_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //caso o pdv nao esteja sincronizado ao big  boss ele mostra esse icone
        }
    }
}
