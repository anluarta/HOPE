using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class Cupom_Pagar_Ent_abs : Entidade.ICupom_Pagar_Ent_c
    {
        internal string _Bruto;
        internal string _Desconto;
        internal string _Cobrado;
        internal string _Recebido;
        internal string _Dinheiro;
        internal string _Debito;
        internal string _Credito;
        internal string _Cheque;
        internal string _Vale_Alimentacao;
        internal string _Vale_Refeicao;
        internal string _Outro;
        internal string _Interno;
        internal string _Conta_Cliente;
        internal string _Troco
        {
            get
            {
                return "";
            }
        }
        internal void Clea()
        {
            _Bruto=string.Empty;
            _Desconto=string.Empty;
            _Cobrado=string.Empty;
            _Recebido=string.Empty;
            _Dinheiro=string.Empty;
            _Debito=string.Empty;
            _Credito=string.Empty;
            _Cheque=string.Empty;
            _Vale_Alimentacao=string.Empty;
            _Vale_Refeicao=string.Empty;
            _Outro=string.Empty;
            _Interno=string.Empty;
            _Conta_Cliente=string.Empty;

        }
        string ICupom_Pagar_Ent_c.Bruto => _Bruto;
        string ICupom_Pagar_Ent_c.Desconto => _Desconto;
        string ICupom_Pagar_Ent_c.Cobrado => _Cobrado;
        string ICupom_Pagar_Ent_c.Recebido => _Recebido;
        string ICupom_Pagar_Ent_c.Dinheiro => _Dinheiro;
        string ICupom_Pagar_Ent_c.Debito => _Debito;
        string ICupom_Pagar_Ent_c.Credito => _Credito;
        string ICupom_Pagar_Ent_c.Cheque => _Cheque;
        string ICupom_Pagar_Ent_c.Vale_Alimentacao => _Vale_Alimentacao;
        string ICupom_Pagar_Ent_c.Vale_Refeicao => _Vale_Refeicao;
        string ICupom_Pagar_Ent_c.Outro => _Outro;
        string ICupom_Pagar_Ent_c.Interno => _Interno;
        string ICupom_Pagar_Ent_c.Conta_Cliente => _Conta_Cliente;
        string ICupom_Pagar_Ent_c.Troco => _Troco;

        bool ICupom_Pagar_Ent_c.Set_Bruto(string Valor)
        {
            _Bruto = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Cheque(string Valor)
        {
            _Cheque = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Cobrado(string Valor)
        {
            _Cobrado = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Conta_Cliente(string Valor)
        {
            _Conta_Cliente = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Credito(string Valor)
        {
            _Credito = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Debito(string Valor)
        {
            _Debito = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Desconto(string Valor)
        {
            _Desconto = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Dinheiro(string Valor)
        {
            _Dinheiro = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Interno(string Valor)
        {
            _Interno = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Outro(string Valor)
        {
            _Outro = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Recebido(string Valor)
        {
            _Recebido = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Vale_Alimentacao(string Valor)
        {
            _Vale_Alimentacao = Valor;
            return true;
            throw new NotImplementedException();
        }

        bool ICupom_Pagar_Ent_c.Set_Vale_Refeicao(string Valor)
        {
            _Vale_Refeicao = Valor;
            return true;
            throw new NotImplementedException();
        }
    }
}
