using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Produto_Ent_b : Controle.Produto_Ent_abs
    {
        public Produto_Ent_b()
        {
            _ID_Produto = 0;
            _EAN = string.Empty;
            _Descricao = string.Empty;
            _Unidade = string.Empty;
            _Custo = 0;
            _Venda = 0;
        }
    }
}
