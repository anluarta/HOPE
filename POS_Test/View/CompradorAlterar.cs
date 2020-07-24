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
    public partial class CompradorAlterar : UserControl
    {
        public CompradorAlterar()
        {
            InitializeComponent();
            Hope.Entidade.IComprador_Ent_c cliente = Program.ObjHope.Comprador.FocusEntidade;
            txtCpf_Cnpj.Text = cliente.Numero_Registro;
            txtNomeCompleto_Razao.Text = cliente.NomeCompleto_RazaoSocial;
            
            //txtEmail.Text = cliente.Email;
            //txtEstado.Text = cliente.Estado;
            //txtLimite_Cupom.Text = cliente.Limite_Cupom;
            //txtLimite_Mensal.Text = cliente.Limite_Mensal;
            //txtLogradouro.Text = cliente.Logradouro;
            //txtMunicipio.Text = cliente.Municipio;
            //txtObservacao.Text = cliente.Observacao;
            //txtTel1.Text = cliente.Telefone_1;
            //txtTel2.Text = cliente.Telefone_2;
            //chkContaCliente.Checked = cliente.Conta_Cliente;
            //chkFornecedor.Checked = cliente.Fornecedor;
            //cmbTipoCliente.Text= cliente.Tipo;
            //cmbTipoVencimento.Text= cliente.TipoVemcimento;
            //cmbVencimentoMensal.Text= cliente.DiaVencimento;
            //cmbVencimentoSemanal.Text= cliente.semanaVencimento;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Comprador.AlteraRegistro(out Hope.Entidade.IComprador_Ent_c cliente);
            bool vcpfcnpj = cliente.Set_Numero_Registro(txtCpf_Cnpj.Text);
            bool vnomecompleto = cliente.Set_NomeCompleto_Razao(txtNomeCompleto_Razao.Text);
            if (!vcpfcnpj  | !vnomecompleto )
            {
                MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
                return;
            }
            else if (Program.ObjHope.Comprador.GravaAlteracao(cliente))
            {
                MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
                btnVoltar.PerformClick();
                return;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
            }
        }
    }
}
