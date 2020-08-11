using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Caixa_e : ICaixa_e
    {
        // nao mexer nessa propiedade fora do metodo Dispariedade
        private Caixa_e Temporario;
        List<string> Noticia;
        internal int ID { get; private set; }
        internal IColaborador_e Colaborador { get; private set; }
        internal DateTime StartTime { get; private set; }
        internal DateTime FinishTime { get; private set; }
        internal decimal vDinheiro { get; private set; }
        internal decimal vDebito { get; private set; }
        internal decimal vCredito { get; private set; }
        internal decimal vCheque { get; private set; }
        internal decimal vValeAlimentacao { get; private set; }
        internal decimal vValeRefeicao { get; private set; }
        internal decimal vOutro { get; private set; }
        internal decimal vInterno { get; private set; }
        internal decimal vSangria { get; private set; }
        internal decimal vSuprimento { get; private set; }
        internal decimal vTroco { get; private set; }
        internal decimal vRecebido { get; private set; }
        internal decimal vVendido { get; private set; }
        internal decimal vCancelado { get; private set; }
        string ICaixa_e.Get_ID => ID.ToString();
        string ICaixa_e.Get_Colaborador => Colaborador.Get_Nome_Vendedo;
        string ICaixa_e.Get_Start_DateTime => StartTime.ToString();
        string ICaixa_e.Get_finish_DateTime => FinishTime.ToString();
        public Caixa_e(int Index, IColaborador_e colaborador, DateTime start)
        {
            Noticia = new List<string>();
            ID = Index;
            Colaborador = colaborador;
            StartTime = start;
            FinishTime = DateTime.Parse("01/01/01 23:59:59");
            Temporario = null;
        }
        public Caixa_e(int Index, IColaborador_e colaborador, DateTime start, DateTime finish) : this(Index, colaborador, start)
        {
            Noticia.Add("Caixa_e finalizado");
            FinishTime = finish;
        }
        protected Caixa_e(Caixa_e _E)
        {
            Noticia = new List<string>();
            ID = _E.ID;
            Colaborador = _E.Colaborador;
            StartTime = _E.StartTime;
            FinishTime = _E.FinishTime;
            vDinheiro = _E.vDinheiro;
            vDebito = _E.vDebito;
            vCredito = _E.vCredito;
            vCheque = _E.vCheque;
            vValeAlimentacao = _E.vValeAlimentacao;
            vValeRefeicao = _E.vValeRefeicao;
            vOutro = _E.vOutro;
            vInterno = _E.vInterno;
            vSangria = _E.vSangria;
            vSuprimento = _E.vSuprimento;
            vTroco = _E.vTroco;
            vRecebido = _E.vRecebido;
            vVendido = _E.vVendido;
            vCancelado = _E.vCancelado;
        }
        bool ICaixa_e.Add(ISangria_e entidade)
        {
            if (entidade != null)
            {
                Entidade.Sangria_e _E = entidade as Entidade.Sangria_e;

            }
            else
            {
                Noticia.Add("Entidade  nula");
                return false;
            }
        }

        bool ICaixa_e.Add(ISuprimento_e entidade)
        {
            if (entidade != null)
            {
                Entidade.Suprimento_e _E = entidade as Entidade.Suprimento_e;

            }
            else
            {
                Noticia.Add("Entidade  nula");
                return false;
            }
        }

        string ICaixa_e.Cheque()
        {
            return vCheque.ToString("f2");
        }

        string ICaixa_e.Credito()
        {
            return vCredito.ToString("f2");

        }

        string ICaixa_e.Debito()
        {
            return vDebito.ToString("f2");

        }

        string ICaixa_e.Dinheiro()
        {
            return vDinheiro.ToString("f2");
        }

        void ICaixa_e.Fechamento()
        {
            Noticia.Add("Caixa Fechado");
            FinishTime = DateTime.Now;
        }

        string ICaixa_e.Interno()
        {
            return vInterno.ToString("f2");
        }

        string ICaixa_e.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        string ICaixa_e.Outro()
        {
            return vOutro.ToString("f2");
        }

        string ICaixa_e.Sangria()
        {
            return vSangria.ToString("f2");
        }

        string ICaixa_e.Suprimento()
        {
            return vSuprimento.ToString("f2");
        }

        string ICaixa_e.Vale_Alemintacao()
        {
            return vValeAlimentacao.ToString("f2");
        }

        string ICaixa_e.Vale_Refeicao()
        {
            return vValeRefeicao.ToString("f2");
        }

        internal bool Disparidade()
        {
            if (Temporario != null)
            {
                if (Temporario.FinishTime.Equals(DateTime.Parse("01/01/01 23:59:59")))
                {
                    List<bool> vs = new List<bool>()
                    {
                        Temporario.vCancelado.Equals(vCancelado),
                        Temporario.vCheque.Equals(vCancelado),
                        Temporario.vCredito.Equals(vCancelado),
                        Temporario.vDebito.Equals(vCancelado),
                        Temporario.vDinheiro.Equals(vCancelado),
                        Temporario.vInterno.Equals(vCancelado),
                        Temporario.vOutro.Equals(vCancelado),
                        Temporario.vRecebido.Equals(vCancelado),
                        Temporario.vSangria.Equals(vCancelado),
                        Temporario.vSuprimento.Equals(vCancelado),
                        Temporario.vValeAlimentacao.Equals(vCancelado),
                        Temporario.vValeRefeicao.Equals(vCancelado)
                    };
                    if (vs.Exists(x => x == false))
                    {
                        Noticia.Add("Existe mudanca a ser aplicada");
                        return true;
                    }
                    else
                    {
                        Noticia.Add("Nao existe Disparidade no valores");
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("FinishTime ja aplicado");
                    return false;
                }
            }
            else
            {

                Temporario = new Caixa_e(this);
                return true;
            }
        }
        internal Dictionary<string, object> GetToDataValue()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Index", ID);
            return data;
        }
        internal void SetToDataValue(decimal _Cancelado, decimal _Cheque, decimal _Credito, decimal _Debito, decimal _Dinheiro, decimal _Interno, decimal _Outro, decimal _Recebido, decimal _Sangria, decimal _Suprimento, decimal _Troco, decimal _ValeAlimentacao, decimal _ValeRefeicao, decimal _Vendido)
        {
            this.vCancelado = _Cancelado;
            this.vCheque = _Cheque;
            this.vCredito = _Credito;
            this.vDebito = _Debito;
            this.vDinheiro = _Dinheiro;
            this.vInterno = _Interno;
            this.vOutro = _Outro;
            this.vRecebido = _Recebido;
            this.vSangria = _Sangria;
            this.vSuprimento = _Suprimento;
            this.vTroco = _Troco;
            this.vValeAlimentacao = _ValeAlimentacao;
            this.vValeRefeicao = _ValeRefeicao;
            this.vVendido = _Vendido;
            return;
        }
    }
}
