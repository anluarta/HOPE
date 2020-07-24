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
    public partial class CaixaRecebimento : UserControl
    {
        public CaixaRecebimento()
        {
            InitializeComponent();
            cmbColunaConsultaCliente.Items.AddRange(Program.ObjHope.ArrayClienteConsultaColuna);
            cmbFormaRcebimento.Items.AddRange(Program.ObjHope.ArrayFormaRecebimento);
            cmbRecebimento.Items.AddRange(Program.ObjHope.ArrayTipoRecebimento);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //if (Program.ObjHope.Caixa.Recebimento.NovoRegistro(out Hope.Entidade.IRecebimento_Ent_c recebimento))
            //{
            //    bool vtipo = recebimento.SetTipoRecebimento(cmbRecebimento.SelectedItem.ToString());
            //    bool vrecebido = recebimento.SetValorRecebido(txtRecebidoValor.Text);
            //    bool vforma = recebimento.SetFormaRecebimento(cmbFormaRcebimento.SelectedItem.ToString());
            //    if (!vtipo | !vrecebido | !vforma)
            //    {
            //        MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
            //    }
            //    else if (Program.ObjHope.Caixa.Recebimento.GravarRegistro(recebimento))
            //    {
            //        MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
            //    }
            //    else
            //    {
            //        MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
            //    }

            //}
            //else
            //{
            //    MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
            //}
        }
        private void btnFiltraCliente_Click(object sender, EventArgs e)
        {
            //bool vfilrto = Program.ObjHope.Cliente.Localizar(Orden: cmbOrdenConsultaCliente.SelectedItem.ToString(), Comando: cmbColunaConsultaCliente.SelectedItem.ToString(), Coluna: cmbColunaConsultaCliente.SelectedItem.ToString(), Limit: numLimitConsultaCliente.Value, Termo: txtTermoCliente.Text, ListaResultado: out Hope.Entidade.IComprador_Ent_c[] listaResultado);

            //if (vfilrto)
            //{
            //    iClienteEntcBindingSource.DataSource = listaResultado;

            //}
            //else
            //{
            //    MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());

            //}
        }

        private void btnAdcionarCliente_Click(object sender, EventArgs e)
        {
            //bool vselec = Program.ObjHope.Cliente.SelecionaRegistro(dgvListaCliente.SelectedRows);
            //if (vselec)
            //{
            //    if (Program.ObjHope.Caixa.Recebimento.AdicionarCliente())
            //    {
            //        lblClienteRes.Text = Program.ObjHope.Caixa.Recebimento.Cliente;
            //        txtRecebidoValor.Text = Program.ObjHope.Caixa.Recebimento.Cliente_Conta_Valor;
            //    }
            //    else
            //    {
            //        MessageBox.Show(Program.ObjHope.Caixa.Recebimento.Informacao.ToMessageBox());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(Program.ObjHope.Cliente.Informacao.ToMessageBox());
            //}
        }
    }
}
