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
    public partial class ColaboradorLogin : UserControl
    {
        public ColaboradorLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Autenticacao.Login(User: txtUsuarioNome.Text,Pass: txtSenha.Text))
            {
                btnVoltar.PerformClick();
            }
            else
            {
                label1.Text = Program.ObjHope.Autenticacao.Notifica.Mensagem();
            }

        }
    }
}
