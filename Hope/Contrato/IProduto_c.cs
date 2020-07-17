namespace Hope.Contrato
{
    public interface IProduto_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IProduto_Ent_c FocusEntidade { get; }
        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.IProduto_Ent_c[] ListaRegistro);
        bool SelecionaRegistro(object _Selecionado);
        bool NovoRegistro(out Entidade.IProduto_Ent_c usuario);
        bool GravarRegistro(Entidade.IProduto_Ent_c usuario);

      


    }
}