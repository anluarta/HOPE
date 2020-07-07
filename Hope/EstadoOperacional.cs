using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
     class EstadoOperacional : AbsEstadoOperacional
    {
        public EstadoOperacional(bool _Debug)
        {
            TempoExecucao = new List<IFace.IListaRegistroExecucao>();
            AddLinhaExecucao("Operacao DEBUGAR Iniciado", _Debug.ToString());
            IsDebug = _Debug;
            if (_Debug) { MeuConsole = new frmMeuConsole(); }
        }
        public override void ExibirRegistroExecucao()
        {
            if (MeuConsole == null)
            {
                MeuConsole = new frmMeuConsole();
            }
            MeuConsole.Show();
        }

        public override void AddLinhaExecucao(string _acao,string _resultado)
        {
            TempoExecucao.Add(
                new ListaRegistroExecucao()
                {
                    tempo = DateTime.Now.TimeOfDay,
                    Acao = _acao,
                    Resultado = _resultado
                });

        }
    }
}
