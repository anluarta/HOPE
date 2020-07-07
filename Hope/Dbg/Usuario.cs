using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Dbg
{
    class Usuario : AbsUsuario
    {
        internal override bool NaoValidoUsuarioNome(string _usuarionome)
        {
            bool v = base.NaoValidoUsuarioNome(_usuarionome);
            if (!v)
            {
                if (Nucleo.ObjEstado.MeuConsole.officeDataSet_DEBUG.Usuario.Select(string.Format("Usuario_Nome = '{0}'" , _usuarionome)).Length != 0)
                {
                    strMsgResult = msg006;
                    v = true;
                }
                else
                {
                    v = false;
                }
            }
            return v;
        }
        public override bool Novo(string _usuarionome, string _senha, string _nomecompleto)
        {
            string _acao = "Registra novo usuario \n Valor Recebido \n{0},{1}.{2}";
            _acao = string.Format(_acao, _usuarionome, _senha, _nomecompleto);
            bool v = false;
            if (NaoValidoUsuarioNome(_usuarionome))
            {
                v = false;
            }
            else if (NaoValidoUsuarioSenha(_senha))
            {
                v = false;
            }
            else if (NaoValidoUsuarioNomeCompleto(_nomecompleto))
            {
                v = false;
            }
            else
            {
                try
                {
                    Nucleo.ObjEstado.MeuConsole.officeDataSet_DEBUG.Usuario.AddUsuarioRow(
                        Usuario_Nome: _usuarionome,
                        Senha: _senha,
                        Nome_Completo: _nomecompleto
                        );

                    System.Data.DataRow[] row = Nucleo.ObjEstado.MeuConsole.officeDataSet_DEBUG.Usuario.Select(string.Format("Usuario_Nome = '{0}'", _usuarionome));
                    foreach (System.Data.DataRow item in row)
                    {

                        strMsgResult = string.Format(msg015, item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString());
                        break;
                    }
                    v = true;
                }
                catch (Exception e)
                {
                    strMsgResult = e.Message;
                    v = false;
                }
            }
            
            Nucleo.ObjEstado.AddLinhaExecucao(_acao, strMsgResult);
            return v;
        }
    }
}
