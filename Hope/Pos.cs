using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
   public class Pos : IPos
    {
        public ICaixa Caixa => Hope_static.Caixa;

        public IVender Vender => Hope_static.Venda;
    }
}
