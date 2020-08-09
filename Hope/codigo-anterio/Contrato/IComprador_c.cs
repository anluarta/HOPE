namespace Hope.Contrato
{
    public interface IComprador_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IComprador_Ent_c FocusEntidade { get; }
        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.IComprador_Ent_c[] ListaResultado);
        bool SelecionaRegistro(object _Selecionado);
        bool NovoRegistro(out Entidade.IComprador_Ent_c usuario);
        bool GravarRegistro(Entidade.IComprador_Ent_c usuario);
        void AlteraRegistro(out Entidade.IComprador_Ent_c usuario);
        bool GravaAlteracao(Entidade.IComprador_Ent_c usuario);

    }
}