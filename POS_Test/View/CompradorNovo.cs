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
    public partial class CompradorNovo : UserControl
    {
        public CompradorNovo()
        {
            InitializeComponent();
            cmbTipoCliente.Items.AddRange(Program.ObjHope.ArrayTipoCliente);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Comprador.NovoRegistro(out Hope.Entidade.IComprador_Ent_c cliente))
            {
                bool vcpfcnpj = cliente.Set_Numero_Registro(txtCpf_Cnpj.Text);
                bool vnomecompleto = cliente.Set_NomeCompleto_Razao(txtNomeCompleto_Razao.Text);
                if (!vcpfcnpj  | !vnomecompleto )
                {
                    MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
                    return;
                }
                else if (Program.ObjHope.Comprador.GravarRegistro(cliente))
                {
                    MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
                    btnVoltar.PerformClick();
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
                }
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
            }
        }
    }
}
