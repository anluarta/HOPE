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
        internal Colaborador_e Colaborador { get;  set; }
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
                Noticia.Add("User Nulo ou com espacos");
            }
            if (string.IsNullOrEmpty(Pass) | string.IsNullOrWhiteSpace(Pass))
            {
                passerro = true;
                Noticia.Add("Pass Nulo ou com espacos");
            }
            if (usererro | passerro)
            {
                return false;
            }
            else
            {
                if (_Autenticado)
                {
                    Noticia.Add("Login ja feito para esse user");
                    return false;
                }
                else
                {
                    return validalogin(User, Pass);
                }
            }
        }

        public bool Logout()
        {
            if (validalogout())
            {
                Noticia.Add("Logout completo");
                return true;
            }
            else
            {
                Noticia.Add("Logout falha");
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
    }
}