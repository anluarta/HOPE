namespace Hope.Interface
{
    public interface IAutenticacao
    {
        IColaborador_e Colaborador();
        bool Autenticado { get; }
        string Notifica();
        bool Login(string User, string Pass);
        bool Logout();
    }
}