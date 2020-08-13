using Hope.Interface;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Hope.Entidade
{
   public class Colaborador_e : IColaborador_e
    {
        List<string> Noticia;
        private string Senha;
        private int ID ;
        private string Login ;
        private string Nome_Vendedor ;

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
        internal Colaborador_e(string selization)
        {
            object[] vs = selization.Split(char.Parse("|"));
            Dictionary<int, object> keyValues = new Dictionary<int, object>();
            foreach (object item in vs)
            {
                string strItem = item.ToString();
                if (strItem.Contains(":"))
                {
                    string[] subItem = strItem.Split(char.Parse(":"));
                    keyValues.Add(int.Parse(subItem[0]), subItem[1]);
                }
            }
            this.ID = int.Parse(keyValues[Key_Index].ToString());
            this.Login = keyValues[Key_Login_User].ToString();
            this.Nome_Vendedor = keyValues[Key_Nome_Vendedor].ToString();
        }
        internal string ToSerilazion()
        {
            string format = "{0}:{1}|{2}:{3}|{4}:{5}";
            object[] value = new object[]
            {
                Key_Index,
                this.ID,
                Key_Nome_Vendedor,
                this.Nome_Vendedor,
                Key_Login_User,
                Login
            };
           string serial = string.Format(format, value);
            
            return serial;
        }
        internal Dictionary<int, object> GetkeyValues()
        {
            Dictionary<int, object> keys = new Dictionary<int, object>();
            try
            {
                keys.Add(key:Key_Index, value:ID);
                keys.Add(key:Key_Login_Pass, value:Senha);
                keys.Add(key:Key_Login_User, value:Login);
                keys.Add(key:Key_Nome_Vendedor, value:Nome_Vendedor);
            }
            catch (Exception e)
            {
                Noticia.Add(e.Message);
            }
            return keys;
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

        public bool Set_Login(string valor)
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

        public bool Set_Nome_Vendedor(string valor)
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

        public bool Set_Senha(string valor)
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
        [NonSerialized] internal const int Key_Index = 0;
        [NonSerialized] internal const int Key_Login_Pass = 1;
        [NonSerialized] internal const int Key_Login_User = 2;
        [NonSerialized] internal const int Key_Nome_Vendedor = 3;
    }
}
