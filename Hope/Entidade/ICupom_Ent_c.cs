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
        string Dia_Hora_Abertura { get; }
        string Dia_Hora_Fechamento { get; }
        string ID_Usuario { get; }
        string Cliente { get; }

    }
}
