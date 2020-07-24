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
    public partial class ColaboradorAlteraRegistro : UserControl
    {
        public ColaboradorAlteraRegistro()
        {
            InitializeComponent();
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Colaborador.AlteraRegistro(out Hope.Entidade.IColaborador_Ent_c usuario);
            bool vnomeuser = usuario.Set_Login_User(txtLoginUser.Text);
            bool vsenha = usuario.Set_Login_PassWord(txtLoginSenha.Text);
            bool vnomecomple = usuario.Set_Nome_Vendedor(txtNomeVendedor.Text);
            if (!vnomeuser | !vnomecomple | !vsenha)
            {
                MessageBox.Show(Program.ObjHope.Colaborador.Informacao.ToMessageBox());
                return;
            }
            else if (Program.ObjHope.Colaborador.GravaAlteracao(usuario))
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

        private void UsuarioAltera_Load(object sender, EventArgs e)
        {
            Hope.Entidade.IColaborador_Ent_c usuario = Program.ObjHope.Colaborador.FocusRegistro;
            txtLoginUser.Text = usuario.Login_User;
            txtNomeVendedor.Text = usuario.Nome_Vendedor;
            txtLoginSenha.Text = usuario.Login_PassWord;
        }
    }
}
