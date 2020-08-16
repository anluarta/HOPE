using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hope.Entidade
{
    internal class Sangria_e : ISangria_e
    {
        List<string> Noticia;
        int _index;
        int IdCaixa;
        string Colabora;
        string _Observacao;
        DateTime _datatime_registro_salvo;
        decimal _Valor;
        public Sangria_e(object caixaID, object colaborador)
        {
            this.IdCaixa = int.Parse(caixaID.ToString());
            this.Colabora = (string)colaborador;
            Noticia = new List<string>();
        }

        internal Sangria_e(object index, object idCaixa, object colaborador, object dataregistro, object observacao, object valor)
        {
            Noticia = new List<string>();
            _index = int.Parse((string)index);
            IdCaixa = int.Parse((string)idCaixa);
            Colabora = (string)colaborador;
            _datatime_registro_salvo = DateTime.Parse((string)dataregistro);
            this._Valor = (decimal)valor;
        }

        internal Dictionary<int, object> GetKeyValuesData()
        {
            Dictionary<int, object> keys = new Dictionary<int, object>();
            try
            {
                keys.Add(Key_CaixaID, IdCaixa);
                keys.Add(Key_Colacorado, Colabora);
                keys.Add(Key_Observacao, _Observacao);
                keys.Add(Key_Valor, _Valor);
            }
            catch (System.Exception e)
            {
                Noticia.Add(e.Message);
            }
            return keys;
        }
        int ISangria_e.Id_Sangria => this._index;
        int ISangria_e.Id_Caixa => this.IdCaixa;
        DateTime ISangria_e.Data_Registro => this._datatime_registro_salvo;
        decimal ISangria_e.Valor => this._Valor;
        string ISangria_e.Observacao => this._Observacao;

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

        IColaborador_e ISangria_e.Get_Colaborador()
        {
            return new Colaborador_e(this.Colabora);
        }
        internal const int Key_Index = 1;
        internal const int Key_CaixaID = 2;
        internal const int Key_Data_Registro = 3;
        internal const int Key_Colacorado = 4;
        internal const int Key_Observacao = 5;
        internal const int Key_Valor = 6;

    }
}