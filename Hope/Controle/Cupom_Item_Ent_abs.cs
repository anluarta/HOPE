using Hope.Entidade;

namespace Hope.Controle
{
    class Cupom_Item_Ent_abs : Entidade.ICupom_Item_Ent_c
    {
        internal string _ID_Item;
        internal string _Codigo;
        internal string _Descricao;
        internal string _Unidade;
        internal string _Quantidade;
        internal string _Preco;
        internal string _Sub_Total 
        { 
            get 
            {
                if (string.IsNullOrEmpty(_Quantidade)|string.IsNullOrEmpty(_Preco))
                {
                    return "";
                }
                else
                {
                    return decimal.Multiply(decimal.Parse(_Preco), decimal.Parse(_Quantidade)).ToString();
                }
            }
        }
        public void Clea()
        {
            _Codigo = string.Empty;
            _Descricao = string.Empty;
            _ID_Item = string.Empty;
            _Preco = string.Empty;
            _Quantidade = string.Empty;
            _Unidade = string.Empty;
        }
        string ICupom_Item_Ent_c.ID_Item => _ID_Item;

        string ICupom_Item_Ent_c.Codigo => _Codigo;

        string ICupom_Item_Ent_c.Descricao => _Descricao;

        string ICupom_Item_Ent_c.Unidade => _Unidade;

        string ICupom_Item_Ent_c.Quantidade => _Quantidade;

        string ICupom_Item_Ent_c.Preco => _Preco;

        string ICupom_Item_Ent_c.Sub_Total => _Sub_Total;

        bool ICupom_Item_Ent_c.Set_Codigo(string valor)
        {
            _Codigo = valor;
            return true;
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_Ent_c.Set_Descricao(string valor)
        {
            _Descricao = valor;
            return true;
            throw new System.NotImplementedException();
        }
        bool ICupom_Item_Ent_c.Set_Preco(string valor)
        {
            _Preco = valor;
            return true;
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_Ent_c.Set_Quantidade(string valor)
        {
            _Quantidade = valor;
            return true;
            throw new System.NotImplementedException();
        }
        bool ICupom_Item_Ent_c.Set_Unidade(string valor)
        {
            _Unidade = valor;
            return true;
            throw new System.NotImplementedException();
        }
    }
}