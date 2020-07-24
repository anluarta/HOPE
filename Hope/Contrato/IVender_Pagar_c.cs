namespace Hope.Contrato
{
    public interface IVender_Pagar_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IVender_Pagar_Ent_c FocusEntidade { get; }
        bool NovoRegistro(out Entidade.IVender_Pagar_Ent_c pagar);
        bool GravarRegistro(Entidade.IVender_Pagar_Ent_c pagar);
    }
}