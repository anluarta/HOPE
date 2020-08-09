using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
    /// <summary>
    /// Ponto de Venda
    /// </summary>
   public interface IPos
    {
        IVender Vender { get; }

        ICaixa Caixa { get; }
    }
}
