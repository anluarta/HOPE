namespace Hope.Interface
{
    public interface IComprador_e
    {
        INotifica Notifica {get;}
        int Get_ID { get; }
        string Get_Numero_Documento { get; }
        string Get_Nome_Comprador { get; }
        bool Set_Numero_Documento(string valor);
        bool Set_Nome_Comprador(string valor);
     
    }
}