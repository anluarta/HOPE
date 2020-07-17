using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Informacao_b : Controle.Informacao_abs
    {
        internal override void Add(string Codigo, string Mensagem)
        {
            HopeDataSet.InformacaoRow row = Hope.localSet.Informacao.NewInformacaoRow();
            row.Codigo = Codigo;
            row.Mensagem = Mensagem;
            Hope.localSet.Informacao.Rows.Add(row);
        }

        internal override void Clear()
        {
            Hope.localSet.Informacao.Rows.Clear();
        }

        internal override string Menssagems()
        {
            if (Hope.localSet.Informacao.Count != 0)
            {
                string text = string.Empty;
                foreach (HopeDataSet.InformacaoRow item in Hope.localSet.Informacao.Rows)
                {
                    text += item.Mensagem + Environment.NewLine;
                }
                Clear();
                return text;
            }
            else
            {
                return "Nao Existe Informacao Armazenado";
            }
        }
    }
}
