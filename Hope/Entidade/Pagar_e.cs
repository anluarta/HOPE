using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hope.Entidade
{
    internal class Pagar_e : IPagar_e
    {
        private decimal _Bruto;
        private decimal _Desconto;
        private decimal _Cobrado { get { return decimal.Subtract(_Bruto, _Desconto); } }
        private decimal _Recebido
        {
            get
            {
                return (
                    _Dinheiro +
                    _Debito +
                    _Credito +
                    _Cheque +
                    _Vale_Alimentacao +
                    _Vale_Refeicao +
                    _Outro +
                    _Interno
                    );
            }
        }
        private decimal _Dinheiro;
        private decimal _Debito;
        private decimal _Credito;
        private decimal _Cheque;
        private decimal _Vale_Alimentacao;
        private decimal _Vale_Refeicao;
        private decimal _Outro;
        private decimal _Interno;
        private decimal _Troco
        {
            get
            {
                if (_Dinheiro != 0)
                {
                    return decimal.Subtract(_Cobrado, _Dinheiro);

                }
                else
                {
                    return 0;
                }
            }
        }

        List<string> Noticia;
        private Pagar_e()
        {
            Noticia = new List<string>();
            _Bruto = Zero;
            _Desconto = Zero;
            _Dinheiro = Zero;
            _Debito = Zero;
            _Credito = Zero;
            _Cheque = Zero;
            _Vale_Alimentacao = Zero;
            _Vale_Refeicao = Zero;
            _Outro = Zero;
            _Interno = Zero;
        }
        public Pagar_e(decimal get_Valor_Total) : this()
        {
            this._Bruto = get_Valor_Total;
        }
        internal Pagar_e(object dadoserial) : this()
        {
            if (dadoserial.ToString().Contains(",")& dadoserial.ToString().Contains(":"))
            {
                string[] vs = dadoserial.ToString().Split(char.Parse(","));
                Dictionary<int, object> key = new Dictionary<int, object>();
                foreach (string item in vs)
                {
                    string[] subitem = item.Split(char.Parse(":"));
                    key.Add(int.Parse(subitem[0]), subitem[1]);
                }
                _Bruto = decimal.Parse(key[Key_Bruto].ToString());
                _Desconto = decimal.Parse(key[Key_Desconto].ToString());
                _Dinheiro = decimal.Parse(key[Key_Dinheiro].ToString());
                _Debito = decimal.Parse(key[Key_Debito].ToString());
                _Credito = decimal.Parse(key[Key_Credito].ToString());
                _Cheque = decimal.Parse(key[Key_Cheque].ToString());
                _Vale_Alimentacao = decimal.Parse(key[Key_Vale_Alimentacao].ToString());
                _Vale_Refeicao = decimal.Parse(key[Key_Vale_Refeicao].ToString());
                _Outro = decimal.Parse(key[Key_Outro].ToString());
                _Interno = decimal.Parse(key[Key_Interno].ToString());
            }
        }

        decimal IPagar_e.Bruto => _Bruto;
        decimal IPagar_e.Desconto => _Desconto;
        decimal IPagar_e.Cobrado => _Cobrado;
        decimal IPagar_e.Recebido => _Recebido;
        decimal IPagar_e.Dinheiro => _Dinheiro;
        decimal IPagar_e.Debito => _Debito;
        decimal IPagar_e.Credito => _Credito;
        decimal IPagar_e.Cheque => _Cheque;
        decimal IPagar_e.Vale_Alimentacao => _Vale_Alimentacao;
        decimal IPagar_e.Vale_Refeicao => _Vale_Refeicao;
        decimal IPagar_e.Outro => _Outro;
        decimal IPagar_e.Interno => _Interno;
        decimal IPagar_e.Troco => _Troco;
        bool IPagar_e.Set_Cheque(string Valor)
        {
            _Cheque = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }
        bool IPagar_e.Set_Credito(string Valor)
        {
            _Credito = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }

        bool IPagar_e.Set_Debito(string Valor)
        {
            _Debito = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }

        bool IPagar_e.Set_Desconto(string Valor)
        {
            _Desconto = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }

        bool IPagar_e.Set_Dinheiro(string Valor)
        {
            _Dinheiro = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }

        bool IPagar_e.Set_Interno(string Valor)
        {
            _Interno = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }

        bool IPagar_e.Set_Outro(string Valor)
        {
            _Outro = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }
        bool IPagar_e.Set_Vale_Alimentacao(string Valor)
        {
            _Vale_Alimentacao = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }
        bool IPagar_e.Set_Vale_Refeicao(string Valor)
        {
            _Vale_Refeicao = decimal.Parse(Valor);
            return true;
            throw new NotImplementedException();
        }
        internal string ToSerilizacao()
        {
            string format = "{0}:{1},";
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format(format, Key_Dinheiro, _Dinheiro));
            builder.Append(string.Format(format, Key_Bruto, _Bruto));
            builder.Append(string.Format(format, Key_Desconto, _Desconto));
            builder.Append(string.Format(format, Key_Cobrado, _Cobrado));
            builder.Append(string.Format(format, Key_Recebido, _Recebido));
            builder.Append(string.Format(format, Key_Debito, _Debito));
            builder.Append(string.Format(format, Key_Credito, _Credito));
            builder.Append(string.Format(format, Key_Cheque, _Cheque));
            builder.Append(string.Format(format, Key_Vale_Alimentacao, _Vale_Alimentacao));
            builder.Append(string.Format(format, Key_Vale_Refeicao, _Vale_Refeicao));
            builder.Append(string.Format(format, Key_Outro, _Outro));
            builder.Append(string.Format(format, Key_Interno, _Interno));
            builder.Append(string.Format(format, Key_Troco, _Troco));
            return builder.ToString();
        }
        internal const int Key_Bruto = 1;
        internal const int Key_Desconto = 2;
        internal const int Key_Cobrado = 3;
        internal const int Key_Recebido = 4;
        internal const int Key_Dinheiro = 5;
        internal const int Key_Debito = 6;
        internal const int Key_Credito = 7;
        internal const int Key_Cheque = 8;
        internal const int Key_Vale_Alimentacao = 9;
        internal const int Key_Vale_Refeicao = 10;
        internal const int Key_Outro = 11;
        internal const int Key_Interno = 12;
        internal const int Key_Troco = 13;

        private const decimal Zero = 0.00m;
    }
}