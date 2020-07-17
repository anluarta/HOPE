using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Produto_b : Controle.Produto_abs
    {
        internal override bool Insert()
        {
            HopeDataSet.ProdutoRow produtoRow = Hope.localSet.Produto.NewProdutoRow();
            produtoRow.EAN = _SetEntidade. EAN;
            produtoRow.Descricao = _SetEntidade.Descricao;
            produtoRow.Unidade = _SetEntidade.Unidade;
            produtoRow.Custo = _SetEntidade.Custo;
            produtoRow.Venda = _SetEntidade.Venda;
            Hope.localSet.Produto.Rows.Add(produtoRow);
          Hope.informacao.Add("000",ListMsg.msg001);
            
            return true;
            throw new NotImplementedException();
        }
        internal override bool SelectAll()
        {
            if (Hope.localSet.Produto.Count != 0)
            {
               
                for (int i = 0; i < Hope.localSet.Produto.Count; i++)
                {
                    _DataResultado[i] = new Beta.Produto_Ent_b()
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
            for (int i = 0; i < Hope.localSet.Produto.Count; i++)
            {
                HopeDataSet.ProdutoRow produtoRow = Hope.localSet.Produto.Rows[i] as HopeDataSet.ProdutoRow;
                if (produtoRow.ID_Produto==int.Parse(_FocusEntidade.ID_Produto))
                {
                    produtoRow.EAN = _SetEntidade.EAN;
                    produtoRow.Descricao = _SetEntidade.Descricao;
                    produtoRow.Unidade = _SetEntidade.Unidade;
                    produtoRow.Custo = _SetEntidade.Custo;
                    produtoRow.Venda = _SetEntidade.Venda;
                
                    return true;
                }

            }
            throw new NotImplementedException();
        }
    }
}
