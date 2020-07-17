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
    public partial class ProdutoNovo : UserControl
    {
        public ProdutoNovo()
        {
            InitializeComponent();
            cmbUnidade.Items.Clear();
            cmbUnidade.Items.AddRange(Program.ObjHope.ArrayProdutoTipoUnidade);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            Program.ObjHope.Produto.Set_EAN(txtxEAN.Text);
            Program.ObjHope.Produto.Set_Descricao(txtDescricao.Text);
            Program.ObjHope.Produto.Set_Custo(txtCusto.Text);
            Program.ObjHope.Produto.Set_Unidade(cmbUnidade.SelectedText.ToString());
            Program.ObjHope.Produto.Set_Venda(txtVenda.Text);
           
            btnVoltar.PerformClick();
        }
    }
}
