using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Comprador_Ent_b : Comprador_Ent_abs
    {
        public Comprador_Ent_b()
        {
            _Id_Comprador = 0;
            _NomeCompleto_RazaoSocial = string.Empty;
            _Numero_Registro = string.Empty;
            _Tipo = ListEnum.TipoComprador.Fisico;
        }
    }
}
