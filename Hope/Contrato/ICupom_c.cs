namespace Hope.Contrato
{
    public interface ICupom_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICupom_Ent_c FocusEntidade { get; }
        Entidade.ICupomCliente_Ent_c Cliente { get; }
        Entidade.ICupomItem_Ent_c[] Item { get; }
        Entidade.ICupomPagar_Ent_c Pagar { get; }
        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.ICupom_Ent_c[] ListaRegistro);
        bool SelecionaRegistro(object _Selecionado);
        bool NovoRegistro();
        bool GravarEstadoRegistro();
        bool FinalizarRegistro();
        bool VerRegistro(object selectIten, out Entidade.ICupom_Ent_c cupom,out Entidade.ICupomCliente_Ent_c cliente, out Entidade.ICupomItem_Ent_c[] item, out Entidade.ICupomPagar_Ent_c pagar);
    }
}