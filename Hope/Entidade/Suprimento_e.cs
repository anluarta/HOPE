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
        
        List<string> Noticia;
        int _index;
        private readonly int CaixaID;
        private readonly string Colabora;
       internal DateTime _datatime_registro_salvo;
        internal string _vObservacao { get; private set; }
        internal decimal _vValor { get; private set; }

        int ISuprimento_e.Index => _index;

        int ISuprimento_e.Id_Caixa => CaixaID;

        DateTime ISuprimento_e.Data_Registro => _datatime_registro_salvo;

        string ISuprimento_e.Observacao => _vObservacao;

        decimal ISuprimento_e.Valor => _vValor;
        private Suprimento_e()
        {
            Noticia = new List<string>();

        }
        internal Suprimento_e(object caixaID, object colaborador):this()
        {
            _index = 0;
            _datatime_registro_salvo = DateTime.MinValue;
            _vObservacao = string.Empty;
            _vValor = 0.0m;
            this.CaixaID = int.Parse((string)caixaID);
            this.Colabora = (string)colaborador;
        }
        internal Suprimento_e(object index,object idcaixa,object colaborado,object datatimeregistro,object valor) : this()
        {
            _index = (int)index;
            CaixaID = (int)idcaixa;
            Colabora = (string)colaborado;
            _datatime_registro_salvo = (DateTime)datatimeregistro;
            _vValor = (decimal)valor;
        }
        internal Dictionary <int,object> GetKeysValueData()
        {
            Dictionary<int, object> keys = new Dictionary<int, object>();
            try
            {
                keys.Add(Key_Index, _index);
                keys.Add(Key_CaixaID, CaixaID);
                keys.Add(Key_DataTime_Registro, _datatime_registro_salvo);
                keys.Add(Key_Colaborado, Colabora);
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
        
        IColaborador_e ISuprimento_e.Colaborador()
        {
            return new Colaborador_e(this.Colabora);
        }
        
        internal const int Key_Index = 1;
        internal const int Key_CaixaID = 2;
        internal const int Key_DataTime_Registro = 3;
        internal const int Key_Colaborado = 4;
        internal const int Key_Valor =5;
        internal const int Key_Observacao = 6;

    }
}
