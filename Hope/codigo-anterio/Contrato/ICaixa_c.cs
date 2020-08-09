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
        bool Sangria(decimal _Valor, string _Observacao);
        bool Reforco(decimal _Valor,string _Observacao);
        bool Situacao();
        string Reforco_Total { get; }
        string Sangria_Total { get; }
        string Dinheiro_Total { get; }
        string Debido_Total { get; }
        string Credito_Total { get; }
        string Cheque_Total { get; }
        string Vale_Alimentacao_Total { get; }
        string Vale_Refeicao_Total { get; }
        string Outro_Total { get; }
        string Interno_Total { get; }
        string Recebimento_Total { get; }

        bool DetalheValorTotalRegistro(object Current, out Entidade.ICaixaTotal_Ent_c totais);
    }
}