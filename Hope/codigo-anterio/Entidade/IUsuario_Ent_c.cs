using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   
   public interface IUsuario_Ent_c
    {
         string ID_Usuario { get; }
         string Usuario_Nome { get; }
         string Senha { get; }
         string Nome_Completo { get; }
         string Email { get; }
        bool Set_NomeCompleto(string text);
        bool Set_Email(string text);
        bool Set_Senha(string text);
        bool Set_NomeUsuario(string text);
    }
}
