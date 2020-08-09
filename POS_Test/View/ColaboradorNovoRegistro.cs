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
            try
            {
                Hope.Interface.IColaborador_e colaborador = Program.ObjHope.BackOffice.Colaborador.Novo();
               bool v1= colaborador.Set_Login(txtLoginUser.Text);
                bool v2 = colaborador.Set_Nome_Vendedor(txtNomeVendedor.Text);
                bool v3 = colaborador.Set_Senha(txtLoginSenha.Text);
                if (v1&v2&v3)
                {
                    bool v4=Program.ObjHope.BackOffice.Colaborador.Gravar(colaborador);
                    if (v4)
                    {
                        btnVoltar.PerformClick();
                    }
                    else
                    {
                        Program.ObjHope.BackOffice.Colaborador.Notifica.Mensagem();
                    }
                }
                else
                {
                    colaborador.Notifica.Mensagem();
                }

            }
            catch(Hope.HException he)
            {
                MessageBox.Show(he.Message);
            }

        }
    }
}
