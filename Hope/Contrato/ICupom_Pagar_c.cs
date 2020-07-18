namespace Hope.Contrato
{
    public interface ICupom_Pagar_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICupom_Pagar_Ent_c FocusEntidade { get; }
        bool NovoRegistro(out Entidade.ICupom_Pagar_Ent_c pagar);
        bool GravarRegistro(Entidade.ICupom_Pagar_Ent_c pagar);
    }
}