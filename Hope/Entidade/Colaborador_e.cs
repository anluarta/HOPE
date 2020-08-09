using Hope.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Colaborador_e : IColaborador_e
    {
        List<string> Noticia;
        internal int ID { get; private set; }
        internal string Login { get; private set; }
        internal string Senha { get; private set; }
        internal string Nome_Vendedor { get; private set; }

        public Colaborador_e()
        {
            Noticia = new List<string>();
            ID = 0;
            Login = string.Empty;
            Senha = string.Empty;
            Nome_Vendedor = string.Empty;
        }
        internal Colaborador_e(int index, string login, string senha, string nome_vendedo)
        {
            Noticia = new List<string>();
            ID = index;
            Login = login;
            Senha = senha;
            Nome_Vendedor = nome_vendedo;
        }
        string IColaborador_e.Get_ID => ID.ToString();
        string IColaborador_e.Get_Login => Login;
        string IColaborador_e.Get_Nome_Vendedo => Nome_Vendedor;
        string IColaborador_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        bool IColaborador_e.Set_Login(string valor)
        {
            if (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor))
            {
                Noticia.Add("Login nulo ou com espaco em branco");
                return false;
            }
            else if (valor.Length <= 3)
            {
                Noticia.Add("Login muito curto");
                return false;
            }
            else
            {
                Noticia.Add("Login aceito");
                Login = valor;
                return true;
            }
        }

        bool IColaborador_e.Set_Nome_Vendedor(string valor)
        {
            if (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor))
            {
                Noticia.Add("Nome Vendedo nulo ou com espaco em branco");
                return false;
            }
            else if (valor.Length <= 3)
            {
                Noticia.Add("Nome Vendedo muito curto");
                return false;
            }
            else
            {
                Noticia.Add("Nome Vendedo aceito");
                Nome_Vendedor = valor;
                return true;
            }
        }

        bool IColaborador_e.Set_Senha(string valor)
        {
            if (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor))
            {
                Noticia.Add("Senha nulo ou com espaco em branco");
                return false;
            }
            else if (valor.Length <= 3)
            {
                Noticia.Add("Senha muito curto");
                return false;
            }
            else
            {
                Noticia.Add("Senha aceito");
                Senha = valor;
                return true;
            }
        }
    }
}
