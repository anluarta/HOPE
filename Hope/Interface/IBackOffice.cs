using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
    /// <summary>
    /// internface que da acesso ao CRUD
    /// </summary>
   public interface IBackOffice
    {
        /// <summary>
        /// acesso ao colaborador
        /// </summary>
        IColaborador Colaborador { get; }
        IComprador Comprador { get; }
        IProduto Produto { get; }
    }
}
