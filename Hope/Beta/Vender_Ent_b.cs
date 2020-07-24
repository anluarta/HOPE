using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Vender_Ent_b : Controle.Vender_Ent_abs
    {
        public Vender_Ent_b()
        {
            _ID_Vender = 0;
            _ID_Caixa = 0;
            _ID_Colaborador = 0;
            _ID_Comprador = 0;
            _Dia_Hora_Abertura = string.Empty;
        }
    }
}
