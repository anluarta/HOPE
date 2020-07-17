namespace Hope.Entidade
{
    public interface ICupomItem_Ent_c
    {
        string ID_Item { get; }
        string Codigo { get; }
        string Descricao { get; }
        string Unidade { get; }
        string Quantidade { get; }
        string Preco { get; }
        string Sub_Total { get; }
        bool Set_ID_Item(string valor);
        bool Set_Codigo(string valor);
        bool Set_Descricao(string valor);
        bool Set_Unidade(string valor);
        bool Set_Quantidade(string valor);
        bool Set_Preco(string valor);
        bool Set_Sub_Total(string valor);

    }
}