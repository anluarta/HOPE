using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope
{
    abstract class AbsCaixa : Contrato.ICaixa
    {
        internal Entidade.ICaixa _MeuCaixa;
        internal ICaixaTotal _MeuTotalCaixa;
        IRecebimento Contrato.ICaixa.Recebimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string Contrato.ICaixa.ReforcoTotal => _MeuTotalCaixa.Reforco;

        string Contrato.ICaixa.SangriaTotal => _MeuTotalCaixa.Sangria;

        string Contrato.ICaixa.DinheiroTotal => _MeuTotalCaixa.Dinheiro;

        string Contrato.ICaixa.DebidoTotal => _MeuTotalCaixa.Debito;

        string Contrato.ICaixa.CreditoTotal => _MeuTotalCaixa.Credito;

        string Contrato.ICaixa.ChequeTotal => _MeuTotalCaixa.Cheque;

        string Contrato.ICaixa.ValeAlimentacaoTotal => _MeuTotalCaixa.ValeAlimentacao;

        string Contrato.ICaixa.ValeRefeicaoTotal => _MeuTotalCaixa.ValeRefeicao;

        string Contrato.ICaixa.OutroTotal => _MeuTotalCaixa.Outro;

        string Contrato.ICaixa.ContaClienteTotal => _MeuTotalCaixa.ContaCliente;

        string Contrato.ICaixa.InternoTotal => _MeuTotalCaixa.Interno;

        string Contrato.ICaixa.RecebimentoTotal => _MeuTotalCaixa.Recebimento;

        public bool DetalheValorTotalRegistro(DataGridViewRow dataGridViewRow, out string msgdetalhe, out ICaixaTotal totais)
        {
            msgdetalhe = "";
            ICaixaTotal v = new CaixaTotal();
            v.Cheque = "0,00";
            v.ContaCliente = "0,00";
            v.Credito = "0,00";
            v.CupomCancelado = "0,00";
            v.CupomVendido = "0,00";
            v.Debito = "0,00";
            v.Dinheiro = "0,00";
            v.EntradaCaixa = "0,00";
            v.Interno = "0,00";
            v.Outro = "0,00";
            v.Recebimento = "0,00";
            v.Reforco = "0,00";
            v.Sangria = "0,00";
            v.ValeAlimentacao = "0,00";
            v.ValeRefeicao = "0,00";
            totais = v;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICaixa.EncerrarMeuCaixa(out string _msgresult)
        {
            _msgresult = "";
           
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICaixa.IniciarMeuCaixa(out string _msgresult)
        {
            _msgresult = "";
            _MeuCaixa = new Entidade.Caixa() { Abertura = "00/00/0000 00:00:00", ID_Caixa = "3", Fk_ID_Usuario = "1" };
            _MeuTotalCaixa = new Entidade.CaixaTotal()
            {
                Cheque = "0,00",
                ContaCliente = "0,00",
                Credito = "0,00",
                CupomCancelado = "0,00",
                CupomVendido = "0,00",
                Debito = "0,00",
                Dinheiro = "0,00",
                EntradaCaixa = "0,00",
                Interno = "0,00",
                Outro = "0,00",
                Recebimento = "0,00",
                Reforco = "0,00",
                Sangria = "0,00",
                ValeAlimentacao = "0,00",
                ValeRefeicao = "0,00"
            };
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICaixa.Localizar(string _operacao, string _local, string _orden, int _limit, string _termo, out Entidade.ICaixa[] caixa,out string msgresult)
        {
            Entidade.ICaixa[] vs = new Entidade.ICaixa[]
            {
                new Entidade.Caixa(){ ID_Caixa="1", Abertura="00/00/0000 00:00:00",Fk_ID_Usuario="1",Fechamento="00/00/0000 00:00:00"},
                new Entidade.Caixa(){ ID_Caixa="2", Abertura="00/00/0000 00:00:00",Fk_ID_Usuario="1",Fechamento="00/00/0000 00:00:00"}
            };
            caixa = vs;
            msgresult = "";
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICaixa.Reforco(string _Valor, string _Observacao, out string _MsgResult)
        {
            _MsgResult = "";
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICaixa.Sangria(string _Valor, string _Observacao, out string _MsgResult)
        {
            _MsgResult = "";
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICaixa.Situacao(out string _MsgResult)
        {
            _MsgResult = "";
            return true;
            throw new NotImplementedException();
        }
    }
}
