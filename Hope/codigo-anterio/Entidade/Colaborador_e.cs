using Hope.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    public class Colaborador_e : IColaborado_Set_v,IColaborado_Get_v 
    {
        string nome_Vendedor;
        string login_User;
        string login_Pass;

        string IColaborado_Get_v.Nome_Vendedor => throw new NotImplementedException();

        string IColaborado_Get_v.Login_User => throw new NotImplementedException();

        string IColaborado_Get_v.Login_Pass => throw new NotImplementedException();

        public bool Login_Pass(string valor)
        {
            login_Pass = valor;
                return true;
            throw new NotImplementedException();
        }

        public bool Login_User(string valor)
        {
            throw new NotImplementedException();
        }

        public bool Nome_Vendedor(string valor)
        {
            throw new NotImplementedException();
        }

        //string IColaborado_Get_v.Nome_Vendedor => Nome_Vendedor;

        //string IColaborado_Get_v.Login_User => Login_User;

        //string IColaborado_Get_v.Login_Pass => Login_Pass;

        //bool IColaborado_Set_v.Login_Pass(string valor)
        //{
        //    Login_Pass = valor;
        //    return true;
        //    throw new NotImplementedException();
        //}



        //bool IColaborado_Set_v.Login_User(string valor)
        //{
        //    Login_User = valor;
        //    return true;
        //    throw new NotImplementedException();
        //}


        //bool IColaborado_Set_v.Nome_Vendedor(string valor)
        //{
        //    Nome_Vendedor = valor;
        //    return true;
        //    throw new NotImplementedException();
        //}


    }
}
