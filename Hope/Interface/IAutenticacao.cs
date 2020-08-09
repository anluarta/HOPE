namespace Hope.Interface
{
    public interface IAutenticacao
    {
        bool Autenticado { get; }
        string Notifica();
        bool Login(string User, string Pass);
        bool Logout();
    }
}