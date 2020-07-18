using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class CaixaTotal_Ent_abs : Entidade.ICaixaTotal_Ent_c
    {
        public string _Recebimento { get; }
        public string _Reforco { get; }
        public string _Sangria { get; }
        public string _ContaCliente { get; }
        public string _Interno { get; }
        public string _Dinheiro { get; }
        public string _Debito { get; }
        public string _Credito { get; }
        public string _Cheque { get; }
        public string _Vale_Alimentacao { get; }
        public string _Vale_Refeicao { get; }
        public string _Outro { get; }
        public string _Cupom_Cancelado { get; }
        public string _Cupom_Vendido { get; }
        string ICaixaTotal_Ent_c.Recebimento => _Recebimento;

        string ICaixaTotal_Ent_c.Reforco => _Reforco;

        string ICaixaTotal_Ent_c.Sangria =>_Sangria;

        string ICaixaTotal_Ent_c.ContaCliente => _ContaCliente;

        string ICaixaTotal_Ent_c.Interno => _Interno;

        string ICaixaTotal_Ent_c.Dinheiro =>_Dinheiro;

        string ICaixaTotal_Ent_c.Debito =>_Debito;

        string ICaixaTotal_Ent_c.Credito => _Credito;

        string ICaixaTotal_Ent_c.Cheque => _Cheque;

        string ICaixaTotal_Ent_c.ValeAlimentacao =>_Vale_Alimentacao;

        string ICaixaTotal_Ent_c.ValeRefeicao =>_Vale_Refeicao;

        string ICaixaTotal_Ent_c.Outro => _Outro;

        string ICaixaTotal_Ent_c.CupomCancelado => _Cupom_Cancelado;

        string ICaixaTotal_Ent_c.CupomVendido => _Cupom_Vendido;
    }
}
