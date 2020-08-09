namespace Hope.Interface
{
    public interface IVender_e
    {
        string Notifica();
        string Get_ID { get; }
        string Get_ID_Caixa { get; }
        string Get_Colaborador { get; }
        string Get_Finish { get; }
        string Get_Total_Item { get; }
        string Get_Valor_Total { get; }
        string Get_Valor_Recebido { get; }
        string Get_Valor_Desconto { get; }
        string Get_Valor_Troco { get; }
        bool Pagarmento(IPagar_e entidade);
        bool Finalizar();
        IItem_e[] GetDataByItem();
        bool Add(IItem_e entidade);
        bool Remover(IItem_e entidade);
        bool Update(IItem_e entidade);
        IItem_e SelectItem(object current);
    }
}