namespace Hope.Interface
{
    public interface ICodigo
    {
        string Notifica();

        int Get_Codigo_Interno { get; }
        decimal Get_Codigo_Barra { get; }

        bool Set_Codigo_Interno(string valor);
        bool Set_Codigo_Barra(string valor);
    }
}