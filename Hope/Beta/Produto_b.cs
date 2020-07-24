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
           
            _FocusRegistro = new Beta.Produto_Ent_b();
            _NovoRegistro = new Beta.Produto_Ent_b();
            _AlteraRegistro = new Beta.Produto_Ent_b();
        }

        protected override bool focus_update_registro()
        {
            for (int i = 0; i < Hope.localSet.Produto.Count; i++)
            {
                HopeDataSet.ProdutoRow produtoRow = Hope.localSet.Produto.Rows[i] as HopeDataSet.ProdutoRow;
                if (produtoRow.ID_Produto == _FocusRegistro._ID_Produto)
                {
                    produtoRow.EAN = _AlteraRegistro._EAN;
                    produtoRow.Descricao = _AlteraRegistro._Descricao;
                    produtoRow.Unidade = _AlteraRegistro._Unidade;
                    produtoRow.Custo = _AlteraRegistro._Custo;
                    produtoRow.Venda = _AlteraRegistro._Venda;

                    return true;
                }
            }
            return false;
        }

        protected override bool novo_insert_registro()
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

        protected override bool select_all_from_registro(out Entidade.IProduto_Ent_c[] produto_Ents)
        {
            if (Hope.localSet.Produto.Count != 0)
            {
                List<Entidade.IProduto_Ent_c> list = new List<Entidade.IProduto_Ent_c>();
                for (int i = 0; i < Hope.localSet.Produto.Count; i++)
                {
                    list.Add(new Produto_Ent_b()
                    {
                        _ID_Produto = (int)Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("ID_Produto")],
                        _EAN = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("EAN")].ToString(),
                        _Descricao = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Descricao")].ToString(),
                        _Unidade = Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Unidade")].ToString(),
                        _Custo = (decimal)Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Custo")],
                        _Venda = (decimal)Hope.localSet.Produto.Rows[i]
                        [Hope.localSet.Produto.Columns.IndexOf("Venda")]
                    });
                }
                produto_Ents = list.ToArray();
                return true;
            }
            else
            {
                produto_Ents = new Produto_Ent_b[0];
                Hope.informacao.Add("000", "Tabela vazia");
                return false;
            }
        }
    }
}
