using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface IProduto_Ent_c
    {
        string ID_Produto { get; }
        string EAN { get; }
        string Descricao { get; }
        string Unidade { get; }
        string Custo { get; }
        string Venda { get; }
        bool Set_EAN(string Valor);
        bool Set_Descricao(string Valor);
        bool Set_Unidade(string Valor);
        bool Set_Custo(string Valor);
        bool Set_Venda(string Valor);
    }
}
