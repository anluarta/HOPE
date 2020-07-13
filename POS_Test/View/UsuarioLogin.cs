using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Test.View
{
    public partial class UsuarioLogin : UserControl
    {
        public UsuarioLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Program.ObjHope.Usuario.Login(txtUsuarioNome.Text, txtSenha.Text, out string msg))
            {
                btnVoltar.PerformClick();
            }
            else
            {
                label1.Text = msg;
            }

        }
    }
}
