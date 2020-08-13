using Hope.Interface;
using System.Collections.Generic;
using System.Text;

namespace Hope.Entidade
{
    internal class Sangria_e : ISangria_e
    {
        internal const string Key_CaixaID = "CaixaID";
        internal const string Key_ColacoradoID = "ColaboradorID";
        internal const string Key_Observacao = "Observacao";
        internal const string Key_Valor = "Valor";
        List<string> Noticia;
        private int caixaID;
        private string colaboraID;
        string _Observacao;
       internal decimal _Valor { get; private set; }

        public Sangria_e(int caixaID, string colaboraID)
        {
            this.caixaID = caixaID;
            this.colaboraID = colaboraID;
            Noticia = new List<string>();
        }
        internal Dictionary<string,object> GetKeyValuesData()
        {
            Dictionary<string, object> keys = new Dictionary<string, object>();
            try
            {
                keys.Add(Key_CaixaID, caixaID);
                keys.Add(Key_ColacoradoID, colaboraID);
                keys.Add(Key_Observacao, _Observacao);
                keys.Add(Key_Valor, _Valor);
            }
            catch (System.Exception e)
            {
                Noticia.Add(e.Message);
            }
            return keys;
        }
        string ISangria_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        bool ISangria_e.Set_Observacao(string obsevacao)
        {
            if (obsevacao != null)
            {
                _Observacao = obsevacao;
                return true;
            }
            else
            {
                Noticia.Add("Campo Observacao nullo");
                return false;
            }
        }

        bool ISangria_e.Set_Valor(string valor)
        {
            if (valor != null)
            {
                try
                {
                    if (decimal.TryParse(valor, out decimal result))
                    {
                        _Valor = result;
                        return true;
                    }
                    else
                    {
                        Noticia.Add("Valor nao convertido em moeda");
                        return false;
                    }

                }
                catch (System.Exception e)
                {
                    Noticia.Add(e.Message);
                    return false;
                }
            }
            else
            {
                Noticia.Add("Campo Valor Vazio");
                return false;
            }
        }
    }
}