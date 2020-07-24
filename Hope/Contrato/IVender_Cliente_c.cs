namespace Hope.Contrato
{
    public interface IVender_Cliente_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IVender_Cliente_Ent_c FocusEntidade { get; }
        bool SelecionaRegistro(object _Selecionado);
        bool RemoverRegistroSelecionado(object _Selecionado);
       
    }
}