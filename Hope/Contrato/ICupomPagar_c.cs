namespace Hope.Contrato
{
    public interface ICupomPagar_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICupomPagar_Ent_c FocusEntidade { get; }
        bool NovoRegistro(out Entidade.ICupomPagar_Ent_c usuario);
        bool GravarRegistro(Entidade.ICupomPagar_Ent_c usuario);
    }
}