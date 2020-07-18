using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Cupom_Pagar_b:Controle.Cupom_Pagar_abs
    {
        public Cupom_Pagar_b()
        {
            _NovoRegistro = new Cupom_Pagar_Ent_b();
        }
    }
}
