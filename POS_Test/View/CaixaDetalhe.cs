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
    public partial class CaixaDetalhe : UserControl
    {
        public CaixaDetalhe()
        {
            InitializeComponent();
        }
        public void LoadICaixaTotal(Hope.Entidade.ICaixaTotal_Ent_c caixaTotal)
        {
            lbltotContaCliente.Text = string.Format(lbltotContaCliente.Text, caixaTotal.ContaCliente);
            lbltotCredito.Text = string.Format(lbltotCredito.Text, caixaTotal.Credito);
            lbltotDebito.Text = string.Format(lbltotDebito.Text, caixaTotal.Debito);
            lbltotDinheiro.Text = string.Format(lbltotDinheiro.Text, caixaTotal.Dinheiro);
            lbltotInterno.Text = string.Format(lbltotInterno.Text, caixaTotal.Interno);
            lbltotOutro.Text = string.Format(lbltotOutro.Text, caixaTotal.Outro);
            lbltotRecebimento.Text = string.Format(lbltotRecebimento.Text, caixaTotal.Recebimento);
            lbltotReforco.Text = string.Format(lbltotReforco.Text, caixaTotal.Reforco);
            lbltotSangria.Text = string.Format(lbltotSangria.Text, caixaTotal.Sangria);
            lbltotValeAlimentacao.Text = string.Format(lbltotValeAlimentacao.Text, caixaTotal.ValeAlimentacao);
            lbltotValeRefeicao.Text = string.Format(lbltotValeRefeicao.Text, caixaTotal.ValeRefeicao);
            
            lblTotCupomCancel.Text = string.Format(lblTotCupomCancel.Text, caixaTotal.CupomCancelado);
            lbltotCupom.Text = string.Format(lbltotCupom.Text, caixaTotal.CupomVendido);

        }
    }
}
