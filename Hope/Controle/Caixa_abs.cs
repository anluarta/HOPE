using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope.Controle
{
    abstract class Caixa_abs :Contrato.ICaixa_c
    {
        internal Recebimento_abs _Recebimento;
        internal Entidade.ICaixa_Ent_c _MeuCaixa;
        internal ICaixaTotal_Ent_c _MeuTotalCaixa;
        IRecebimento_c Contrato.ICaixa_c.Recebimento { get => _Recebimento; }

        string Contrato.ICaixa_c.ReforcoTotal => _MeuTotalCaixa.Reforco;

        string Contrato.ICaixa_c.SangriaTotal => _MeuTotalCaixa.Sangria;

        string Contrato.ICaixa_c.DinheiroTotal => _MeuTotalCaixa.Dinheiro;

        string Contrato.ICaixa_c.DebidoTotal => _MeuTotalCaixa.Debito;

        string Contrato.ICaixa_c.CreditoTotal => _MeuTotalCaixa.Credito;

        string Contrato.ICaixa_c.ChequeTotal => _MeuTotalCaixa.Cheque;

        string Contrato.ICaixa_c.ValeAlimentacaoTotal => _MeuTotalCaixa.ValeAlimentacao;

        string Contrato.ICaixa_c.ValeRefeicaoTotal => _MeuTotalCaixa.ValeRefeicao;

        string Contrato.ICaixa_c.OutroTotal => _MeuTotalCaixa.Outro;

        string Contrato.ICaixa_c.ContaClienteTotal => _MeuTotalCaixa.ContaCliente;

        string Contrato.ICaixa_c.InternoTotal => _MeuTotalCaixa.Interno;

        string Contrato.ICaixa_c.RecebimentoTotal => _MeuTotalCaixa.Recebimento;

        IInformacao_c ICaixa_c.Informacao => throw new NotImplementedException();

        public bool DetalheValorTotalRegistro(DataGridViewRow dataGridViewRow,  out ICaixaTotal_Ent_c totais)
        {
            //ICaixaTotal_Ent_c v = new CaixaTotal();
            //v.Cheque = "0,00";
            //v.ContaCliente = "0,00";
            //v.Credito = "0,00";
            //v.CupomCancelado = "0,00";
            //v.CupomVendido = "0,00";
            //v.Debito = "0,00";
            //v.Dinheiro = "0,00";
            //v.Interno = "0,00";
            //v.Outro = "0,00";
            //v.Recebimento = "0,00";
            //v.Reforco = "0,00";
            //v.Sangria = "0,00";
            //v.ValeAlimentacao = "0,00";
            //v.ValeRefeicao = "0,00";
            //totais = v;
            //return true;
            throw new NotImplementedException();
        }

        bool ICaixa_c.EncerrarMeuCaixa()
        {
            throw new NotImplementedException();
        }

        bool ICaixa_c.IniciarMeuCaixa()
        {
            throw new NotImplementedException();
        }

        bool ICaixa_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out ICaixa_Ent_c[] ListaResultado)
        {
            throw new NotImplementedException();
        }

        bool ICaixa_c.Reforco(string _Valor, string _Observacao)
        {
            throw new NotImplementedException();
        }

        bool ICaixa_c.Sangria(string _Valor, string _Observacao)
        {
            throw new NotImplementedException();
        }

        bool ICaixa_c.Situacao()
        {
            throw new NotImplementedException();
        }
    }
}
