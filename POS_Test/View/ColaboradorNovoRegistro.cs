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
    public partial class ColaboradorNovoRegistro : UserControl
    {
        public ColaboradorNovoRegistro()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool vregistro = Program.ObjHope.Colaborador.NovoRegistro(out Hope.Entidade.IColaborador_Ent_c usuario);
            if (vregistro)
            {
                bool vnomeuser = usuario.Set_Login_User(txtLoginUser.Text);
                bool vsenha = usuario.Set_Login_PassWord(txtLoginSenha.Text);
                bool vnomecomple = usuario.Set_Nome_Vendedor(txtNomeVendedor.Text);
                if (!vnomeuser  | !vnomecomple | !vsenha)
                {
                    MessageBox.Show(Program.ObjHope.Colaborador.Informacao.ToMessageBox());
                    return;
                }
                else if (Program.ObjHope.Colaborador.GravarRegistro(usuario))
                {
                    MessageBox.Show(Program.ObjHope.Colaborador.Informacao.ToMessageBox());
                    btnVoltar.PerformClick();
                    return;
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Colaborador.Informacao.ToMessageBox());
                    return;
                }
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Colaborador.Informacao.ToMessageBox());
                return;
            }
        }
    }
}
