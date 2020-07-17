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
            if (Program.ObjHope.Caixa.Recebimento.NovoRegistro(out Hope.Entidade.IRecebimento_Ent_c recebimento))
            {
                bool vtipo = recebimento.SetTipoRecebimento(cmbRecebimento.SelectedItem.ToString());
                bool vrecebido = recebimento.SetValorRecebido(txtRecebidoValor.Text);
                bool vforma = recebimento.SetFormaRecebimento(cmbFormaRcebimento.SelectedItem.ToString());
                if (!vtipo|!vrecebido|!vforma)
                {
                    MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
                }
                else if (Program.ObjHope.Caixa.Recebimento.GravarRegistro(recebimento))
                {
                    MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
                }

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
            }
        }

        private void btnLocalizarCliente_Click(object sender, EventArgs e)
        {
            bool vloccontclien = Program.ObjHope.Caixa.Recebimento.AddContaCliente(txtCliente.Text);
            

        }
    }
}
