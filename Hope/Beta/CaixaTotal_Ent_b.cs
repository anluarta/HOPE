using Hope.Controle;

namespace Hope.Beta
{
   public class CaixaTotal_Ent_b : CaixaTotal_Ent_abs
    {
        public CaixaTotal_Ent_b()
        {
            _Recebimento = 0;
            _Reforco = 0;
            _Sangria = 0;
            _Interno = 0;
            _Dinheiro = 0;
            _Credito = 0;
            _Cheque = 0;
            _Vale_Alimentacao = 0;
            _Vale_Refeicao = 0;
            _Outro = 0;
            _Cupom_Cancelado = 0;
            _Cupom_Vendido = 0;

        }

        public CaixaTotal_Ent_b(decimal debito, decimal cancelado, decimal cheque, decimal credito, decimal dinheiro, decimal interno, decimal outro, decimal recebimento, decimal valealimentacao, decimal valerefeicao, decimal vendido, decimal desconto, decimal troco,decimal reforco,decimal sangria)
        {
            this._Debito = debito;
            this._Cupom_Cancelado = cancelado;
            this._Cheque = cheque;
            this._Credito = credito;
            this._Dinheiro = dinheiro;
            this._Interno = interno;
            this._Outro = outro;
            this._Recebimento = recebimento;
            this._Vale_Alimentacao = valealimentacao;
            this._Vale_Refeicao = valerefeicao;
            this._Cupom_Vendido = vendido;
            this._Desconto = desconto;
            this._Troco = troco;
            this._Reforco = reforco;
            this._Sangria = sangria;
        }
    }
}