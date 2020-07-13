using Hope.Entidade;
using System.Windows.Forms;

namespace Hope.Contrato
{
    public interface ICaixa
    {
        IRecebimento Recebimento { get; set; }
        bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo,out Entidade.ICaixa[] caixa, out string msgresult);
        bool IniciarMeuCaixa(out string _msgresult);
        bool EncerrarMeuCaixa(out string _msgresult);
        bool Sangria(string _Valor, string _Observacao,out string _MsgResult);
        bool Reforco(string _Valor,string _Observacao, out string _MsgResult);
        bool Situacao(out string _MsgResult);
        string ReforcoTotal { get; }
        string SangriaTotal { get; }
        string DinheiroTotal { get; }
        string DebidoTotal { get; }
        string CreditoTotal { get; }
        string ChequeTotal { get; }
        string ValeAlimentacaoTotal { get; }
        string ValeRefeicaoTotal { get; }
        string OutroTotal { get; }
        string ContaClienteTotal { get; }
        string InternoTotal { get; }
        string RecebimentoTotal { get; }

        bool DetalheValorTotalRegistro(DataGridViewRow dataGridViewRow, out string msgdetalhe, out ICaixaTotal totais);
    }
}