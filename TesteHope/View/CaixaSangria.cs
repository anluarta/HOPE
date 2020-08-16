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
    public partial class CaixaSangria : UserControl
    {
        public CaixaSangria()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Pos.Caixa.Sangria_Novo(Program.CaixaOperacao, out Hope.Interface.ISangria_e entidade))
            {
                if (entidade != null)
                {
                    bool v1 = entidade.Set_Valor(valor: txtValor.Text);
                    bool v2 = entidade.Set_Observacao(obsevacao: txtObservacao.Text);
                    if (v1 & v2)
                    {
                        bool v3 = Program.CaixaOperacao.Add(entidade);
                        if (v3)
                        {
                            bool v4 = Program.ObjHope.Pos.Caixa.Gravar(Program.CaixaOperacao, out Program.CaixaOperacao);
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
                else
                {
                    MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());

                }
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());

            }
        }
    }
}
