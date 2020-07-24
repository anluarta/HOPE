namespace Hope.Contrato
{
    public interface IVender_Item_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IVender_Item_Ent_c FocusRegistro { get; }
        Entidade.IVender_Item_Ent_c[] ListaRegistro { get; }
        bool NovoRegistro(out Entidade.IVender_Item_Ent_c cupomItem);
        bool GravarRegistro(Entidade.IVender_Item_Ent_c cupomItem);
        bool SelecionaRegistro(object _Selecionado);
        bool RemoverRegistroSelecionado(object _Selecionado);
        void AlteraRegistro(out Entidade.IVender_Item_Ent_c cupomItem);
        bool GravaAlteracao(Entidade.IVender_Item_Ent_c cupomItem);
    }
}