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
            bool vregistro = Program.ObjHope.Usuario.NovoRegistro(out Hope.Entidade.IUsuario_Ent_c usuario);
            if (vregistro)
            {
               bool vnomeuser= usuario.Set_NomeUsuario(txtUsusarioNome.Text);
               bool vsenha =usuario.Set_Senha(txtSenha.Text);
               bool vnomecomple =usuario.Set_NomeCompleto(txtNomeCompleto.Text);
               bool vemail= usuario.Set_Email(txtEmail.Text);
                if (!vnomeuser|!vemail|!vnomecomple|vsenha)
                {
                    MessageBox.Show(Program.ObjHope.Usuario.Informacao.ToMessageBox());
                    return;
                }
                else if (Program.ObjHope.Usuario.GravarRegistro(usuario))
                {
                    btnVoltar.PerformClick();
                    return;

                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Usuario.Informacao.ToMessageBox());
                    return;
                }
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.Informacao.ToMessageBox());
                return;
            }
        }
    }
}
