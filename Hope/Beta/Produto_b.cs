using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Produto_b : Controle.Produto_abs
    {
        public Produto_b()
        {
            ListaResultado = new List<Controle.Produto_Ent_abs>();
            _FocusRegistro = new Beta.Produto_Ent_b();
            _NovoRegistro = new Beta.Produto_Ent_b();

        }
        internal override bool InsertRegistro()
        {
            HopeDataSet.ProdutoRow produtoRow = Hope.localSet.Produto.NewProdutoRow();
            produtoRow.EAN = _NovoRegistro._EAN;
            produtoRow.Descricao = _NovoRegistro._Descricao;
            produtoRow.Unidade = _NovoRegistro._Unidade;
            produtoRow.Custo = _NovoRegistro._Custo;
            produtoRow.Venda = _NovoRegistro._Venda;
            Hope.localSet.Produto.Rows.Add(produtoRow);
            Hope.informacao.Add("000", ListMsg.msg001);

            return true;
        }
        internal override bool Select_All_From()
        {
            if (Hope.localSet.Produto.Count != 0)
            {
                for (int i = 0; i < Hope.localSet.Produto.Count; i++)
                {
                    ListaResultado.Add(new Beta.Produto_Ent_b()
                    {
                        _ID_Produto = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("ID_Produto")].ToString(),
                        _EAN = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("EAN")].ToString(),
                        _Descricao = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Descricao")].ToString(),
                        _Unidade = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Unidade")].ToString(),
                        _Custo = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Custo")].ToString(),
                        _Venda = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Venda")].ToString()
                    });
                }
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "Tabela vazia");
                return false;
            }
        }
        internal override bool UpdateRegistro()
        {
            for (int i = 0; i < Hope.localSet.Produto.Count; i++)
            {
                HopeDataSet.ProdutoRow produtoRow = Hope.localSet.Produto.Rows[i] as HopeDataSet.ProdutoRow;
                if (produtoRow.ID_Produto == int.Parse(_FocusRegistro._ID_Produto))
                {
                    produtoRow.EAN = _NovoRegistro._EAN;
                    produtoRow.Descricao = _NovoRegistro._Descricao;
                    produtoRow.Unidade = _NovoRegistro._Unidade;
                    produtoRow.Custo = _NovoRegistro._Custo;
                    produtoRow.Venda = _NovoRegistro._Venda;

                    return true;
                }

            }
            return false;
        }
    }
}
