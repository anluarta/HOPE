using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Runtime.Serialization;

namespace Hope.Controle
{
    abstract class Colaborador_abs : IColaborador_c
    {
        internal bool Autenticado;
        internal Colaborador_Ent_abs _Logado;
        internal Colaborador_Ent_abs _FocusRegistro;
        internal Colaborador_Ent_abs _AlteraRegistro;
        internal Colaborador_Ent_abs _NovoRegistro;
        protected abstract bool select_all_from_registro(out Entidade.IColaborador_Ent_c[] ListResultado);
        protected abstract bool autentica_registro();
        protected abstract bool novo_insert_registro();
        protected abstract bool focus_update_registro();
        internal bool alteraregistro()
        {
            return focus_update_registro();
            throw new Exception();
        }
        internal bool gravarregistro()
        {
            return novo_insert_registro();
            throw new Exception();

        }
        internal bool login(string user, string pass)
        {
            _Logado.Clea();
            _Logado._Login_PassWord = pass;
            _Logado._Login_User = user;
            return autentica_registro();
            throw new Exception();

        }
        internal void sair()
        {
            Hope_c.informacao.Clear();
            Hope_c.informacao.Add("000", "Limpo memoria cache");
            _Logado.Clea();
           
            Autenticado = false;
        }
        IColaborador_Ent_c IColaborador_c.FocusRegistro { get { if (_FocusRegistro != null) { return _FocusRegistro; } else { return new Colaborador_Ent_abs(); } } }

        IInformacao_c IColaborador_c.Informacao => Hope_c.informacao;

        bool IColaborador_c.Autenticado => Autenticado;

        bool IColaborador_c.GravarRegistro(Entidade.IColaborador_Ent_c colaborador_Ent)
        {
            _NovoRegistro = colaborador_Ent as Colaborador_Ent_abs;
            return gravarregistro();
            throw new System.NotImplementedException();
        }

        bool IColaborador_c.Login(string Login_User, string Login_PassWord)
        {
            return login(Login_User, Login_PassWord);
            throw new System.NotImplementedException();
        }

        bool IColaborador_c.Logouf()
        {
            sair();
            Hope_c.caixa.Logouf();
            return true;
            throw new System.NotImplementedException();
        }

        bool IColaborador_c.NovoRegistro(out Entidade.IColaborador_Ent_c colaborado_Ent)
        {
            _NovoRegistro.Clea();
            colaborado_Ent = _NovoRegistro;
            return true;
            throw new System.NotImplementedException();
        }

        bool IColaborador_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out IColaborador_Ent_c[] ListaRegistro)
        {
            if (Comando.Contains(ListEnum.ComandoConsulta.Selec_All_From.ToString()))
            {
                return select_all_from_registro(out ListaRegistro);
            }
            else
            {
                ListaRegistro = new Colaborador_Ent_abs[0];
                return false;
            }
            throw new NotImplementedException();
        }

        bool IColaborador_c.SelecionaRegistro(object _Selecionado)
        {
            try
            {
                _FocusRegistro = _Selecionado as Colaborador_Ent_abs;
                return true;
            }
            catch (Exception ex)
            {
                Hope_c.informacao.Add("000", ex.Message);
                return false;
            }
        }

        void IColaborador_c.AlteraRegistro(out IColaborador_Ent_c colaborador)
        {
            _AlteraRegistro.Clea();
            colaborador = _AlteraRegistro;
        }

        bool IColaborador_c.GravaAlteracao(IColaborador_Ent_c colaborador)
        {
            _AlteraRegistro = colaborador as Colaborador_Ent_abs;
            return focus_update_registro();
            throw new NotImplementedException();
        }
    }
}