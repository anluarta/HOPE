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
        ICaixa_e Find(IConsulta consulta);
        ISuprimento_e Suprimento(ICaixa_e entidade);
        ISangria_e Sangria(ICaixa_e entidade);


    }
}
