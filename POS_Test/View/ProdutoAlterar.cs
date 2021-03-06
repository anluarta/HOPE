﻿using System;
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
    public partial class ProdutoAlterar : UserControl
    {
        public ProdutoAlterar()
        {
            InitializeComponent();
            cmbUnidade.Items.Clear();
            cmbUnidade.Items.AddRange(Program.ObjHope.ArrayProdutoTipoUnidade);
            Hope.Entidade.IProduto_Ent_c produto = Program.ObjHope.Produto.FocusEntidade;
            txtDescricao.Text = produto.Descricao;
            txtxEAN.Text = produto.EAN;
            cmbUnidade.Text = produto.Unidade;
            numCusto.Value = produto.Custo;
            numVenda.Value = produto.Venda;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Produto.AlteraRegistro(out Hope.Entidade.IProduto_Ent_c produto);
            bool bean = produto.Set_EAN(txtxEAN.Text);
            bool bdescricao = produto.Set_Descricao(txtDescricao.Text);
            bool bcusto = produto.Set_Custo(numCusto.Value);
            bool bunidade = produto.Set_Unidade(cmbUnidade.SelectedText.ToString());
            bool bVenda = produto.Set_Venda(numVenda.Value);
            if (!bcusto | !bdescricao | !bean | !bunidade | !bVenda)
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
                return;
            }
            else if (Program.ObjHope.Produto.GravaAlteracao(produto))
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
                btnVoltar.PerformClick();
                return;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
                return;
            }
        }
    }
}
