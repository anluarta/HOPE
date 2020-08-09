using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    [Serializable]
   abstract class Usuario_Ent_abs : IUsuario_Ent_c
    {
        [NonSerialized]
        internal bool Autenticado;
        public string _ID_Usuario { get; set; }
        public string _Usuario_Nome { get; set; }
        public string _Senha { get; set; }
        public string _Nome_Completo { get; set; }
        public string _Email { get; set; }
        internal void Clea()
        {
            _ID_Usuario = string.Empty;
            _Usuario_Nome = string.Empty;
            _Senha = string.Empty;
            _Nome_Completo = string.Empty;
            _Email = string.Empty;
            Autenticado = false;
        }

        string IUsuario_Ent_c.ID_Usuario => _ID_Usuario;

        string IUsuario_Ent_c.Usuario_Nome => _Usuario_Nome;

        string IUsuario_Ent_c.Senha => _Senha;

        string IUsuario_Ent_c.Nome_Completo => _Nome_Completo;

        string IUsuario_Ent_c.Email => _Email;
       
        bool IUsuario_Ent_c.Set_Email(string text)
        {
            _Email = text;
            return true;
         
        }

        bool IUsuario_Ent_c.Set_NomeCompleto(string text)
        {
            _Nome_Completo = text;
            return true;
        }

        bool IUsuario_Ent_c.Set_NomeUsuario(string text)
        {
            _Usuario_Nome = text;
            return true;
        }

        bool IUsuario_Ent_c.Set_Senha(string text)
        {
            _Senha = text;
            return true;
        }
    }
}
