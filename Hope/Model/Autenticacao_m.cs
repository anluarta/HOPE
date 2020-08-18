using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Model
{
    class Autenticacao_m : Controle.Autenticacao_c
    {
        public Autenticacao_m()
        {
            Noticia = new List<string>();
            _Autenticado = false;
            Colaborador = new Colaborador_e();
        }
       const string adminUser = "Hope";
       const string adminPass = "Hope";
       const string adminSales = "Hope";
        const string demoUser = "Demo";
       const string demoPass = "Demo";
       const string demoSales = "Demo nome vendedo";
        protected override bool validalogin(string user, string pass)
        {
            if (adminPass.Equals(pass)&adminUser.Equals(user))
            {
                Colaborador = new Colaborador_e(
                    0,
                    adminUser,
                    adminPass,
                    adminSales
                    );
                _Autenticado = true;
                Noticia.Add("Login Validado");
                return true;
            }else if
                (demoPass.Equals(pass)& demoUser.Equals(user))
            {
                Colaborador = new Colaborador_e(
                    1,
                    demoPass,
                    demoUser,
                    demoSales
                    );
                _Autenticado = true;
                Noticia.Add("Login Validado");
                return true;
            }
            // colocar else if pra checar se ta configurado o bbcloud pra valida 
            // coloca else if pra checar se ta configurado o backoffice pra valida 
            else
            {
                Noticia.Add("Erro de Pass ou User");
                return false;
            }
        }

        protected override bool validalogout()
        {
            Colaborador = null;
            _Autenticado = false;
            return true;
        }
    }
}
