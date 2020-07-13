using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Alfa
{
    class Usuario_alfa : AbsUsuario
    {
        internal override bool Autenticador(string _UsuarioNome, string _Senha)
        {
            throw new NotImplementedException();
        }

        internal override bool GravaAlteracaoRegistro_Update()
        {
            throw new NotImplementedException();
        }

        internal override bool GravarNovoRegistro_Insert()
        {
            throw new NotImplementedException();
        }

        internal override bool SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
