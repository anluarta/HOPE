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
    public partial class UsuarioNovoRegistro : UserControl
    {
        public UsuarioNovoRegistro()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!Program.ObjHope.Usuario.Set_NomeUsuario(txtUsusarioNome.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else if (!Program.ObjHope.Usuario.Set_Senha(txtSenha.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else if (!Program.ObjHope.Usuario.Set_NomeCompleto(txtNomeCompleto.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else if (!Program.ObjHope.Usuario.Set_Email(txtEmail.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else if (Program.ObjHope.Usuario.GravarNovo())
            {
                btnVoltar.PerformClick();
                return;

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);
                return;
            }
        }
    }
}
