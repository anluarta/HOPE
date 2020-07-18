using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hope.Controle;
namespace Hope.Beta
{
    class Usuario_b : Usuario_abs
    {
        public Usuario_b()
        {
            _FocusRegistro = new Usuario_Ent_b();
            _NovoRegistro = new Usuario_Ent_b();
            _AlteraRegistro = new Usuario_Ent_b();
            _Logado = new Usuario_Ent_b();
            ListRegUsuario = new List<Usuario_Ent_abs>();
        }

        internal override bool InsertRegistro()
        {
            try
            {
                Hope.localSet.Usuario.AddUsuarioRow(
                    Usuario_Nome: _NovoRegistro._Usuario_Nome,
                    Senha: _NovoRegistro._Senha,
                    Nome_Completo: _NovoRegistro._Nome_Completo,
                    Email: _NovoRegistro._Email
                    );
                Hope.informacao.Add("000", "Regstro gravado");
                return true;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }
        }

        internal override bool Login(string user, string senha)
        {
            if (Hope.localSet.Usuario.Count != 0)
            {
                foreach (HopeDataSet.UsuarioRow item in Hope.localSet.Usuario.Rows)
                {
                    if (item.Usuario_Nome.Equals(user))
                    {
                        if (item.Senha.Equals(senha))
                        {
                            _Logado = new Beta.Usuario_Ent_b()
                            {
                                Autenticado = true,
                                _ID_Usuario = item.ID_Usuario.ToString(),
                                _Email = item.Email,
                                _Nome_Completo = item.Nome_Completo,
                                _Senha = item.Senha,
                                _Usuario_Nome = item.Usuario_Nome
                            };
                            Hope.informacao.Add("000", "Login executato sucesso");

                            return true;
                        }
                    }
                }
                Hope.informacao.Add("000", "Login executato falha nao enontrado registro");
                return false;
            }
            else
            {
                Hope.informacao.Add("000", "DataRow Usuario Count = 0");
                return false;
            }
        }

        internal override bool Select_All_From()
        {
            if (Hope.localSet.Usuario.Count != 0)
            {
                for (int i = 0; i < Hope.localSet.Usuario.Count; i++)
                {
                    this.ListRegUsuario.Add(new Beta.Usuario_Ent_b()
                    {
                        _ID_Usuario = Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.ID_UsuarioColumn].ToString(),
                        _Email = Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.EmailColumn].ToString(),
                        _Nome_Completo = Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.Nome_CompletoColumn].ToString(),
                        _Usuario_Nome = Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.Usuario_NomeColumn].ToString(),
                        _Senha = Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.SenhaColumn].ToString()
                    });
                }
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "DataRow Usuario Count = 0");
                return false;
            }
        }

        internal override bool UpdateRegistro()
        {
            if (Hope.localSet.Usuario.Count != 0)
            {
                for (int i = 0; i < Hope.localSet.Usuario.Count; i++)
                {
                    if (Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.ID_UsuarioColumn].ToString() == _FocusRegistro._ID_Usuario)
                    {
                        Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.EmailColumn] = _AlteraRegistro._Email;
                        Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.Nome_CompletoColumn] = _AlteraRegistro._Nome_Completo;
                        Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.SenhaColumn] = _AlteraRegistro._Senha;
                        Hope.localSet.Usuario.Rows[i][Hope.localSet.Usuario.Usuario_NomeColumn] = _AlteraRegistro._Usuario_Nome;
                        Hope.informacao.Add("000", "DataRow Usuario modificado");
                        return true;
                    }
                }
            }
            else
            {
                Hope.informacao.Add("000", "DataRow Usuario Count = 0");
                return false;
            }
            throw new NotImplementedException();
        }
        //internal override bool SelectAll()
        //{
        //   
        //    throw new NotImplementedException();
        //}
        //internal override bool Nome_Usuario(string _usuarionome)
        //{
        //    bool v = base.Nome_Usuario(_usuarionome);
        //    if (v)
        //    {

        //        if (AbsHope.LocalDB_DEBUG.Usuario.Select(string.Format("Usuario_Nome = '{0}'", _usuarionome)).Length != 0)
        //        {
        //            MsgResult = ListMsg.msg006;

        //            v = false;
        //        }
        //        else
        //        {
        //            _SetEntidade.V_UsuarioNome = true;
        //            _SetEntidade.Usuario_Nome = _usuarionome;
        //            v = true;
        //        }
        //    }
        //    return v;
        //}
        //internal override bool Email(string valor)
        //{
        //    _SetEntidade.Email = valor;
        //    _SetEntidade.V_Email = true;
        //    return base.Email(valor);
        //}
        //internal override bool GravarNovoRegistro_Insert()
        //{
        //   
        //    throw new NotImplementedException();
        //}

        //internal override bool GravaAlteracaoRegistro_Update()
        //{
        //    for (int i = 0; i < AbsHope.LocalDB_DEBUG.Usuario.Count; i++)
        //    {
        //        HopeDataSet.UsuarioRow row = AbsHope.LocalDB_DEBUG.Usuario.Rows[i] as HopeDataSet.UsuarioRow;
        //        if (int.Parse(_FocusEntidade.ID_Usuario) == row.ID_Usuario)
        //        {
        //            row.Nome_Completo = _SetEntidade.Nome_Completo;
        //            row.Email = _SetEntidade.Email;
        //            row.Senha = _SetEntidade.Senha;
        //            row.Usuario_Nome = _SetEntidade.Usuario_Nome;
        //            Clear();
        //            MsgResult = "Alteracao feita";
        //            return true;
        //        }
        //    }
        //    MsgResult = "Nao localiado Registro pra alteracao";
        //    return false;
        //    throw new NotImplementedException();
        //}

        //internal override bool Autenticador(string _UsuarioNome, string _Senha)
        //{
        //    _AutenticEntidade = new Entidade.Usuario() { Usuario_Nome = _UsuarioNome, Senha = _Senha };
        //    return true;
        //    throw new NotImplementedException();
        //}
    }
}
