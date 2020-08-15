namespace Hope.Interface
{
    public interface IItem_e
    {
        int Get_Index { get; }
        string Get_Descricao { get; }
        string Get_Unidade { get; }
        decimal Get_Quantidade { get; }
        decimal Get_Sub_Total { get; }
        decimal Get_Venda { get; }

        string Notifica();
        bool Set_Descricao(string descricao);
        bool Set_Unidade(string descricao);
        bool Set_Quantidade(string descricao);
        bool Set_Venda(string descricao);
    }
}