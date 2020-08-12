using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
   public interface ICaixa
    {
        string Notifica();
        ICaixa_e Novo();
        bool Gravar(ICaixa_e entidade);
        ICaixa_e Select(object current);
        IConsulta Consulta { get; }
        ICaixa_e[] Find(IConsulta consulta);
        ISuprimento_e Suprimento_Novo(ICaixa_e entidade);
        ISangria_e Sangria_Novo(ICaixa_e entidade);
        ISuprimento Suprimento { get; }
        ISangria Sangria { get; }

    }
}
