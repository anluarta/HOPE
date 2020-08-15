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
            if (Program.ObjHope.Pos.Vender.Pagar_Novo(Program.Vender, out Hope.Interface.IPagar_e entidade))
            {
                bool v1 = entidade.Set_Dinheiro(txtdinheiro.Text);
                bool v2 = entidade.Set_Debito(txtdinheiro.Text);
                bool v3 = entidade.Set_Credito(txtdinheiro.Text);
                bool v4 = entidade.Set_Cheque(txtdinheiro.Text);
                bool v5 = entidade.Set_Vale_Alimentacao(txtdinheiro.Text);
                bool v6 = entidade.Set_Vale_Refeicao(txtdinheiro.Text);
                bool v7 = entidade.Set_Outro(txtdinheiro.Text);
                bool v8 = entidade.Set_Interno(txtdinheiro.Text);
                bool v9 = entidade.Set_Desconto(txtdinheiro.Text);
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
            else
            {
                lblresultado.Text = Program.ObjHope.Pos.Vender.Notificar();
            }
        }
    }
}
