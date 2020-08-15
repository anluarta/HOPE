﻿using Hope.Interface;
using System.Collections.Generic;
using System.Text;

namespace Hope.Entidade
{
    internal class Item_e : IItem_e
    {
        List<string> Notifica;
        private int _index_item;
        private string _Descricao;
        private string _Unidade;
        private decimal _Quantidade;
        private decimal _Venda;
        private decimal _Sub_Total { get { return decimal.Multiply(_Quantidade, _Venda); } }
        private Item_e()
        {
            Notifica = new List<string>();
        }
        internal Item_e(object dadoSerial) : this()
        {
            object[] vs = dadoSerial.ToString().Split(char.Parse(","));
            Dictionary<int, object> keyValues = new Dictionary<int, object>();
            foreach (object item in vs)
            {
                string strItem = item.ToString();
                if (strItem.Contains(":"))
                {
                    string[] subItem = strItem.Split(char.Parse(":"));
                    keyValues.Add(int.Parse(subItem[0]), subItem[1]);
                }
            }
            _index_item = int.Parse(keyValues[Key_Index].ToString());
            _Descricao = keyValues[Key_Descricao].ToString();
            _Unidade = keyValues[Key_Unidade].ToString();
            _Quantidade = decimal.Parse(keyValues[Key_Quantidade].ToString());
            _Venda = decimal.Parse(keyValues[Key_Venda].ToString());
        }
        public Item_e(int index_item) : this()
        {
            this._index_item = index_item;
            _Descricao = string.Empty;
            _Unidade = string.Empty;
            _Quantidade = 0.0m;
            _Venda = 0.0m;
        }
        int IItem_e.Get_Index => _index_item;
        string IItem_e.Get_Descricao => _Descricao;
        string IItem_e.Get_Unidade => _Unidade;
        decimal IItem_e.Get_Quantidade => _Quantidade;
        decimal IItem_e.Get_Venda => _Venda;
        decimal IItem_e.Get_Sub_Total => _Sub_Total;

        string IItem_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Notifica)
            {
                builder.AppendLine(item);
            }
            Notifica.Clear();
            return builder.ToString();
        }

        bool IItem_e.Set_Descricao(string descricao)
        {
            if (descricao != null)
            {
                if (descricao.Length < 11)
                {
                    _Descricao = descricao;
                    return true;
                }
                else
                {
                    Notifica.Add("Descricao < 11");
                    return false;
                }
            }
            else
            {
                Notifica.Add("descricao Nullo");
                return false;
            }
        }
        bool IItem_e.Set_Unidade(string unidade)
        {
            if (unidade != null)
            {
                if (unidade.Length > 11)
                {
                    this._Unidade = unidade;
                    return true;
                }
                else
                {
                    Notifica.Add("Unidade Length > 11");
                    return false;

                }
            }
            else
            {
                Notifica.Add("Unidade Nullo");
                return false;
            }
        }
        bool IItem_e.Set_Quantidade(string quantidade)
        {
            if (quantidade != null)
            {
                if (decimal.TryParse(quantidade, out _Quantidade))
                {
                    return true;
                }
                else
                {
                    Notifica.Add("Quantidade nao converte valor numerico");
                    return false;
                }
            }
            else
            {
                Notifica.Add("quantiadde Nullo");
                return false;
            }
        }
        bool IItem_e.Set_Venda(string venda)
        {
            if (venda != null)
            {
                if (decimal.TryParse(venda, out _Venda))
                {
                    return true;
                }
                else
                {
                    Notifica.Add("venda nao converte valor numerico");
                    return false;
                }
            }
            else
            {
                Notifica.Add("venda Nullo");
                return false;
            }
        }
        internal string ToSerilazion()
        {
            string format = "{0}:{1},";
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format(format, Key_Index, _index_item));
            builder.Append(string.Format(format, Key_Descricao, _Descricao));
            builder.Append(string.Format(format, Key_Unidade, _Unidade));
            builder.Append(string.Format(format, Key_Quantidade, _Quantidade));
            builder.Append(string.Format(format, Key_Venda, _Venda));
            builder.Append(string.Format(format, Key_Sub_Total, _Sub_Total));
            return builder.ToString();
        }
        internal const int Key_Index = 1;
        internal const int Key_Descricao = 2;
        internal const int Key_Unidade = 3;
        internal const int Key_Quantidade = 4;
        internal const int Key_Venda = 5;
        internal const int Key_Sub_Total = 6;
    }
}