namespace Hope.Interface
{
    public interface IProduto
    {
        string Notifica();
        IProduto_e Novo();
        bool Gravar(ref IProduto_e Entidade);

        IProduto_e Select(object current);
        IConsulta Consulta { get; }
        IProduto_e[] Find(IConsulta consulta);
        IPreco Preco(IProduto_e Entidade);
        ICodigo Codigo(IProduto_e Entidade);
    }
}