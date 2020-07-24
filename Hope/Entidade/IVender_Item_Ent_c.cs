namespace Hope.Entidade
{
    public interface IVender_Item_Ent_c
    {
        int ID_Item { get; }
        string Codigo { get; }
        string Descricao { get; }
        string Unidade { get; }
        string Quantidade { get; }
        string Preco { get; }
        string Sub_Total { get; }
    }
}