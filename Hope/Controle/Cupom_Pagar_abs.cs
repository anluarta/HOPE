using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class Cupom_Pagar_abs : Contrato.ICupom_Pagar_c
    {
        internal Controle.Cupom_Pagar_Ent_abs _NovoRegistro;
        IInformacao_c ICupom_Pagar_c.Informacao => throw new NotImplementedException();

        ICupom_Pagar_Ent_c ICupom_Pagar_c.FocusEntidade => _NovoRegistro;

        bool ICupom_Pagar_c.GravarRegistro(ICupom_Pagar_Ent_c pagar)
        {
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_c.NovoRegistro(out ICupom_Pagar_Ent_c pagar)
        {
            throw new NotImplementedException();
        }
    }
}
