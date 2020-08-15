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
        List<string> _Noticia;
        private string _Senha;
        private int _ID ;
        private string _Login ;
        private string _Nome_Vendedor ;

        public Colaborador_e()
        {
            _Noticia = new List<string>();
            _ID = 0;
            _Login = string.Empty;
            _Senha = string.Empty;
            _Nome_Vendedor = string.Empty;
        }
        internal Colaborador_e(int index, string login, string senha, string nome_vendedo)
        {
            _Noticia = new List<string>();
            _ID = index;
            _Login = login;
            _Senha = senha;
            _Nome_Vendedor = nome_vendedo;
        }
        internal Colaborador_e(object selization)
        {
            object[] vs = selization.ToString().Split(char.Parse(","));
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
            this._ID = int.Parse(keyValues[Key_Index].ToString());
            this._Login = keyValues[Key_Login_User].ToString();
            this._Nome_Vendedor = keyValues[Key_Nome_Vendedor].ToString();
        }
        internal string ToSerilazion()
        {
            string format = "{0}:{1},{2}:{3},{4}:{5}";
            object[] value = new object[]
            {
                Key_Index,
                this._ID,
                Key_Nome_Vendedor,
                this._Nome_Vendedor,
                Key_Login_User,
                _Login
            };
           string serial = string.Format(format, value);
            
            return serial;
        }
        internal string Nome_Vendedor => _Nome_Vendedor;
        internal Dictionary<int, object> GetkeyValues()
        {
            Dictionary<int, object> keys = new Dictionary<int, object>();
            try
            {
                keys.Add(key:Key_Index, value:_ID);
                keys.Add(key:Key_Login_Pass, value:_Senha);
                keys.Add(key:Key_Login_User, value:_Login);
                keys.Add(key:Key_Nome_Vendedor, value:_Nome_Vendedor);
            }
            catch (Exception e)
            {
                _Noticia.Add(e.Message);
            }
            return keys;
        }
      
        string IColaborador_e.Get_ID => _ID.ToString();

        string IColaborador_e.Get_Login => _Login;
        string IColaborador_e.Get_Nome_Vendedo => _Nome_Vendedor;
        string IColaborador_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in _Noticia)
            {
                builder.AppendLine(item);
            }
            _Noticia.Clear();
            return builder.ToString();
        }

        public bool Set_Login(string valor)
        {
            if (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor))
            {
                _Noticia.Add("Login nulo ou com espaco em branco");
                return false;
            }
            else if (valor.Length <= 3)
            {
                _Noticia.Add("Login muito curto");
                return false;
            }
            else
            {
                _Noticia.Add("Login aceito");
                _Login = valor;
                return true;
            }
        }

        public bool Set_Nome_Vendedor(string valor)
        {
            if (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor))
            {
                _Noticia.Add("Nome Vendedo nulo ou com espaco em branco");
                return false;
            }
            else if (valor.Length <= 3)
            {
                _Noticia.Add("Nome Vendedo muito curto");
                return false;
            }
            else
            {
                _Noticia.Add("Nome Vendedo aceito");
                _Nome_Vendedor = valor;
                return true;
            }
        }

        public bool Set_Senha(string valor)
        {
            if (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor))
            {
                _Noticia.Add("Senha nulo ou com espaco em branco");
                return false;
            }
            else if (valor.Length <= 3)
            {
                _Noticia.Add("Senha muito curto");
                return false;
            }
            else
            {
                _Noticia.Add("Senha aceito");
                _Senha = valor;
                return true;
            }
        }
        [NonSerialized] internal const int Key_Index = 0;
        [NonSerialized] internal const int Key_Login_Pass = 1;
        [NonSerialized] internal const int Key_Login_User = 2;
        [NonSerialized] internal const int Key_Nome_Vendedor = 3;
    }
}
