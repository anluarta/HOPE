using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Vender_e : IVender_e
    {
        List<string> Noticia;
        List<IItem_e> item_s;
        internal Vender_e()
        {

        }
        string IVender_e.Get_ID => throw new NotImplementedException();

        string IVender_e.Get_ID_Caixa => throw new NotImplementedException();

        string IVender_e.Get_Colaborador => throw new NotImplementedException();

        string IVender_e.Get_Finish_Time => throw new NotImplementedException();

        string IVender_e.Get_Total_Item => throw new NotImplementedException();

        string IVender_e.Get_Valor_Total => throw new NotImplementedException();

        string IVender_e.Get_Valor_Recebido => throw new NotImplementedException();

        string IVender_e.Get_Valor_Desconto => throw new NotImplementedException();

        string IVender_e.Get_Valor_Troco => throw new NotImplementedException();

        bool IVender_e.Add(IItem_e entidade)
        {
            if (entidade != null)
            {
                item_s.Add(entidade);
                return true;
            }
            else
            {
                Noticia.Add("Item_e valor nullo");
                return false;
            }
        }

        bool IVender_e.Finalizar()
        {
            throw new NotImplementedException();
        }

        IItem_e[] IVender_e.GetDataByItem()
        {
            return item_s.ToArray();
        }

        string IVender_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        bool IVender_e.Pagarmento(IPagar_e entidade)
        {
            throw new NotImplementedException();
        }

        bool IVender_e.Remover(IItem_e entidade)
        {
            if (entidade != null)
            {
                if (item_s.Remove(entidade))
                {
                    Noticia.Add("Item_e removido");
                    return true;
                }
                else
                {
                    Noticia.Add("Erro ao remover Item_e");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Item_e valor Nullo");
                return false;
            }
        }

        IItem_e IVender_e.SelectItem(object current)
        {

            throw new NotImplementedException();
        }

        bool IVender_e.Update(IItem_e entidade)
        {
            throw new NotImplementedException();
        }
        internal static DateTime _ValuaBaseFinishTime = DateTime.Parse("01/01/01 23:59:59");
        internal const int Key_Index = 0;
       internal enum Posicao
        {
            Iniciado,Espera,Pago,Finalizado
        }
    }
}
