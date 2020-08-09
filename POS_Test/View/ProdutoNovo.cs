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
            try
            {
                Hope.Interface.IProduto_e produto = Program.ObjHope.BackOffice.Produto.Novo();
                Hope.Interface.IPreco Preco = Program.ObjHope.BackOffice.Produto.Preco(produto);
                Hope.Interface.ICodigo codigo = Program.ObjHope.BackOffice.Produto.Codigo(produto);

                bool v1 = produto.Set_Descricao(txtDescricao.Text);
                bool v2 = produto.Set_Unidade(cmbUnidade.Text);
                if (!v1 | !v2)
                {
                    produto.Notifica();
                    return;
                }
                Hope.Interface.IPreco_e entidade = Preco.Novo();
                bool v3 = entidade.Set_Custo(numCusto.Value);
                bool v4 = entidade.Set_Venda(numVenda.Value);
                if (!v3 | !v4)
                {
                    entidade.Notifica();
                    return;
                }
                bool v5 = Preco.Add(entidade);
                if (!v5)
                {
                    Preco.Notifica();
                    return;
                }
                bool v6 = Preco.Gravar(ref produto);
                if (!v6)
                {
                    Preco.Notifica();
                    return;
                }
                bool v7 = codigo.Set_Codigo_Interno(txtCodigoInterno.Text);
                bool v8 = codigo.Set_Codigo_Barra(txtCodigoBarra.Text);
                if (!v7 | !v8)
                {
                    codigo.Notifica();
                    return;
                }

                bool v0 = Program.ObjHope.BackOffice.Produto.Gravar(ref produto);
                if (v0)
                {
                    btnVoltar.PerformClick();
                }
                else
                {
                    Program.ObjHope.BackOffice.Produto.Notifica();
                }
            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
                throw;
            }
        }
    }
}
