using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
   public abstract class Caixa_Ent_abs : ICaixa_Ent_c
    {
        internal int _ID_Caixa;
        internal int _ID_Colaborador;
        internal string _Abertura;
        internal string _Fechamento;
        internal CaixaTotal_Ent_abs total_Ent_Abs;
        public void Clea()
        {
            _ID_Caixa = 0;
            _ID_Colaborador = 0;
            _Abertura = string.Empty;
            _Fechamento = string.Empty;
            total_Ent_Abs.Clea();
        }
        int ICaixa_Ent_c.ID_Caixa => _ID_Caixa;

        int ICaixa_Ent_c.ID_Colaborador => _ID_Colaborador;

        string ICaixa_Ent_c.Dia_Hora_Abertura => _Abertura;

        string ICaixa_Ent_c.Dia_Hora_Fechamento => _Fechamento;
    }
}
