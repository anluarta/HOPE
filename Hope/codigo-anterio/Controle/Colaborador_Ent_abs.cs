using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class Colaborador_Ent_abs : Entidade.IColaborador_Ent_c
    {
        internal int _ID_Colaborador;
        internal string _Nome_Vendedor;
        internal string _Login_User;
        internal string _Login_PassWord;
        public void Clea()
        {
            _ID_Colaborador = 0;
            _Nome_Vendedor = string.Empty;
            _Login_User = string.Empty;
            _Login_PassWord = string.Empty;
        }
        int IColaborador_Ent_c.ID_Colaborador => _ID_Colaborador;
        string IColaborador_Ent_c.Nome_Vendedor => _Nome_Vendedor;

        string IColaborador_Ent_c.Login_User => _Login_User;

        string IColaborador_Ent_c.Login_PassWord => _Login_PassWord;

        string IEndereco_Ent_c.Logradouro => throw new NotImplementedException();

        string IEndereco_Ent_c.Cep => throw new NotImplementedException();

        string IEndereco_Ent_c.Bairro => throw new NotImplementedException();

        string IEndereco_Ent_c.Municipio => throw new NotImplementedException();

        string IEndereco_Ent_c.Estado => throw new NotImplementedException();


        bool IEndereco_Ent_c.Set_Bairro(string valor)
        {
            throw new NotImplementedException();
        }

        bool IEndereco_Ent_c.Set_Cep(string valor)
        {
            throw new NotImplementedException();
        }

        bool IEndereco_Ent_c.Set_Estado(string valor)
        {
            throw new NotImplementedException();
        }

        bool IColaborador_Ent_c.Set_Login_PassWord(string valor)
        {
            _Login_PassWord = valor;
            return true;
            throw new NotImplementedException();
        }

        bool IColaborador_Ent_c.Set_Login_User(string valor)
        {
            _Login_User = valor;
            return true;
            throw new NotImplementedException();
        }

        bool IEndereco_Ent_c.Set_Logradouro(string valor)
        {
            throw new NotImplementedException();
        }

        bool IEndereco_Ent_c.Set_Municipio(string valor)
        {
            throw new NotImplementedException();
        }

        bool IColaborador_Ent_c.Set_Nome_Vendedor(string valor)
        {
            _Nome_Vendedor = valor;
            return true;
            throw new NotImplementedException();
        }
    }
}
