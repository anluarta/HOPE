using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface ICupom_Ent_c
    {
        string ID_Cupom { get; }
        string ID_Caixa { get; }
        string Hora { get; }
        string Colaborador { get; }
    }
}
