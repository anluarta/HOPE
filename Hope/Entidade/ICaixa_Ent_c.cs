using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface ICaixa_Ent_c
    {
        string ID_Caixa { get; set; }
        string Fk_ID_Usuario { get; set; }
        string Abertura { get; set; }
        string Fechamento { get; set; }
       
    }
}
