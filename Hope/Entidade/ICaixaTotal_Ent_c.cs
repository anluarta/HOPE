using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    public interface ICaixaTotal_Ent_c
    {
        string Recebimento { get; }
        string Reforco { get; }
        string Sangria { get; }
        string ContaCliente { get; }
        string Interno { get; }
        string Dinheiro { get; }
        string Debito { get; }
        string Credito { get; }
        string Cheque { get; }
        string ValeAlimentacao { get; }
        string ValeRefeicao { get; }
        string Outro { get; }
        string CupomCancelado { get; }
        string CupomVendido { get; }
    }
}
