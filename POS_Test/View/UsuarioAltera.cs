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
    public partial class UsuarioAltera : UserControl
    {
        public UsuarioAltera()
        {
            InitializeComponent();
            Hope.Entidade.IUsuario usuario = Program.ObjHope.Usuario.FocusEntidade;
            txtEmail.Text = usuario.Email;
            txtNomeCompleto.Text = usuario.Nome_Completo;
            txtSenha.Text = usuario.Senha;
            txtUsusarioNome.Text = usuario.Usuario_Nome;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!Program.ObjHope.Usuario.Set_Email(txtEmail.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }else
            if (!Program.ObjHope.Usuario.Set_NomeCompleto(txtNomeCompleto.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else
            if (!Program.ObjHope.Usuario.Set_NomeUsuario(txtUsusarioNome.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else
            if (!Program.ObjHope.Usuario.Set_Senha(txtSenha.Text))
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
            else if (Program.ObjHope.Usuario.GravaAlteracao())
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                btnVoltar.PerformClick();
            }
            else
            {
                lblResultado.Text = Program.ObjHope.Usuario.StrMsgResult;
                return;
            }
        }

        private void UsuarioAltera_Load(object sender, EventArgs e)
        {

        }
    }
}
