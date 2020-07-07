using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    abstract class AbsUsuario : IFace.IUsuario
    {
        public string strMsgResult { get; set; }

        internal bool NaoValidoUsuarioNomeCompleto(string _nomecompleto)
        {
            
            if (string.IsNullOrEmpty(_nomecompleto))
            {
                strMsgResult = msg011;
                return true;
            }
            else if (string.IsNullOrWhiteSpace(_nomecompleto))
            {
                strMsgResult = msg012;
                return true;

            }
            else if (_nomecompleto.Length<=10)
            {
                strMsgResult = msg013;
                return true;

            }
            else if (_nomecompleto.Length>=100)
            {
                strMsgResult = msg014;
                return true;

            }
            else
            {
                return false;
            }
        }
        virtual internal bool NaoValidoUsuarioSenha(string _senha)
        {
            if (string.IsNullOrEmpty(_senha))
            {
                strMsgResult = msg007;
                return true;

            }
            else if (string.IsNullOrWhiteSpace(_senha))
            {
                strMsgResult = msg008;
                return true;

            }
            else if (_senha.Length <= 5)
            {
                strMsgResult = msg009;
                return true;

            }
            else if (_senha.Length >= 30)
            {
                strMsgResult = msg010;
                return true;

            }
            else
            {
                return false;
            }
        }
        virtual internal bool NaoValidoUsuarioNome(string _usuarionome)
        {
            bool v = false;
            try
            {
                v = decimal.TryParse(_usuarionome, out decimal n);
            }
            finally
            {

            }
            if (v)
            {
                strMsgResult = msg001;
                v = true;
            }
            else if (string.IsNullOrEmpty(_usuarionome))
            {
                strMsgResult = msg002;
                v = true;
            }
            else if (string.IsNullOrWhiteSpace(_usuarionome))
            {
                strMsgResult = msg003;
                v = true;
            }
            else if (_usuarionome.Length <= 3)
            {
                strMsgResult = msg004;
                v = true;
            }
            else if (_usuarionome.Length >= 20)
            {
                strMsgResult = msg005;
                v = true;
            }
            else
            {
                v = false;
            }
            return  v;
           
        }
        private const string msg001 = "Usuario Nome dever ter letra.";
        private const string msg002 = "Usuario Nome Nullo";
        private const string msg003 = "Usuario Nome Vazio";
        private const string msg004 = "Usuario Nome e muito curto <=3";
        private const string msg005 = "Usuario Nome muito longo >=20";
        internal const string msg006 = "Usuario Nome Ja Registrado";
        private const string msg007 = "Usuario Senha Nullo";
        private const string msg008 = "Usuario Senha Vazio";
        private const string msg009 = "Usuario Senha muito curto <=5";
        private const string msg010 = "Usuario Senha muito longo >=30";
        private const string msg011 = "Usuario Nome Completo nullo";
        private const string msg012 = "Usuario Nome Completo Vazio";
        private const string msg013 = "Usuario Nome Completo muito curto <=30";
        private const string msg014 = "Ususario Nome Completo muito longo >=100";
        internal const string msg015 = "Registro salvo \n valor \n ID_USUario={0} Usuario_Nome={1} Senha={2} Nome_Completo={3}";
        public abstract bool Novo(string _usuarionome, string _senha, string _nomecompleto);
    }
}
