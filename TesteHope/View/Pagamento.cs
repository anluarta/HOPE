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
        public Pagamento()
        {
            InitializeComponent();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Hope.Interface.IPagar_e entidade = Program.ObjHope.Pos.Vender.Pagar(Program.Vender);
            bool v1 = entidade.Set_Dinheiro(valor: txtdinheiro.Text);
            bool v2 = entidade.Set_Debido(valor: txtdinheiro.Text);
            bool v3 = entidade.Set_Credito(valor: txtdinheiro.Text);
            bool v4 = entidade.Set_Cheque(valor: txtdinheiro.Text);
            bool v5 = entidade.Set_Vale_Alimentacao(valor: txtdinheiro.Text);
            bool v6 = entidade.Set_Vale_Refeicao(valor: txtdinheiro.Text);
            bool v7 = entidade.Set_Outro(valor: txtdinheiro.Text);
            bool v8 = entidade.Set_Interno(valor: txtdinheiro.Text);
            bool v9 = entidade.Set_Desconto(valor: txtdinheiro.Text);
            bool v10 = Program.Vender.Pagarmento(entidade);
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
    }
}
