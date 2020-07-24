namespace Hope.Contrato
{
    public interface IVender_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IVender_Ent_c FocusEntidade { get; }
        IVender_Item_c Item { get; }
        IVender_Pagar_c Pagar { get; }
       // bool AdicionarCliente();
      //  bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.ICupom_Ent_c[] ListaRegistro);
      //  bool SelecionaRegistro(object _Selecionado);
        bool NovoRegistro();
        bool GravarEstadoRegistro();
        bool FinalizarRegistro();
      //  bool VerRegistro(object selectIten, out Entidade.ICupom_Ent_c cupom, out Entidade.ICupomItem_Ent_c item, out Entidade.ICupomPagar_Ent_c pagar);
    }
}