namespace Hope.Contrato
{
    public interface ICupomItem_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICupomItem_Ent_c FocusEntidade { get; }
        bool NovoRegistro(out Entidade.ICupomItem_Ent_c cupomItem);
        bool GravarRegistro(Entidade.ICupomItem_Ent_c cupomItem);
        bool SelecionaRegistro(object _Selecionado);
        bool RemoverRegistroSelecionado(object _Selecionado);
        void AlteraRegistro(out Entidade.ICupomItem_Ent_c cupomItem);
        bool GravaAlteracao(Entidade.ICupomItem_Ent_c cupomItem);
    }
}