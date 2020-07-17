using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class Produto_Ent_abs : Entidade.IProduto_Ent_c
    {

        internal string _ID_Produto;
        internal string _EAN;
        internal string _Descricao;
        internal string _Unidade;
        internal string _Custo;
        internal string _Venda;

        string IProduto_Ent_c.ID_Produto => _ID_Produto;

        string IProduto_Ent_c.EAN => _EAN;

        string IProduto_Ent_c.Descricao => _Descricao;

        string IProduto_Ent_c.Unidade => _Unidade;

        string IProduto_Ent_c.Custo => _Custo;

        string IProduto_Ent_c.Venda => _Venda;

        bool IProduto_Ent_c.Set_Custo(string Valor)
        {
            _Custo = Valor;
            return true;
        }

        bool IProduto_Ent_c.Set_Descricao(string Valor)
        {
            _Descricao = Valor;
            return true;
        }

        bool IProduto_Ent_c.Set_EAN(string Valor)
        {
            _EAN = Valor;
            return true;
        }

        bool IProduto_Ent_c.Set_Unidade(string Valor)
        {
            _Unidade = Valor;
            return true;
        }

        bool IProduto_Ent_c.Set_Venda(string Valor)
        {
            _Venda = Valor;
            return true;
        }
    }
}
