using Hope.IFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    abstract class AbsEstadoOperacional : IFace.IEstatdoOperacional
    {

        public List<IListaRegistroExecucao> TempoExecucao { get ; set; }
        public bool IsDebug { get ; set  ; }
        public frmMeuConsole MeuConsole { get ; set ; }

        public abstract void AddLinhaExecucao(string _acao, string _resultado);

        public abstract void ExibirRegistroExecucao();
    }
     class ListaRegistroExecucao: IListaRegistroExecucao
    {
        public TimeSpan tempo { get ; set ; }
        public string Acao { get ; set ; }
        public string Resultado { get ; set ; }

        public override string ToString()
        {
            return
                "\n\n>>>Tempo:\n" + tempo.ToString() +
                "\n\n>>>Acao Inicial: \n" + Acao +
                "\n\n>>>Resultadado: \n" + Resultado +
                "\n\n-";
        }
    }
}
