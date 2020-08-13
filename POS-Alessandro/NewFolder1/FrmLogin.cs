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
using System.Threading;

namespace POS_Alessandro.NewFolder1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bunifuHTTP_Utils1_OnJobDone(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!Program.objhope.Autenticacao.Login(TxtUserName.Text, txtLogin.Text))
            {
                return;
            }
            
            //    if ()
            //{
            //    ;


            //}
            //else
            //{
            //    MessageBox.Show(Program.objhope.Autenticacao.Notifica());
            //}

            this.Close();

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            


        }
    }
}
