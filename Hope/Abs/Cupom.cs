
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    abstract class AbsCupom : Contrato.ICupom
    {
        public bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo)
        {
            throw new NotImplementedException();
        }

        public abstract bool NovoCupom(string _ID_Caixa, string _ID_Usuario);

        public bool TodaLista()
        {
            throw new NotImplementedException();
        }
    }
}
