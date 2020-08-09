using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
   public class BackOffice : IBackOffice
    {
        public IColaborador Colaborador =>null/* Hope_static.Colaborador*/;

        public IComprador Comprador =>null/* Hope_static.Comprador*/;

        public IProduto Produto => /*Hope_static.Produto*/null;
    }
}
