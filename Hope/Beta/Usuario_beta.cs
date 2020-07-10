using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Usuario_beta : AbsUsuario
    {
        internal override bool SelectAll()
        {
            if (AbsHope.LocalDB_DEBUG.Usuario.Count != 0)
            {
                _DadoResultado = new Entidade.IUsuario[AbsHope.LocalDB_DEBUG.Usuario.Count];
                for (int i = 0; i < AbsHope.LocalDB_DEBUG.Usuario.Count; i++)
                {
                    _DadoResultado[i] = new Entidade.Usuario()
                    {
                        ID_Usuario = AbsHope.LocalDB_DEBUG.Usuario.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Usuario.Columns.IndexOf("ID_Usuario")].ToString(),
                        Email = AbsHope.LocalDB_DEBUG.Usuario.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Usuario.Columns.IndexOf("Email")].ToString(),
                        Nome_Completo = AbsHope.LocalDB_DEBUG.Usuario.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Usuario.Columns.IndexOf("Nome_Completo")].ToString(),
                        Usuario_Nome = AbsHope.LocalDB_DEBUG.Usuario.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Usuario.Columns.IndexOf("Usuario_Nome")].ToString(),
                        Senha = AbsHope.LocalDB_DEBUG.Usuario.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Usuario.Columns.IndexOf("Senha")].ToString()
                    };
                }
                return true;
            }
            else
            {
                MsgResult = "Tabela vazia";
                return false;
            }
            throw new NotImplementedException();
        }
        internal override bool Nome_Usuario(string _usuarionome)
        {
            bool v = base.Nome_Usuario(_usuarionome);
            if (v)
            {

                if (AbsHope.LocalDB_DEBUG.Usuario.Select(string.Format("Usuario_Nome = '{0}'", _usuarionome)).Length != 0)
                {
                    MsgResult = ListMsg.msg006;

                    v = false;
                }
                else
                {
                    _SetEntidade.V_UsuarioNome = true;
                    _SetEntidade.Usuario_Nome = _usuarionome;
                    v = true;
                }
            }
            return v;
        }
        internal override bool Email(string valor)
        {
            _SetEntidade.Email = valor;
            _SetEntidade.V_Email = true;
            return base.Email(valor);
        }
        internal override bool GravarNovoRegistro_Insert()
        {
            try
            {
                AbsHope.LocalDB_DEBUG.Usuario.AddUsuarioRow(
                    Usuario_Nome: _SetEntidade.Usuario_Nome,
                    Senha: _SetEntidade.Senha,
                    Nome_Completo: _SetEntidade.Nome_Completo,
                    Email: _SetEntidade.Email
                    );
                Clear();
                MsgResult = "Regstro gravado";
                return true;
            }
            catch (Exception e)
            {
                MsgResult = e.Message;
                return false;
            }
            throw new NotImplementedException();
        }

        internal override bool GravaAlteracaoRegistro_Update()
        {
            for (int i = 0; i < AbsHope.LocalDB_DEBUG.Usuario.Count; i++)
            {
                HopeLocalDB_DEBUG.UsuarioRow row = AbsHope.LocalDB_DEBUG.Usuario.Rows[i] as HopeLocalDB_DEBUG.UsuarioRow;
                if (int.Parse(_FocusEntidade.ID_Usuario) == row.ID_Usuario)
                {
                    row.Nome_Completo = _SetEntidade.Nome_Completo;
                    row.Email = _SetEntidade.Email;
                    row.Senha = _SetEntidade.Senha;
                    row.Usuario_Nome = _SetEntidade.Usuario_Nome;
                    Clear();
                    MsgResult = "Alteracao feita";
                    return true;
                }
            }
            MsgResult = "Nao localiado Registro pra alteracao";
            return false;
            throw new NotImplementedException();
        }
    }
}
