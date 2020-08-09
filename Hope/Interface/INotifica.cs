namespace Hope.Interface
{
    public interface INotifica
    {
        Enums.Notifica_u.Tipo Tipo { get; }
        string Mensagem();
    }
}