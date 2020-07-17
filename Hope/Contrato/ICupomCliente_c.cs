namespace Hope.Contrato
{
    public interface ICupomCliente_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICupomCliente_Ent_c FocusEntidade { get; }
        bool SelecionaRegistro(object _Selecionado);
        bool RemoverRegistroSelecionado(object _Selecionado);
       
    }
}