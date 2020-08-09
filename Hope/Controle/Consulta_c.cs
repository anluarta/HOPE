using Hope.Enums;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Consulta_c : IConsulta
    {
        Enums.Consulta_u.Comando comando;
        object local, termo;
        public Consulta_u.Comando Comando { get => comando; set => comando = value; }
        public object Local { get => local; set => local = value; }
        public object Termo { get => termo; set => termo = value; }
        internal abstract string ToSql();
    }
}
