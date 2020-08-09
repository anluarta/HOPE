using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
   public interface IConsulta
    {
        Enums.Consulta_u.Comando Comando { get; set; }
        object Local { get; set; }
        object Termo { get; set; }

    }
}
