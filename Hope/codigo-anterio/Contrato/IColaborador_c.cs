namespace Hope.Contrato
{
    public interface IColaborador_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IColaborador_Ent_c FocusRegistro {get;}
        bool Autenticado {get;}
        bool NovoRegistro(out Entidade.IColaborador_Ent_c colaborado_Ent);
        bool GravarRegistro(Entidade.IColaborador_Ent_c colaborador_Ent);
        bool Login(string Login_User, string Login_PassWord);
        bool Logouf();
        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.IColaborador_Ent_c[] ListaRegistro);
        bool SelecionaRegistro(object _Selecionado);
        void AlteraRegistro(out Entidade.IColaborador_Ent_c colaborador);
        bool GravaAlteracao(Entidade.IColaborador_Ent_c colaborador);
    }
}