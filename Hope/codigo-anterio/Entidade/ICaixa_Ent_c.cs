using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface ICaixa_Ent_c
    {
        int ID_Caixa { get; }
        int ID_Colaborador { get;  }
        string Dia_Hora_Abertura { get;  }
        string Dia_Hora_Fechamento { get;  }
       
    }
}
