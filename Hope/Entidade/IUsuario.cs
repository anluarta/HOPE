using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface IUsuario
    {
         string ID_Usuario { get; set; }
         string Usuario_Nome { get; set; }
         string Senha { get; set; }
         string Nome_Completo { get; set; }
         string Email { get; set; }
    }
}
