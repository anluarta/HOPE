namespace Hope.Interface
{
    public interface IProduto_e
    {
       
        string Notifica();

        int Get_ID { get; }
        string Get_Descricao { get; }
        string Get_Unidade { get; }
        bool Set_Descricao(string valor);
        bool Set_Unidade(string valor);

    }
}