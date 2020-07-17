
using Hope.Contrato;
using Hope.Controle;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Cupom_abs : Contrato.ICupom_c
    {
        IInformacao_c ICupom_c.Informacao => throw new NotImplementedException();

        ICupom_Ent_c ICupom_c.FocusEntidade => throw new NotImplementedException();

        ICupomCliente_Ent_c ICupom_c.Cliente => throw new NotImplementedException();

        ICupomItem_Ent_c[] ICupom_c.Item => throw new NotImplementedException();

        ICupomPagar_Ent_c ICupom_c.Pagar => throw new NotImplementedException();

        bool ICupom_c.FinalizarRegistro()
        {
            throw new NotImplementedException();
        }

        bool ICupom_c.GravarEstadoRegistro()
        {
            throw new NotImplementedException();
        }

        bool ICupom_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out ICupom_Ent_c[] ListaRegistro)
        {
            throw new NotImplementedException();
        }

        bool ICupom_c.NovoRegistro()
        {
            throw new NotImplementedException();
        }

        bool ICupom_c.SelecionaRegistro(object _Selecionado)
        {
            throw new NotImplementedException();
        }

        bool ICupom_c.VerRegistro(object selectIten, out ICupom_Ent_c cupom, out ICupomCliente_Ent_c cliente, out ICupomItem_Ent_c[] item, out ICupomPagar_Ent_c pagar)
        {
            throw new NotImplementedException();
        }
    }
}
