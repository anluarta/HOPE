namespace Hope.Interface
{
    public interface IPreco_e
    {
        string Notifica();
        decimal Get_Custo { get; }
        decimal Get_Venda { get; }
        bool Set_Custo(decimal valor);
        bool Set_Venda(decimal valor);
        bool Set_Custo(string valor);
        bool Set_Venda(string valor);
    }
}