namespace Hope.Contrato
{
    public interface ICupom_Item_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICupom_Item_Ent_c FocusRegistro { get; }
        Entidade.ICupom_Item_Ent_c[] ListaRegistro { get; }
        bool NovoRegistro(out Entidade.ICupom_Item_Ent_c cupomItem);
        bool GravarRegistro(Entidade.ICupom_Item_Ent_c cupomItem);
        bool SelecionaRegistro(object _Selecionado);
        bool RemoverRegistroSelecionado(object _Selecionado);
        void AlteraRegistro(out Entidade.ICupom_Item_Ent_c cupomItem);
        bool GravaAlteracao(Entidade.ICupom_Item_Ent_c cupomItem);
    }
}