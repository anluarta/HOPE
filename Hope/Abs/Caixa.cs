using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    abstract class AbsCaixa : Contrato.ICaixa
    {
        public bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo)
        {
            throw new NotImplementedException();
        }

        public abstract bool NovoCaixa();

        public abstract bool Sangria(string _Valor, string _Observacao);

        public abstract bool Suprimento(string _Valor);

        public bool TodaLista()
        {
            throw new NotImplementedException();
        }
    }
}
