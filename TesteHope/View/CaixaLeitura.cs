using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteHope.View
{
    public partial class CaixaLeitura : UserControl
    {
        public CaixaLeitura()
        {
            InitializeComponent();
        }
        public CaixaLeitura(Hope.Interface.ICaixa_e caixa):this()
        {
            lblCheque.Text = caixa.Cheque();
            lblColaborador.Text = caixa.Get_Colaborador;
            lblCredito.Text = caixa.Credito();
            lblDebito.Text = caixa.Debito();
            lblDinheiro.Text = caixa.Dinheiro();
            lblFinish.Text = caixa.Get_finish_DateTime;
            lblID.Text = caixa.Get_ID;
            lblInterno.Text = caixa.Interno();
            lblOutro.Text = caixa.Outro();
            lblSangria.Text = caixa.Sangria();
            lblStart.Text = caixa.Get_Start_DateTime;
            lblSuprimento.Text = caixa.Suprimento();
            lblValeAlimentacao.Text = caixa.Vale_Alemintacao();
            lblValeRefeicao.Text = caixa.Vale_Refeicao();
        }
    }
}
