using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hope.Controle;
namespace Hope.Beta
{
    class Colaborador_b : Colaborador_abs
    {
        public Colaborador_b()
        {
            _FocusRegistro = new Colaborador_Ent_b();
            _NovoRegistro = new Colaborador_Ent_b();
            _AlteraRegistro = new Colaborador_Ent_b();
            _Logado = new Colaborador_Ent_b();
            // altera esse prop na fase ALFA
        }

        protected override bool novo_insert_registro()
        {
            try
            {
                HopeDataSet.ColadoradorRow row = Hope.localSet.Coladorador.NewColadoradorRow();
                row.Login_User = _NovoRegistro._Login_User;
                row.Login_Pass = _NovoRegistro._Login_PassWord;
                row.Nome_Vendedor = _NovoRegistro._Nome_Vendedor;
                Hope.localSet.Coladorador.Rows.Add(row);
                Hope.localSet.AcceptChanges();
                Hope.informacao.Add("000", "Regstro gravado");
                return true;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }
        }

        protected override bool autentica_registro()
        {
            if (Hope.localSet.Coladorador.Count != 0)
            {
                foreach (HopeDataSet.ColadoradorRow item in Hope.localSet.Coladorador.Rows)
                {
                    if (item.Login_User.Equals(_Logado._Login_User))
                    {
                        if (item.Login_Pass.Equals(_Logado._Login_PassWord))
                        {
                            _Logado = new Beta.Colaborador_Ent_b()
                            {
                                _ID_Colaborador = item.ID_Colaborador,
                                _Nome_Vendedor = item.Nome_Vendedor,
                                _Login_PassWord = item.Login_Pass,
                                _Login_User = item.Login_User
                            };
                            Hope.informacao.Add("000", "Login executato sucesso");
                            Autenticado = true;
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
        // muda a forma de como esse medoto responde na fase ALFA
        protected override bool select_all_from_registro(out Entidade.IColaborador_Ent_c[] ListResultado)
        {
            
            if (Hope.localSet.Coladorador.Count != 0)
            {
                    List<Entidade.IColaborador_Ent_c> list = new List<Entidade.IColaborador_Ent_c>();
                for (int i = 0; i < Hope.localSet.Coladorador.Count; i++)
                {
                   list.Add(new Beta.Colaborador_Ent_b() {
                        _ID_Colaborador = (int)Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.ID_ColaboradorColumn],
                        _Login_User = Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.Login_UserColumn].ToString(),
                        _Login_PassWord = Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.Login_PassColumn].ToString(),
                        _Nome_Vendedor = Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.Nome_VendedorColumn].ToString()
                    });
                }
                ListResultado = list.ToArray();
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "DataRow Usuario Count = 0");
                ListResultado = new Entidade.IColaborador_Ent_c[0];
                return false;
            }
        }

        protected override bool focus_update_registro()
        {
            if (Hope.localSet.Coladorador.Count != 0)
            {
                for (int i = 0; i < Hope.localSet.Coladorador.Count; i++)
                {
                    if ((int)Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.ID_ColaboradorColumn] == _FocusRegistro._ID_Colaborador)
                    {
                        Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.Login_PassColumn] = _AlteraRegistro._Login_PassWord;
                        Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.Login_UserColumn] = _AlteraRegistro._Login_User;
                        Hope.localSet.Coladorador.Rows[i][Hope.localSet.Coladorador.Nome_VendedorColumn] = _AlteraRegistro._Nome_Vendedor;
                        Hope.localSet.AcceptChanges();
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
