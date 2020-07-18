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
    public partial class ClienteAlterar : UserControl
    {
        public ClienteAlterar()
        {
            InitializeComponent();
            cmbTipoCliente.Items.AddRange(Program.ObjHope.ArrayTipoCliente);
            Hope.Entidade.ICliente_Ent_c cliente = Program.ObjHope.Cliente.FocusEntidade;
            txtApelido_Fantasia.Text = cliente.Apelido_Fantasia;
            txtBairro.Text = cliente.Bairro;
            txtCep.Text = cliente.Cep;
            txtCpf_Cnpj.Text = cliente.Cpf_Cnpj;
            txtEmail.Text = cliente.Email;
            txtEstado.Text = cliente.Estado;
            txtLimite_Cupom.Text = cliente.Limite_Cupom;
            txtLimite_Mensal.Text = cliente.Limite_Mensal;
            txtLogradouro.Text = cliente.Logradouro;
            txtMunicipio.Text = cliente.Municipio;
            txtNomeCompleto_Razao.Text = cliente.NomeCompleto_Razao;
            txtObservacao.Text = cliente.Observacao;
            txtTel1.Text = cliente.Telefone_1;
            txtTel2.Text = cliente.Telefone_2;
            chkContaCliente.Checked = cliente.Conta_Cliente;
            chkFornecedor.Checked = cliente.Fornecedor;
            cmbTipoCliente.Text= cliente.Tipo;
            cmbTipoVencimento.Text= cliente.TipoVemcimento;
            cmbVencimentoMensal.Text= cliente.DiaVencimento;
            cmbVencimentoSemanal.Text= cliente.semanaVencimento;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Cliente.AlteraRegistro(out Hope.Entidade.ICliente_Ent_c cliente);
            bool vcpfcnpj = cliente.Set_Cpf_Cnpj(txtCpf_Cnpj.Text);
            bool vnomecompleto = cliente.Set_NomeCompleto_Razao(txtNomeCompleto_Razao.Text);
            bool vtipocliente = cliente.Set_Tipo(cmbTipoCliente.SelectedItem.ToString());
            bool vfornecedor = cliente.Set_Fornecedor(chkFornecedor.Checked);
            if (!vcpfcnpj | !vfornecedor | !vnomecompleto | !vtipocliente)
            {
                MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
                return;
            }
            else if (Program.ObjHope.Cliente.GravaAlteracao(cliente))
            {
                MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
            }
        }
    }
}
