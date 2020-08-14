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
        ICaixa_e Novo();
        bool Gravar(ICaixa_e entidade, out ICaixa_e result);
        ICaixa_e Select(object current);
        
        IConsulta Consulta();
        bool Find(IConsulta consulta,out ICaixa_e[] caixa_s);
        ISuprimento_e Suprimento_Novo(ICaixa_e entidade);
        ISangria_e Sangria_Novo(ICaixa_e entidade);
        bool Print_Document(object current, out PrintDocument document);

        ISuprimento Suprimento { get; }
        ISangria Sangria { get; }

    }
}
