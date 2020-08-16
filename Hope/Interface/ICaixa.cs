using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
   public interface ICaixa
    {
        string Notifica();
        bool Novo(out ICaixa_e caixa_);
        bool Gravar(ICaixa_e entidade, out ICaixa_e result);
        
        IConsulta Consulta();
        bool Find(IConsulta consulta,out ICaixa_e[] caixa_s);
        
        bool Suprimento_Novo(ICaixa_e entidade,out ISuprimento_e suprimento_);
        bool Sangria_Novo(ICaixa_e entidade,out ISangria_e sangria_);

        bool Select(object current,out ICaixa_e caixa_);
        bool Print_Document(ICaixa_e caixa_, out PrintDocument document);

        ISuprimento Suprimento { get; }
        ISangria Sangria { get; }

    }
}
