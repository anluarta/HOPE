using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface IProduto
    {
        string ID_Produto { get; set; }
        string EAN { get; set; }
        string Descricao { get; set; }
        string Unidade { get; set; }
        string Custo { get; set; }
        string Venda { get; set; }

    }
}
