using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface ICaixa_Ent_c
    {
        string ID_Caixa { get; }
        string Fk_ID_Usuario { get;  }
        string Abertura { get;  }
        string Fechamento { get;  }
       
    }
}
