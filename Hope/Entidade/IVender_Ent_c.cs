using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface IVender_Ent_c
    {
        int ID_Vender { get; }
        int ID_Caixa { get; }
        int ID_Colaborador { get; }
        int ID_Comprador { get; }
        string Dia_Hora_Abertura { get; }
        string Dia_Hora_Fechamento { get; }

    }
}
