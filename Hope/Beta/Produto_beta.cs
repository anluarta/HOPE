using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Produto_beta : AbsProduto
    {
        internal override bool Insert()
        {
            HopeLocalDB_DEBUG.ProdutoRow produtoRow = AbsHope.LocalDB_DEBUG.Produto.NewProdutoRow();
            produtoRow.EAN = _SetEntidade. EAN;
            produtoRow.Descricao = _SetEntidade.Descricao;
            produtoRow.Unidade = _SetEntidade.Unidade;
            produtoRow.Custo = _SetEntidade.Custo;
            produtoRow.Venda = _SetEntidade.Venda;
            AbsHope.LocalDB_DEBUG.Produto.Rows.Add(produtoRow);
           MsgResult = ListMsg.msg001;
            Clear();
            return true;
            throw new NotImplementedException();
        }
        internal override bool SelectAll()
        {
            if (AbsHope.LocalDB_DEBUG.Produto.Count != 0)
            {
                _DataResultado = new Entidade.IProduto[AbsHope.LocalDB_DEBUG.Produto.Count];
                for (int i = 0; i < AbsHope.LocalDB_DEBUG.Produto.Count; i++)
                {
                    _DataResultado[i] = new Entidade.Produto()
                    {
                        ID_Produto = AbsHope.LocalDB_DEBUG.Produto.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Produto.Columns.IndexOf("ID_Produto")].ToString(),
                        EAN = AbsHope.LocalDB_DEBUG.Produto.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Produto.Columns.IndexOf("EAN")].ToString(),
                        Descricao = AbsHope.LocalDB_DEBUG.Produto.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Produto.Columns.IndexOf("Descricao")].ToString(),
                        Unidade = AbsHope.LocalDB_DEBUG.Produto.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Produto.Columns.IndexOf("Unidade")].ToString(),
                        Custo = AbsHope.LocalDB_DEBUG.Produto.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Produto.Columns.IndexOf("Custo")].ToString(),
                        Venda = AbsHope.LocalDB_DEBUG.Produto.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Produto.Columns.IndexOf("Venda")].ToString()
                    };
                }
                return true;
            }
            else
            {
                MsgResult = "Tabela vazia";
                return false;
            }
            throw new NotImplementedException();
        }
        internal override bool Update()
        {
            for (int i = 0; i < AbsHope.LocalDB_DEBUG.Produto.Count; i++)
            {
                HopeLocalDB_DEBUG.ProdutoRow produtoRow = AbsHope.LocalDB_DEBUG.Produto.Rows[i] as HopeLocalDB_DEBUG.ProdutoRow;
                if (produtoRow.ID_Produto==int.Parse(_FocusEntidade.ID_Produto))
                {
                    produtoRow.EAN = _SetEntidade.EAN;
                    produtoRow.Descricao = _SetEntidade.Descricao;
                    produtoRow.Unidade = _SetEntidade.Unidade;
                    produtoRow.Custo = _SetEntidade.Custo;
                    produtoRow.Venda = _SetEntidade.Venda;
                    Clear();
                    return true;
                }

            }
            throw new NotImplementedException();
        }
    }
}
