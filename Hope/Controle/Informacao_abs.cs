using Hope.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Informacao_abs : Contrato.IInformacao_c
    {
        internal abstract void Add(string Codigo, string Mensagem);
        internal abstract void Clear();
        internal abstract string Menssagems();
        string IInformacao_c.ToMessageBox()
        {
            return Menssagems();
        }
    }
}
