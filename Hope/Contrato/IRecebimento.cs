using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Contrato
{
    public interface IRecebimento
    {
        bool SetTipoRecebimento(string v, out string msgResult);
        bool SetValorRecebido(string text, out string msgrecebido);
        bool SetFormaRecebimento(string v, out string msgforma);
        bool GravarRecebimento(out string msggravar);
        bool LocalizaContaCliente(string v, string text, out string msgcontacliente);
    }
}
