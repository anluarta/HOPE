using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
   public class CaixaTotal_Ent_abs : ICaixaTotal_Ent_c
    {
        protected const decimal Zero = 0.0m;
        internal decimal _Recebimento;
        internal decimal _Reforco;
        internal decimal _Sangria;
        internal decimal _Interno;
        internal decimal _Dinheiro;
        internal decimal _Debito;
        internal decimal _Credito;
        internal decimal _Cheque;
        internal decimal _Vale_Alimentacao;
        internal decimal _Vale_Refeicao;
        internal decimal _Outro;

        internal void Clea()
        {
            _Recebimento = Zero;
            _Reforco = Zero;
            _Sangria = Zero;
            _Interno = Zero;
            _Dinheiro = Zero;
            _Debito = Zero;
            _Credito = Zero;
            _Cheque = Zero;
            _Vale_Alimentacao = Zero;
            _Vale_Refeicao = Zero;
            _Outro = Zero;
        }

        internal decimal _Cupom_Cancelado;
        internal decimal _Cupom_Vendido;
        internal decimal _Desconto;
        internal decimal _Troco;

        string ICaixaTotal_Ent_c.Recebimento => _Recebimento.ToString();

        string ICaixaTotal_Ent_c.Reforco => _Reforco.ToString();

        string ICaixaTotal_Ent_c.Sangria => _Sangria.ToString();


        string ICaixaTotal_Ent_c.Interno => _Interno.ToString();

        string ICaixaTotal_Ent_c.Dinheiro => _Dinheiro.ToString();

        string ICaixaTotal_Ent_c.Debito => _Debito.ToString();

        string ICaixaTotal_Ent_c.Credito => _Credito.ToString();

        string ICaixaTotal_Ent_c.Cheque => _Cheque.ToString();

        string ICaixaTotal_Ent_c.ValeAlimentacao => _Vale_Alimentacao.ToString();

        string ICaixaTotal_Ent_c.ValeRefeicao => _Vale_Refeicao.ToString();

        string ICaixaTotal_Ent_c.Outro => _Outro.ToString();

        string ICaixaTotal_Ent_c.CupomCancelado => _Cupom_Cancelado.ToString();

        string ICaixaTotal_Ent_c.CupomVendido => _Cupom_Vendido.ToString();
    }
}
