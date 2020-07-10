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
            cmbTipoCliente.Items.AddRange(Program.ObjHope.GetTipoCliente());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Cliente.Set_Cpf_Cnpj(txtCpf_Cnpj.Text);
            Program.ObjHope.Cliente.Set_NomeCompleto_Razao(txtNomeCompleto_Razao.Text);
            Program.ObjHope.Cliente.Set_Tipo(cmbTipoCliente.SelectedItem.ToString());
            Program.ObjHope.Cliente.Set_Fornecedor(chkFornecedor.Checked);
            Program.ObjHope.Cliente.GravarRegistro();
        }
    }
}
