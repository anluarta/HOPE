using Hope.Controle;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Model
{
    class Consulta_m
    {
       public class _colaborador : Consulta_c
        {
            internal override string ToSql()
            {
                throw new NotImplementedException();
            }
        }
        public class _caixa : Consulta_c
        {
            internal override string ToSql()
            {
                switch (Comando)
                {
                    case Enums.Consulta_u.Comando.Select_All_From:

                        break;
                    default:
                        return "";
                }
                throw new NotImplementedException();
            }
        }
        public class _vender : Consulta_c
        {
            internal override string ToSql()
            {
                throw new NotImplementedException();
            }
        }
    }
}
