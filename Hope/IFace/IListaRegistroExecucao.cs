using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.IFace
{
   public interface IListaRegistroExecucao
    {
        TimeSpan tempo { get; set; }
        String Acao { get; set; }
        String Resultado { get; set; }
    }
}
