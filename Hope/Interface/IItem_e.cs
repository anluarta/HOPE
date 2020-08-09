namespace Hope.Interface
{
    public interface IItem_e
    {
        string Get_Index { get; }
        string Get_Descricao { get; }
        string Get_Quantidade { get; }
        string Get_Sub_Total { get; }
        string Get_Unidade { get; }
        string Get_Venda { get; }

        string Notifica();
        bool Set_Descricao(string descricao);
        bool Set_Unidade(string descricao);
        bool Set_Quantidade(string descricao);
        bool Set_Venda(string descricao);
    }
}