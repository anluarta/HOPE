using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
   public class Caixa_Ent_b : Controle.Caixa_Ent_abs
    {

        public Caixa_Ent_b()
        {
            _ID_Caixa = 0;
            _ID_Colaborador = 0;
            _Abertura = string.Empty;
            _Fechamento = string.Empty;
            total_Ent_Abs = new CaixaTotal_Ent_b();
        }
        public Caixa_Ent_b(int idcaixa,int idcolaborador,string aberto,string fechado,CaixaTotal_Ent_b totais)
        {
            _ID_Caixa = idcaixa;
            _ID_Colaborador = idcolaborador;
            _Abertura = aberto;
            _Fechamento = fechado;
            total_Ent_Abs = totais;
        }
    }
}
