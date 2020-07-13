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
            cmbLocalConsultaCliente.Items.AddRange(Program.ObjHope.GetClienteLocalConsulta());
            cmbFormaRcebimento.Items.AddRange(Program.ObjHope.GetListaFormaRecebimento());
            cmbRecebimento.Items.AddRange(Program.ObjHope.GetListaTipoRecebimento());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
           bool vtipo= Program.ObjHope.Caixa.Recebimento.SetTipoRecebimento(cmbRecebimento.SelectedItem.ToString(), out string MsgResult);
            bool vrecebido = Program.ObjHope.Caixa.Recebimento.SetValorRecebido(txtRecebidoValor.Text, out string msgrecebido);
            bool vforma = Program.ObjHope.Caixa.Recebimento.SetFormaRecebimento(cmbFormaRcebimento.SelectedItem.ToString(), out string msgforma);
            bool vgravar = Program.ObjHope.Caixa.Recebimento.GravarRecebimento(out string msggravar);
            if (vtipo&vrecebido&vgravar&vforma)
            {
                MessageBox.Show(msggravar);
                btnVoltar.PerformClick();
            }
            else
            {
                lblRecebimentoRes.Text = MsgResult;
                lblRecebidoREs.Text = msgrecebido;
                lblFormaRes.Text = msgforma;
                MessageBox.Show(msggravar);

            }
        }

        private void btnLocalizarCliente_Click(object sender, EventArgs e)
        {
            bool vloccontclien = Program.ObjHope.Caixa.Recebimento.LocalizaContaCliente(cmbLocalConsultaCliente.SelectedItem.ToString(), txtCliente.Text, out string msgcontacliente);
                lblClienteRes.Text = msgcontacliente;
            
        }
    }
}
