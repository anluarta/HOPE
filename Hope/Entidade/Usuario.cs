using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Usuario : IUsuario
    {
        public Usuario()
        {
            ID_Usuario = string.Empty;
            Usuario_Nome = string.Empty;
            Senha = string.Empty;
            Nome_Completo = string.Empty;
            Email = string.Empty;
            V_Email = false;
            V_NomeCompleto = false;
            V_Senha = false;
            V_UsuarioNome = false;
        }
        public string ID_Usuario { get; set; }
        public string Usuario_Nome { get; set; }
        public string Senha { get; set; }
        public string Nome_Completo { get; set; }
        public string Email { get; set; }
        internal bool V_UsuarioNome { get; set; }
        internal bool V_Senha { get; set; }
        internal bool V_NomeCompleto { get; set; }
        internal bool V_Email { get; set; }
    }
}
