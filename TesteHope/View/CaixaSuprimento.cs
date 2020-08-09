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
    public partial class CaixaSuprimento : UserControl
    {
        public CaixaSuprimento()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hope.Interface.ISuprimento_e entidade = Program.ObjHope.Pos.Caixa.Suprimento(Program.CaixaOperacao);
            bool v1 = entidade.Set_Valor(valor: txtValor.Text);
            bool v2 = entidade.Set_Observacao(observacao: txtObservacao.Text);
            if (v1&v2)
            {
                bool v3 = Program.CaixaOperacao.Add(entidade);
                if (v3)
                {
                    bool v4 = Program.ObjHope.Pos.Caixa.Gravar(Program.CaixaOperacao);
                    if (v4)
                    {
                        MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());
                        btnfechar.PerformClick();
                    }
                    else
                    {
                        lblresultado.Text = Program.ObjHope.Pos.Caixa.Notifica();
                    }
                }
                else
                {
                    lblresultado.Text = Program.CaixaOperacao.Notifica();
                }
            }
            else
            {
                lblresultado.Text = entidade.Notifica();
            }
        }
    }
}
