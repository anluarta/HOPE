using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Abs
{
    class Recebimento : Contrato.IRecebimento
    {
        public bool GravarRecebimento(out string msggravar)
        {
            throw new NotImplementedException();
        }

        public bool LocalizaContaCliente(string v, string text, out string msgcontacliente)
        {
            throw new NotImplementedException();
        }

        public bool SetFormaRecebimento(string v, out string msgforma)
        {
            throw new NotImplementedException();
        }

        public bool SetTipoRecebimento(string v, out string msgResult)
        {
            throw new NotImplementedException();
        }

        public bool SetValorRecebido(string text, out string msgrecebido)
        {
            throw new NotImplementedException();
        }
    }
}
