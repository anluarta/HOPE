using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteHope.View
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Program.ObjHope.Autenticacao.Login(txtUser.Text, txtPass.Text))
            {
                lblResultado.Text = Program.ObjHope.Autenticacao.Notifica();
                bool auten = Program.ObjHope.Autenticacao.Autenticado;
                txtUser.Enabled = !auten;
                txtPass.Enabled = !auten;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Autenticacao.Notifica());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bool auten = Program.ObjHope.Autenticacao.Autenticado;
            txtUser.Enabled = !auten;
            txtPass.Enabled = !auten;
        }
    }
}
