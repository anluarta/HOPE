using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
   public interface IColaborador_e
    {
        string Notifica();

        string Get_ID { get; }
        string Get_Login { get; }
        string Get_Nome_Vendedo { get; }
        bool Set_Login(string valor);
        bool Set_Senha(string valor);
        bool Set_Nome_Vendedor(string valor);
    }
}
