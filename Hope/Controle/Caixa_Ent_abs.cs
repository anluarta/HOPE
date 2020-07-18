using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Caixa_Ent_abs : Entidade.ICaixa_Ent_c
    {
        public string _ID_Caixa { get; set; }
        public string _Fk_ID_Usuario { get; set; }
        public string _Abertura { get; set; }
        public string _Fechamento { get; set; }
        internal void Clea()
        {
            _ID_Caixa = string.Empty;
            _Fk_ID_Usuario = string.Empty;
            _Abertura = string.Empty;
            _Fechamento = string.Empty;

        }
        string ICaixa_Ent_c.ID_Caixa => _ID_Caixa;

        string ICaixa_Ent_c.Fk_ID_Usuario => _Fk_ID_Usuario;

        string ICaixa_Ent_c.Abertura => _Abertura;

        string ICaixa_Ent_c.Fechamento => _Fechamento;
    }
}
