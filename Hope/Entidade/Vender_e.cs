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
        List<IItem_e> _item_e_s;
        Pagar_e Pagar;
        Colaborador_e _Colaborador;
        int _Index;
        int _ID_Caixa;
        internal DateTime _Time_Start;
        internal DateTime _Time_Finish;
        ListPosicao _Posicao;
        decimal _Troco;
        decimal _Total_Recebido;
        decimal _Total_Venda;
        decimal _Desconto;
        internal Vender_e(object index, object id_caixa, object start_time, object finish_time, object posicao,
            object colaborador, object item_s, object troco, object recebido, object total_venda, object desconto, object pagamento)
        {
            this.Noticia = new List<string>();
            this._item_e_s = new List<IItem_e>();
            this.Item_Desereliza(item_s);
            this.Pagar = new Pagar_e(pagamento);
            this._Colaborador = new Colaborador_e(colaborador);
            this._Index =int.Parse(index.ToString());
            this._ID_Caixa =int.Parse(id_caixa.ToString());
            this._Time_Start = DateTime.Parse(start_time.ToString());
            this._Time_Finish =DateTime.Parse(finish_time.ToString());
            this._Posicao =SelectPosicao(posicao);
            this._Troco =decimal.Parse(troco.ToString());
            this._Total_Recebido =decimal.Parse(recebido.ToString());
            this._Total_Venda =decimal.Parse(total_venda.ToString());
            this._Desconto =decimal.Parse(desconto.ToString());

        }

        internal bool Dispariedade()
        {
            throw new NotImplementedException();
        }

        internal Dictionary<int, object> GetKeyValuesData()
        {
            Dictionary<int, object> keys = new Dictionary<int, object>();
            keys.Add(Key_Index, this._Index);
            keys.Add(Key_ID_Caixa, this._ID_Caixa);
            keys.Add(Key_Start_Time, this._Time_Start);
            keys.Add(Key_Finish_Time, this._Time_Finish);
            keys.Add(Key_Posicao, this._Posicao);
            keys.Add(Key_Colaborado, this._Colaborador.ToSerilazion());
            keys.Add(Key_Item_s, this._item_e_s);
            keys.Add(Key_Troco, this._Troco);
            keys.Add(Key_Total_Recebido, this._Total_Recebido);
            keys.Add(Key_Total_Venda, this._Total_Venda);
            keys.Add(Key_Desconto, this._Desconto);
            keys.Add(Key_Pagamento, this.Pagar.ToSerilizacao());
            return keys;
        }
        internal int Index_Item_Novo()
        {
           return _item_e_s.Count+1;
        }
        internal int Index_Venda => _Index;
        int IVender_e.Get_ID => _Index;

        int IVender_e.Get_ID_Caixa => _ID_Caixa;

        string IVender_e.Get_Nome_Vendedor => _Colaborador.Nome_Vendedor;

        DateTime IVender_e.Get_Finish_Time => _Time_Finish;

        int IVender_e.Get_Total_Item => _item_e_s.Count;

        decimal IVender_e.Get_Valor_Total => _Total_Venda;

        decimal IVender_e.Get_Valor_Recebido => _Total_Recebido;

        decimal IVender_e.Get_Valor_Desconto => _Desconto;

        decimal IVender_e.Get_Valor_Troco => _Troco;

        bool IVender_e.Add(IItem_e entidade)
        {
            if (entidade != null)
            {
                _item_e_s.Add(entidade);
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
            return _item_e_s.ToArray();
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
                if (_item_e_s.Remove(entidade))
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
        internal const int Key_ID_Caixa = 1;
        internal const int Key_Posicao = 2;
        internal const int Key_Colaborado = 3;
        internal const int Key_Comprador = 4;
        internal const int Key_Item_s = 5;
        internal const int Key_Start_Time = 6;
        internal const int Key_Finish_Time = 7;
        internal const int Key_Troco = 8;
        internal const int Key_Total_Recebido = 9;
        internal const int Key_Total_Venda = 10;
        internal const int Key_Desconto = 11;
        internal const int Key_Pagamento = 12;
        internal enum ListPosicao
        {
            Iniciado, Aberto, Espera, Pago, Finalizado
        }
        private string Item_Serelizado()
        {
            string formnat = "{0}|";
            string result = string.Empty;
            foreach (Item_e item in _item_e_s)
            {
                result += string.Format(formnat, item.ToSerilazion());
            }
            return result;
        }
        private void Item_Desereliza(object dado)
        {
            try
            {
                object[] vs = dado.ToString().Split(char.Parse("|"));
                foreach (object item in vs)
                {
                    IItem_e _E = new Item_e(item);
                    _item_e_s.Add(_E);
                }

            }
            catch (Exception e)
            {
                Noticia.Add(e.Message);
            }
        }
        private ListPosicao SelectPosicao(object posicao)
        {
            ListPosicao PLIS = ListPosicao.Finalizado;
            switch (ListPosicao.Iniciado)
            {
                case ListPosicao.Iniciado:
                    if (ListPosicao.Iniciado.ToString()==posicao.ToString())
                    {
                        PLIS = ListPosicao.Iniciado;
                    }
                    else
                    {
                        goto case ListPosicao.Aberto;
                    }
                    break;
                case ListPosicao.Aberto:
                    if (ListPosicao.Aberto.ToString() == posicao.ToString())
                    {
                        PLIS = ListPosicao.Aberto;
                    }
                    else
                    {
                        goto case ListPosicao.Espera;
                    }
                    break;
                case ListPosicao.Espera:
                    if (ListPosicao.Espera.ToString() == posicao.ToString())
                    {
                        PLIS = ListPosicao.Espera;
                    }
                    else
                    {
                        goto case ListPosicao.Pago;
                    }
                    break;
                case ListPosicao.Pago:
                    if (ListPosicao.Pago.ToString() == posicao.ToString())
                    {
                        PLIS = ListPosicao.Pago;
                    }
                    else
                    {
                        goto case ListPosicao.Finalizado;
                    }
                    break;
                case ListPosicao.Finalizado:
                    if (ListPosicao.Finalizado.ToString() == posicao.ToString())
                    {
                        PLIS = ListPosicao.Finalizado;
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                default:
                    Noticia.Add(string.Format("Erro SelectPosicao valor set {0}",posicao));
                    break;
            }
            return PLIS;
        }
    }
}
