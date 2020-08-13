using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Suprimento_e : ISuprimento_e
    {
        internal const string Key_CaixaID = "CaixaID";
        internal const string Key_ColaboradoID = "ColaboradoID";
        internal const string Key_Valor = "Valor";
        internal const string Key_Observacao = "Observacao";
        List<string> Noticia;
        private readonly int CaixaID;
        private readonly string ColaboraID;

        internal string _vObservacao { get; private set; }
        internal decimal _vValor { get; private set; }
        internal Suprimento_e(int caixaID, string colaboraID)
        {
            Noticia = new List<string>();
            _vObservacao = string.Empty;
            _vValor = 0.0m;
            this.CaixaID = caixaID;
            this.ColaboraID = colaboraID;
        }
        internal Dictionary <string,object> GetKeysValueData()
        {
            Dictionary<string, object> keys = new Dictionary<string, object>();
            try
            {
                keys.Add(Key_CaixaID, CaixaID);
                keys.Add(Key_ColaboradoID, ColaboraID);
                keys.Add(Key_Observacao, _vObservacao);
                keys.Add(Key_Valor, _vValor);
            }
            catch (Exception e)
            {
                Noticia.Add(e.Message);
            }
            return keys;
        }
        string ISuprimento_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        bool ISuprimento_e.Set_Observacao(string observacao)
        {
            if (observacao != null)
            {
                _vObservacao = observacao;
                return true;
            }
            else
            {
                Noticia.Add("Campo observacao nullo");
                return false;
            }
        }

        bool ISuprimento_e.Set_Valor(string valor)
        {
            if (valor != null)
            {
                try
                {
                    if (decimal.TryParse(valor,out decimal result))
                    {
                        _vValor = result;
                        return true;
                    }
                    else
                    {
                        Noticia.Add("Nao foi convertido o valor  em moeda");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Noticia.Add(e.Message);
                    return false;
                }
            }
            else
            {
                Noticia.Add("Campo valor nyullo");
                return false;
            }
        }
    }
}
