using Hope.Entidade;
using System;

namespace Hope.Interface
{
    public interface IVender_e:IVender_Posicao
    {
        string Notifica();
        int Get_ID { get; }
        int Get_ID_Caixa { get; }
        string Get_Nome_Vendedor { get; }
        DateTime Get_Finish_Time { get; }
        int Get_Total_Item { get; }
        decimal Get_Valor_Total { get; }
        decimal Get_Valor_Recebido { get; }
        decimal Get_Valor_Desconto { get; }
        decimal Get_Valor_Troco { get; }
        bool Pagarmento(out IPagar_e entidade);
        IItem_e[] GetDataByItem();
        bool Add(IItem_e entidade);
        bool Add(IPagar_e entidade);
        bool Remover(IItem_e entidade);
        bool Update(IItem_e entidade);
        bool SelectItem(object current,out IItem_e item_);
        bool Aborta();
        bool Devolucao();
        bool Join(IVender_e vender_);
        bool Finalizar();
    }
    public interface IVender_Posicao
    {
       internal Vender_e.ListPosicao GetListPosicao();
    }
}