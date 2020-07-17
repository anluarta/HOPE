using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface ICaixaTotal_Ent_c
    {
        string Recebimento { get; set; }
        string Reforco { get; set; }
        string Sangria { get; set; }
        string ContaCliente { get; set; }
        string Interno { get; set; }
        string Dinheiro { get; set; }
        string Debito { get; set; }
        string Credito { get; set; }
        string Cheque { get; set; }
        string ValeAlimentacao { get; set; }
        string ValeRefeicao { get; set; }
        string Outro { get; set; }
        string CupomCancelado { get; set; }
        string CupomVendido { get; set; }
    }
}
