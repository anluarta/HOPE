using Hope.Interface;
using System.Collections.Generic;
using System.Text;

namespace Hope.Entidade
{
    internal class Item_e : IItem_e
    {
        List<string> Notifica;
        private int _index_item;
        private int _index_venda;
        private string _Descricao;
        private string _Unidade;
        private decimal _Quantidade;
        private decimal _Venda;
        private decimal _Sub_Total { get { return decimal.Multiply(_Quantidade, _Venda); } }
        private Item_e()
        {
            Notifica = new List<string>();
        }
        internal Item_e(object dadoSerial):this()
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
            
        }

        public Item_e(int index_item, int index_venda):this()
        {
            this._index_item = index_item;
            this._index_venda = index_venda;
        }

        int IItem_e.Get_Index => throw new System.NotImplementedException();
        string IItem_e.Get_Descricao => throw new System.NotImplementedException();
        string IItem_e.Get_Unidade => throw new System.NotImplementedException();
        decimal IItem_e.Get_Quantidade => throw new System.NotImplementedException();
        decimal IItem_e.Get_Sub_Total => throw new System.NotImplementedException();
        decimal IItem_e.Get_Venda => throw new System.NotImplementedException();

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
            if (descricao!=null)
            {
                if (descricao.Length<11)
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
            if (quantidade!=null)
            {
                if (decimal.TryParse(quantidade,out _Quantidade))
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
            throw new System.NotImplementedException();
        }
        internal string ToSerilazion()
        {
            string format = "{0}:{1},";
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format(format, Key_, get_ID));
            return builder.ToString();
        }

    }
}