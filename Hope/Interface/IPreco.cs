namespace Hope.Interface
{
    public interface IPreco
    {
        string Notifica();
        IPreco_e Novo();
        bool Add(IPreco_e entidade);
        bool Gravar(ref IProduto_e entidade);
        
    }
}