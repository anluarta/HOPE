using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Produto_Ent_abs : IProduto_Ent_c
    {

        internal int _ID_Produto;
        internal string _EAN;
        internal string _Descricao;
        internal string _Unidade;
        internal decimal _Custo;
        internal decimal _Venda;
        internal void Clea()
        {
            _ID_Produto = 0;
            _EAN = string.Empty;
            _Descricao = string.Empty;
            _Unidade = string.Empty;
            _Custo = 0;
            _Venda = 0;
        }
        int IProduto_Ent_c.ID_Produto => _ID_Produto;

        string IProduto_Ent_c.EAN => _EAN;

        string IProduto_Ent_c.Descricao => _Descricao;

        string IProduto_Ent_c.Unidade => _Unidade;

        decimal IProduto_Ent_c.Custo => _Custo;

        decimal IProduto_Ent_c.Venda => _Venda;

    

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

        bool IProduto_Ent_c.Set_Venda(decimal Valor)
        {
            _Venda = (Valor);
            return true;
        }
        bool IProduto_Ent_c.Set_Custo(decimal Valor)
        {
            _Custo = (Valor);
            return true;
        }
    }
}
