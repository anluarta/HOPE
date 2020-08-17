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
    public partial class Pagamento : UserControl
    {
        Hope.Interface.IPagar_e entidade;
        public Pagamento()
        {
            InitializeComponent();
            if (Program.ObjHope.Pos.Vender.Pagar_Novo(Program.Vender, out entidade))
            {
              
            }
            else
            {
                lblresultado.Text = Program.ObjHope.Pos.Vender.Notificar();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            bool v10 = Program.Vender.Add(entidade);
            if (v10)
            {
                MessageBox.Show(Program.Vender.Notifica());
                btnfechar.PerformClick();
            }
            else
            {
                lblresultado.Text = Program.Vender.Notifica();
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            List<bool> vs = new List<bool>();
            vs.Add(entidade.Set_Dinheiro(txtdinheiro.Text));
            vs.Add(entidade.Set_Debito(txtdebito.Text));
            vs.Add(entidade.Set_Credito(txtCredito.Text));
            vs.Add(entidade.Set_Cheque(txtCheque.Text));
            vs.Add(entidade.Set_Vale_Alimentacao(txtAlimentacao.Text));
            vs.Add(entidade.Set_Vale_Refeicao(txtRefeicao.Text));
            vs.Add(entidade.Set_Outro(txtOutro.Text));
            vs.Add(entidade.Set_Interno(txtInterno.Text));
            vs.Add(entidade.Set_Desconto(txtDesconto.Text));
            if (vs.Find(x=>x == false))
            {
                txtresultado.AppendText(entidade.Noticia());
            }
            brutoTextBox.Text=entidade.Bruto.ToString();
            chequeTextBox.Text=entidade.Cheque.ToString();
            cobradoTextBox.Text=entidade.Cobrado.ToString();
            creditoTextBox.Text=entidade.Credito.ToString();
            debitoTextBox.Text=entidade.Debito.ToString();
            descontoTextBox.Text=entidade.Desconto.ToString();
            dinheiroTextBox.Text=entidade.Dinheiro.ToString();
            internoTextBox.Text=entidade.Interno.ToString();
            outroTextBox.Text=entidade.Outro.ToString();
            recebidoTextBox.Text=entidade.Recebido.ToString();
            trocoTextBox.Text=entidade.Troco.ToString();
            vale_AlimentacaoTextBox.Text=entidade.Vale_Alimentacao.ToString();
            vale_RefeicaoTextBox.Text=entidade.Vale_Refeicao.ToString();
        }
    }
}
