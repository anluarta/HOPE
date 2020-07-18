namespace Hope.Entidade
{
    public interface ICupom_Item_Ent_c
    {
        string ID_Item { get; }
        string Codigo { get; }
        string Descricao { get; }
        string Unidade { get; }
        string Quantidade { get; }
        string Preco { get; }
        string Sub_Total { get; }
        bool Set_Codigo(string valor);
        bool Set_Descricao(string valor);
        bool Set_Unidade(string valor);
        bool Set_Quantidade(string valor);
        bool Set_Preco(string valor);
    }
}