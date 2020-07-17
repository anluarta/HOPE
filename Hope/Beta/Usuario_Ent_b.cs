using Hope.Controle;

namespace Hope.Beta
{
    class Usuario_Ent_b : Usuario_Ent_abs
    {
        public Usuario_Ent_b()
        {
            _ID_Usuario = string.Empty;
            _Usuario_Nome = string.Empty;
            _Senha = string.Empty;
            _Nome_Completo = string.Empty;
            _Email = string.Empty;
        }

        internal override void Clea()
        {
            _ID_Usuario = string.Empty;
            _Usuario_Nome = string.Empty;
            _Senha = string.Empty;
            _Nome_Completo = string.Empty;
            _Email = string.Empty;
        }
    }
}