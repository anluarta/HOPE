namespace Hope.Interface
{
    public interface IComprador
    {
        INotifica Notifica();
        IComprador_e Novo();
        bool Gravar(IComprador_e Entidade);
        IComprador_e Select(object current);
        IConsulta Consulta { get; }
        IComprador_e[] Find(IConsulta consulta);

    }
}