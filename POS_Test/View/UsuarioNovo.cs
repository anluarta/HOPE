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
    public partial class UsuarioNovo : UserControl
    {
        public UsuarioNovo()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Hope.Nucleo.ObjUsuario.Novo(txtUsusario.Text, txtSenha.Text, txtNome.Text))
            {
                MessageBox.Show(Hope.Nucleo.ObjUsuario.strMsgResult);
                btnVoltar.PerformClick();
            }
            else
            {
                MessageBox.Show(Hope.Nucleo.ObjUsuario.strMsgResult);
            }
        }
    }
}
