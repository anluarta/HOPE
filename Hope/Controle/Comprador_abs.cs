using Hope.Contrato;
using Hope.Entidade;
using System;

namespace Hope.Controle
{
    abstract class Comprador_abs : IComprador_c
    {
        internal Comprador_Ent_abs _FocusRegistro = null;
        internal Comprador_Ent_abs _AlteraRegistro = null;
        internal Comprador_Ent_abs _NovoRegistro = null;
        protected abstract bool novo_insert_registro();
        protected abstract bool focus_update_registro();
        protected abstract bool select_all_from(out IComprador_Ent_c[] listaressultado);
        internal void gravarrestro()
        {
            novo_insert_registro();
        }
        internal void alteraregistro()
        {
            focus_update_registro();
        }
        IInformacao_c IComprador_c.Informacao => Hope.informacao;

        IComprador_Ent_c IComprador_c.FocusEntidade => _FocusRegistro;

        void IComprador_c.AlteraRegistro(out IComprador_Ent_c comprador)
        {
            _AlteraRegistro.Clea();
            comprador = _AlteraRegistro;
            return;
            throw new NotImplementedException();
        }

        bool IComprador_c.GravaAlteracao(IComprador_Ent_c comprador)
        {
            _AlteraRegistro = comprador as Comprador_Ent_abs;
            return focus_update_registro();
            throw new NotImplementedException();
        }

        bool IComprador_c.GravarRegistro(IComprador_Ent_c comprador)
        {
            _NovoRegistro = comprador as Comprador_Ent_abs;
            return novo_insert_registro();
            throw new NotImplementedException();
        }

        bool IComprador_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out IComprador_Ent_c[] ListaRegistro)
        {
            select_all_from(out ListaRegistro);
            return true;
            throw new NotImplementedException();
        }

        bool IComprador_c.NovoRegistro(out IComprador_Ent_c comprador)
        {
            _NovoRegistro.Clea();
            comprador = _NovoRegistro;
            return true;
            throw new NotImplementedException();
        }

        bool IComprador_c.SelecionaRegistro(object _Selecionado)
        {
            try
            {
                _FocusRegistro = _Selecionado as Comprador_Ent_abs;
                return true;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }
        }

        internal static class ListMsg
        {

            public const string msg001 = "Lista REgistro vazio";
            public const string msg002 = "Registro SAlvo";
        }
    }
}
