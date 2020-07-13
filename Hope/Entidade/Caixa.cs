using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Caixa : ICaixa
    {
        public string ID_Caixa { get; set; }
        public string Fk_ID_Usuario { get; set; }
        public string Abertura { get; set; }
        public string Fechamento { get; set; }

        //internal string Reforco;

        //internal string Sangria;

        //internal string Dinheiro;

        //internal string Debido;

        //internal string Credito;

        //internal string Cheque;

        //internal string ValeAlimentacao;

        //internal string ValeRefeicao;

        //internal string Outro;

        //internal string ContaCliente;

        //internal string Interno;
    }
}
