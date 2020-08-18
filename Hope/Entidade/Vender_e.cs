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
        Vender_e Temporario;
        List<string> Noticia;
        List<IItem_e> _item_e_s;
        Pagar_e Pagar;
        Colaborador_e _Colaborador;
        int _Index;
        int _ID_Caixa;
        internal DateTime _Time_Start;
        internal DateTime _Time_Finish;
       internal ListPosicao _Posicao;
        decimal _Troco;
        decimal _Total_Recebido;
        decimal _Total_Venda;
        //{
        //    get
        //    {
        //        if (_item_e_s.Count != 0)
        //        {
        //            return _item_e_s.Sum<IItem_e>(x => x.Get_Sub_Total);
        //        }
        //        else
        //        {
        //            return 0.0m;
        //        }
        //    }
        //}
        decimal _Desconto;
        internal Vender_e(object index, object id_caixa, object start_time, object finish_time, object posicao,
            object colaborador, object item_s, object troco, object recebido, object total_venda, object desconto, object pagamento)
        {
            this.Noticia = new List<string>();
            this._item_e_s = new List<IItem_e>();
            this.Item_e_s_Desereliza(item_s);
            this.Pagar = new Pagar_e(pagamento);
            this._Colaborador = new Colaborador_e(colaborador);
            this._Index = int.Parse(index.ToString());
            this._ID_Caixa = int.Parse(id_caixa.ToString());
            this._Time_Start = DateTime.Parse(start_time.ToString());
            this._Time_Finish = DateTime.Parse(finish_time.ToString());
            this._Posicao = SelectPosicao(posicao);
            this._Troco = decimal.Parse(troco.ToString());
            this._Total_Recebido = decimal.Parse(recebido.ToString());
            this._Total_Venda = decimal.Parse(total_venda.ToString());
            this._Desconto = decimal.Parse(desconto.ToString());

        }

        protected Vender_e(Vender_e vender_e)
        {
            this.Pagar = vender_e.Pagar;
            this._Colaborador = vender_e._Colaborador;
            this._Desconto = vender_e._Desconto;
            this._ID_Caixa = vender_e._ID_Caixa;
            this._Index = vender_e._Index;
            this._item_e_s = vender_e._item_e_s;
            this._Posicao = vender_e._Posicao;
            this._Time_Finish = vender_e._Time_Finish;
            this._Time_Start = vender_e._Time_Start;
            this._Total_Recebido = vender_e._Total_Recebido;
            this._Total_Venda = vender_e._Total_Venda;
            this._Troco = vender_e._Troco;
        }

        internal bool Dispariedade()
        {
            if (Temporario != null)
            {
                if (Temporario._Time_Finish == Vender_e._ValuaBaseFinishTime)
                {
                    List<bool> vs = new List<bool>()
                    {
                        Temporario._Desconto.Equals(_Desconto),
                        Temporario._Posicao.Equals(_Posicao),
                        Temporario._Time_Finish.Equals(_Time_Finish),
                        Temporario._Total_Recebido.Equals(_Total_Recebido),
                        Temporario._Total_Venda.Equals(_Total_Venda),
                        Temporario._Troco.Equals(_Troco),
                        Temporario.Pagar.Equals(Pagar),
                        Temporario._item_e_s.Equals(_item_e_s)
                    };
                    if (vs.Exists(x => x == false))
                    {
                        Noticia.Add("Existe mudanca a ser aplicada");
                        return true;
                    }
                    else
                    {
                        Noticia.Add("Nao existe Disparidade no valores");
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("FinishTime ja aplicado");
                    return false;
                }
            }
            else
            {

                Temporario = new Vender_e(this);
                return true;
            }
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
            keys.Add(Key_Item_s, this.Item_e_s_Serelizado());
            keys.Add(Key_Troco, this._Troco);
            keys.Add(Key_Total_Recebido, this._Total_Recebido);
            keys.Add(Key_Total_Venda, this._Total_Venda);
            keys.Add(Key_Desconto, this._Desconto);
            keys.Add(Key_Pagamento, this.Pagar.ToSerilizacao());
            return keys;
        }

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
                if (entidade is IItem_e)
                {
                    var temptotalvenda = this._Total_Venda;
                    this._Total_Venda = decimal.Add(this._Total_Venda, entidade.Get_Sub_Total);
                    if (this._Total_Venda.CompareTo(temptotalvenda) > 0)
                    {
                        string format = "Total Venda {0} valor anterio {1} diferenca adicionado {2}";
                        Noticia.Add(string.Format(format, this._Total_Venda, temptotalvenda, entidade.Get_Sub_Total));
                        _item_e_s.Add(entidade);
                        return true;
                    }
                    else
                    {
                        Noticia.Add("IVender_e Add IItem_e Total_Venda nao teve alteracao");
                        return false;
                    }

                }
                else
                {
                    Noticia.Add("Erro Vender_e Add valor entidade nao e IItem_e");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Item_e valor nullo");
                return false;
            }
        }
        bool IVender_e.Finalizar()
        {
            if (_Time_Finish == Vender_e._ValuaBaseFinishTime)
            {
                _Time_Finish = DateTime.Now;
                Noticia.Add("Finalizado Sussceso");
                return true;
            }
            else
            {
                Noticia.Add(string.Format("Ja Finalizado  valor {0}", _Time_Finish));
                return false;
            }
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

        bool IVender_e.Pagarmento(out IPagar_e entidade)
        {
            if (Pagar == null)
            {
                Pagar = new Pagar_e(_Total_Venda);
                entidade = Pagar;
            }
            else
            {
                entidade = Pagar;
            }
            return true;
        }

        bool IVender_e.Remover(IItem_e entidade)
        {
            if (entidade != null)
            {
                if (entidade is IItem_e)
                {
                    if (_item_e_s.Remove(entidade))
                    {
                        var temptotalvenda = this._Total_Venda;
                        this._Total_Venda = decimal.Subtract(this._Total_Venda, entidade.Get_Sub_Total);
                        if (this._Total_Venda.CompareTo(temptotalvenda) > 0)
                        {
                            string format = "Total Venda {0} valor anterio {1} valor subtraido {2}";
                            Noticia.Add(string.Format(format, this._Total_Venda, temptotalvenda, entidade.Get_Sub_Total));
                            return true;
                        }
                        else
                        {
                            Noticia.Add("Erro Vender_e Remove valor total_venda nao teve alteracao");
                            return false;
                        }
                    }
                    else
                    {
                        Noticia.Add("Erro ao remover Item_e");
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("Erro Vender_e Remover entidade valor nao e IItem_e");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Item_e valor Nullo");
                return false;
            }
        }

        bool IVender_e.SelectItem(object current, out IItem_e item_)
        {
            if (current != null)
            {
                if (_item_e_s.Contains(current))
                {
                    item_ = _item_e_s[_item_e_s.IndexOf(current as IItem_e)];
                    return true;
                }
                else
                {
                    item_ = null;
                    return false;
                }
            }
            else
            {
                item_ = null;
                return false;
            }
        }

        bool IVender_e.Update(IItem_e entidade)
        {
            if (entidade != null)
            {
                if (_item_e_s.Contains(entidade))
                {
                    // armz o valor antigo 
                    IItem_e temp_E = _item_e_s[_item_e_s.IndexOf(entidade)];
                    // armaz o valor antigo
                    var temptotalvendabase = this._Total_Venda;
                    // subtrai do total venda o valor do IItem_e na variavel temp_E
                    this._Total_Venda = decimal.Subtract(this._Total_Venda, temp_E.Get_Sub_Total);

                    var temptotalvendasubtra = this._Total_Venda;

                    //localiza o IItem_e na list e sustitui o seu valor pela entidade
                    _item_e_s[_item_e_s.IndexOf(temp_E)] = entidade;
                    // adiciona o novo valor total venda pegando o valor da entidade
                    this._Total_Venda = decimal.Add(this._Total_Venda, entidade.Get_Sub_Total);

                    var temptotalvendaadicio = this._Total_Venda;

                    string format = "total venda {0} valor antigo {1} valor subtraido {2} sub total {3} valor antigo {4}";
                    Noticia.Add(string.Format(format, this._Total_Venda, temptotalvendabase, temptotalvendasubtra, entidade.Get_Sub_Total, temp_E.Get_Sub_Total));
                    return true;
                }
                else
                {
                    Noticia.Add("Item_e nao localizado pra update");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Item_e Valor Nullo");
                return false;
            }
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
            Iniciado, Aberto, Espera, Pago, Finalizado,
            Aborta,
            Devolucao
        }
        private string Item_e_s_Serelizado()
        {
            string formnat = "{0}|";
            StringBuilder builder = new StringBuilder();
            foreach (Item_e item in _item_e_s)
            {
                builder.AppendLine(string.Format(formnat, item.ToSerilazion()));
            }
            return builder.ToString();
        }
        private void Item_e_s_Desereliza(object dado)
        {
            if (dado.ToString().Contains("|"))
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
        }
        private ListPosicao SelectPosicao(object posicao)
        {
            ListPosicao PLIS = ListPosicao.Finalizado;
            switch (ListPosicao.Iniciado)
            {
                case ListPosicao.Iniciado:
                    if (ListPosicao.Iniciado.ToString() == posicao.ToString())
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
                    Noticia.Add(string.Format("Erro SelectPosicao valor set {0}", posicao));
                    break;
            }
            return PLIS;
        }

        bool IVender_e.Add(IPagar_e entidade)
        {
            if (entidade != null)
            {
                if (entidade.Recebido >= _Total_Venda)
                {
                    _Desconto = entidade.Desconto;
                    _Troco = entidade.Troco;
                    _Total_Recebido = entidade.Recebido;
                    Pagar = (Pagar_e)entidade;
                    return true;
                }
                else
                {
                    Noticia.Add("valor recebido abaixo da venda");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Paga nullo");
                return false;
            }
        }

        bool IVender_e.Aborta()
        {
            _Posicao = ListPosicao.Aborta;
            return true;
        }

        bool IVender_e.Join(IVender_e vender_)
        {
            if (vender_ != null)
            {
                Vender_e _E = (Vender_e)vender_;
                if (_E._Posicao == ListPosicao.Iniciado)
                {
                    foreach (IItem_e item in _E._item_e_s)
                    {
                        var temptotalvenda = this._Total_Venda;
                        this._Total_Venda = decimal.Add(this._Total_Venda, item.Get_Sub_Total);
                        string format = "Total Venda {0} valor anterio {1} diferenca adicionado {2}";
                        Noticia.Add(string.Format(format, this._Total_Venda, temptotalvenda, item.Get_Sub_Total));
                        _item_e_s.Add(item);

                    }
                    return true;

                }
                else
                {
                    Noticia.Add("Vender_e Join Valor Ivender_e nao pode ser juntado");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Vender_e Join valor nulo");
                return false;
            }
        }

        bool IVender_e.Devolucao()
        {
            _Posicao = ListPosicao.Devolucao;
            return true;
        }

       
    }
}
