using System;

namespace Hope.Contrato
{
    public interface IUsuario_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IUsuario_Ent_c FocusEntidade { get; }
        bool Localizar( string Comando, string Coluna, string Orden, decimal Limit, string Termo,out Entidade.IUsuario_Ent_c[] ListaRegistro);
        bool SelecionaRegistro(object _Selecionado);
        bool NovoRegistro( out Entidade.IUsuario_Ent_c usuario);
        bool GravarRegistro(Entidade.IUsuario_Ent_c usuario);
        void AlteraRegistro(out Entidade.IUsuario_Ent_c usuario);
        bool GravaAlteracao(Entidade.IUsuario_Ent_c usuario);
        bool Login(string _UsuarioNome, string _Senha);
        bool Autenticado();
        void Sair();
    }
}