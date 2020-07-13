using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class CaixaTotal : ICaixaTotal
    {
        public string Recebimento { get; set; }
        public string Reforco { get;set;}
        public string Sangria { get;set;}
        public string ContaCliente { get;set;}
        public string Interno { get;set;}
        public string Dinheiro { get;set;}
        public string Debito { get;set;}
        public string Credito { get;set;}
        public string Cheque { get;set;}
        public string ValeAlimentacao { get;set;}
        public string ValeRefeicao { get;set;}
        public string Outro { get;set;}
        public string EntradaCaixa { get;set;}
        public string CupomCancelado { get;set;}
        public string CupomVendido { get;set;}
    }
}
