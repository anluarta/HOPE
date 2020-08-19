//using Hope.Contrato;
//using Hope.Entidade;
//using Hope.Controle;
using Hope.Entidade;
using Hope.Interface;
using System.Collections.Generic;
using System.Text;

namespace Hope.Controle
{
    abstract class Autenticacao_c : IAutenticacao
    {
        internal Colaborador_e Colaborador { get; set; }
        protected List<string> Noticia;
        protected bool _Autenticado;
        internal bool Autenticado { get => _Autenticado; }
        bool IAutenticacao.Autenticado => _Autenticado;
        protected abstract bool validalogin(string user, string pass);
        protected abstract bool validalogout();
        public bool Login(string User, string Pass)
        {
            bool usererro = false, passerro = false;
            if (string.IsNullOrEmpty(User) | string.IsNullOrWhiteSpace(User))
            {
                usererro = true;
                Noticia.Add(Msg002);
            }
            if (string.IsNullOrEmpty(Pass) | string.IsNullOrWhiteSpace(Pass))
            {
                passerro = true;
                Noticia.Add(Msg003);
            }
            if (usererro | passerro)
            {
                return false;
            }
            else
            {
                if (_Autenticado)
                {
                    Noticia.Add(Msg004);
                    return false;
                }
                else
                {
                    if (validalogin(User, Pass))
                    {
                        Noticia.Add(Msg005);
                        return true;
                    }
                    else
                    {
                        Noticia.Add(Msg006);
                        return false;
                    }
                }
            }
        }

        public bool Logout()
        {
            if (validalogout())
            {
                Noticia.Add(Msg007);
                return true;
            }
            else
            {
                Noticia.Add(Msg008);
                return false;
            }
        }

        string IAutenticacao.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        IColaborador_e IAutenticacao.Colaborador()
        {
            Noticia.Add(Msg009);

            return Colaborador;
        }
        const string Msg001 = "Autenticacao_c Msg-001: ";
        const string Msg002 = "Autenticacao_c Login Msg-002: Erro valor User nullo ou com WriteSpace";
        const string Msg003 = "Autenticacao_c Login Msg-003: Erro valor Pass nullo ou com WriteSpace";
        const string Msg004 = "Autenticacao_c Login Msg-004: Erro Ja existe login ativo";
        const string Msg005 = "Autenticacao_c Login Msg-005: Aviso Login validado";
        const string Msg006 = "Autenticacao_c Login Msg-006: Erro Login nao pode ser validado";
        const string Msg007 = "Autenticacao_c Logout Msg-007: Aviso User DesLogado";
        const string Msg008 = "Autenticacao_c Logout Msg-008: Erro User nao pode ser deslogado";
        const string Msg009 = "Autenticacao_c Colaborador Msg-009: Aviso Colaborado feito";
        protected const string Msg010 = "Autenticacao_c validalogin Msg-010: Aviso Login Comum feito Hope";
        protected const string Msg011 = "Autenticacao_c validalogin Msg-011: Aviso Login Comum feito Demo";
        protected const string Msg012 = "Autenticacao_c validalogin Msg-012: Erro Nao encontrado Login";
        protected const string Msg013 = "Autenticacao_c validalogout Msg-013: Aviso Susceso";
        protected const string Msg014 = "Autenticacao_c validalogout Msg-014: Erro Nao encontrado Login";
    }
}