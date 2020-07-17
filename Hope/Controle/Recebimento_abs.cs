using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Recebimento_abs : Contrato.IRecebimento_c
    {
        IInformacao_c IRecebimento_c.Informacao => throw new NotImplementedException();

        Entidade.IRecebimento_Ent_c IRecebimento_c.FocusEntidade => throw new NotImplementedException();

        bool IRecebimento_c.GravarRegistro(Entidade.IRecebimento_Ent_c usuario)
        {
            throw new NotImplementedException();
        }

        bool IRecebimento_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.IRecebimento_Ent_c[] ListaRegistro)
        {
            throw new NotImplementedException();
        }

        bool IRecebimento_c.NovoRegistro(out Entidade.IRecebimento_Ent_c usuario)
        {
            throw new NotImplementedException();
        }

        bool IRecebimento_c.SelecionaRegistro(object _Selecionado)
        {
            throw new NotImplementedException();
        }
    }
}
