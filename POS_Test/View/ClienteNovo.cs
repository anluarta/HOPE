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
    public partial class ClienteNovo : UserControl
    {
        public ClienteNovo()
        {
            InitializeComponent();
            cmbTipoCliente.Items.AddRange(Program.ObjHope.ArrayTipoCliente);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Cliente.NovoRegistro(out Hope.Entidade.ICliente_Ent_c cliente))
            {
                bool vcpfcnpj = cliente.Set_Cpf_Cnpj(txtCpf_Cnpj.Text);
                bool vnomecompleto = cliente.Set_NomeCompleto_Razao(txtNomeCompleto_Razao.Text);
                bool vtipocliente = cliente.Set_Tipo(cmbTipoCliente.SelectedItem.ToString());
                bool vfornecedor = cliente.Set_Fornecedor(chkFornecedor.Checked);
                if (!vcpfcnpj|!vfornecedor|!vnomecompleto|!vtipocliente)
                {
                    MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
                    return;
                }
                else if (Program.ObjHope.Cliente.GravarRegistro(cliente))
                {
                    MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
                }
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
            }
        }
    }
}
