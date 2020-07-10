namespace Hope.Contrato
{
    public interface IProduto
    {
        Entidade.IProduto[] DadoResultado { get; }
        string StrMsgResultado { get;}
        bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo);
        bool Set_EAN(string _valor);
        bool Set_Descricao(string _valor);
        bool Set_Unidade(string _valor);
        bool Set_Custo(string _valor);
        bool Set_Venda(string _valor);
        bool GravarArteracao();
        bool GravarNovo();
        bool FocusRegistro(object _Selecionado);

    }
}