using Hope.Controle;
using System.Windows.Forms;

namespace Hope.Contrato
{
    public interface ICaixa_c
    {
        IInformacao_c Informacao { get; }
        IRecebimento_c Recebimento { get; }
        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo,out Entidade.ICaixa_Ent_c[] ListaResultado);
        bool IniciarMeuCaixa();
        bool EncerrarMeuCaixa();
        bool Sangria(string _Valor, string _Observacao);
        bool Reforco(string _Valor,string _Observacao);
        bool Situacao();
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

        bool DetalheValorTotalRegistro(DataGridViewRow dataGridViewRow, out Entidade.ICaixaTotal_Ent_c totais);
    }
}