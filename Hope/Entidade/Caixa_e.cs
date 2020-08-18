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
        internal const string Index = "Index";
        internal const string Ant_FinishTime = "Ant_FinishTime";
        internal const string Ant_Dinheiro = "Ant_Dinheiro";
        internal const string Ant_Debido = "Ant_Debido";
        internal const string Ant_Credito = "Ant_Credito";
        internal const string Ant_Cheque = "Ant_Cheque";
        internal const string Ant_ValeAlimentacao = "Ant_ValeAlimentacao";
        internal const string Ant_ValeRefeica = "Ant_ValeRefeica";
        internal const string Ant_Outro = "Ant_Outro";
        internal const string Ant_Internal = "Ant_Internal";
        internal const string Ant_Sangria = "Ant_Sangria";
        internal const string Ant_Suprimento = "Ant_Suprimento";
        internal const string Ant_Troco = "Ant_Troco";
        internal const string Ant_Recebido = "Ant_Recebido";
        internal const string Ant_Vendido = "Ant_Vendido";
        internal const string Ant_Cancelado = "Ant_Cancelado";
        internal const string Ant_Desconto = "Ant_Desconto";
        internal const string Nov_FinishTime = "Nov_FinishTime";
        internal const string Nov_Dinheiro = "Nov_Dinheiro";
        internal const string Nov_Debido = "Nov_Debido";
        internal const string Nov_Credito = "Nov_Credito";
        internal const string Nov_Cheque = "Nov_Cheque";
        internal const string Nov_ValeAlimentacao = "Nov_ValeAlimentacao";
        internal const string Nov_ValeRefeica = "Nov_ValeRefeica";
        internal const string Nov_Outro = "Nov_Outro";
        internal const string Nov_Internal = "Nov_Internal";
        internal const string Nov_Sangria = "Nov_Sangria";
        internal const string Nov_Suprimento = "Nov_Suprimento";
        internal const string Nov_Troco = "Nov_Troco";
        internal const string Nov_Recebido = "Nov_Recebido";
        internal const string Nov_Vendido = "Nov_Vendido";
        internal const string Nov_Cancelado = "Nov_Cancelado";
        internal const string Nov_Desconto = "Nov_Desconto";
        internal static DateTime _ValueFinisTime = DateTime.Parse("01/01/01 23:59:59");
        internal List<Suprimento_e> suprimento_s;
        internal List<Sangria_e> sangria_s;
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
        internal decimal vDesconto { get; private set; }
        string ICaixa_e.Get_ID => ID.ToString();
        string ICaixa_e.Get_Colaborador => Colaborador.Get_Nome_Vendedo;
        string ICaixa_e.Get_Start_DateTime => StartTime.ToString();
        string ICaixa_e.Get_finish_DateTime => FinishTime.ToString();
        public Caixa_e(int Index, IColaborador_e colaborador, DateTime start)
        {
            suprimento_s = new List<Suprimento_e>();
            sangria_s = new List<Sangria_e>();
            Noticia = new List<string>();
            ID = Index;
            Colaborador = colaborador;
            StartTime = start;
            FinishTime = _ValueFinisTime;
            Temporario = null;
            vDinheiro = 0;
            vDebito = 0;
            vCredito = 0;
            vCheque = 0;
            vValeAlimentacao = 0;
            vValeRefeicao = 0;
            vOutro = 0;
            vInterno = 0;
            vSangria = 0;
            vSuprimento = 0;
            vTroco = 0;
            vRecebido = 0;
            vVendido = 0;
            vCancelado = 0;
            vDesconto = 0;
        }
        internal Caixa_e(int Index, IColaborador_e colaborador, DateTime start, DateTime finish, decimal _Dinheiro, decimal _Debito, decimal _Credito, decimal _Cheque, decimal _ValeAlimentacao, decimal _ValeRefeicao, decimal _Outro, decimal _Interno, decimal _Sangria, decimal _Suprimento, decimal _Troco, decimal _Recebido, decimal _Vendido, decimal _Cancelado, decimal _Desconto)
        {
            Noticia = new List<string>();
            ID = Index;
            Colaborador = colaborador;
            StartTime = start;
            FinishTime = finish;
            Temporario = null;
            vDinheiro = _Dinheiro;
            vDebito = _Debito;
            vCredito = _Credito;
            vCheque = _Cheque;
            vValeAlimentacao = _ValeAlimentacao;
            vValeRefeicao = _ValeRefeicao;
            vOutro = _Outro;
            vInterno = _Interno;
            vSangria = _Sangria;
            vSuprimento = _Suprimento;
            vTroco = _Troco;
            vRecebido = _Recebido;
            vVendido = _Vendido;
            vCancelado = _Cancelado;
            vDesconto = _Desconto;
            Noticia.Add("Caixa_e finalizado");
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
                var tempsangria = this.vSangria;
                this.vSangria = decimal.Add(this.vSangria, entidade.Valor);
                if (tempsangria.CompareTo(this.vSangria)>0)
                {
                    string format = "total anterio{0} novo total{1}, diferenca acrecentada{3}";
                    Noticia.Add(string.Format(format, tempsangria, vSangria, entidade.Valor));
                    sangria_s.Add((Sangria_e)entidade);
                    return true;
                }
                else
                {
                    Noticia.Add("valor adicopnado nao acrenta em nada");
                    return false;
                }
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
                var tempSuprimento = this.vSuprimento;
                
                suprimento_s.Add((Suprimento_e)entidade);
                return true;
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
                        Temporario.vCheque.Equals(vCheque),
                        Temporario.vCredito.Equals(vCredito),
                        Temporario.vDebito.Equals(vDebito),
                        Temporario.vDinheiro.Equals(vDinheiro),
                        Temporario.vInterno.Equals(vInterno),
                        Temporario.vOutro.Equals(vOutro),
                        Temporario.vRecebido.Equals(vRecebido),
                        Temporario.vSangria.Equals(vSangria),
                        Temporario.vSuprimento.Equals(vSuprimento),
                        Temporario.vValeAlimentacao.Equals(vValeAlimentacao),
                        Temporario.vValeRefeicao.Equals(vValeRefeicao),
                        Temporario.vDesconto.Equals(vDesconto),
                        Temporario.FinishTime.Equals(FinishTime)
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
        internal Dictionary<string, string> GetToDataValue()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                data.Add(Index, ID.ToString());
                data.Add(Ant_FinishTime, this.Temporario.FinishTime.ToString(System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Dinheiro, this.Temporario.vDinheiro.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Debido, this.Temporario.vDebito.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Credito, this.Temporario.vCredito.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Cheque, this.Temporario.vCheque.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_ValeAlimentacao, this.Temporario.vValeAlimentacao.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_ValeRefeica, this.Temporario.vValeRefeicao.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Outro, this.Temporario.vOutro.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Internal, this.Temporario.vInterno.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Sangria, this.Temporario.vSangria.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Suprimento, this.Temporario.vSuprimento.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Troco, this.Temporario.vTroco.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Recebido, this.Temporario.vRecebido.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Vendido, this.Temporario.vVendido.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Cancelado, this.Temporario.vCancelado.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Ant_Desconto, this.Temporario.vDesconto.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));

                data.Add(Nov_FinishTime, this.FinishTime.ToString(System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Dinheiro, this.vDinheiro.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Debido, this.vDebito.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Credito, this.vCredito.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Cheque, this.vCheque.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_ValeAlimentacao, this.vValeAlimentacao.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_ValeRefeica, this.vValeRefeicao.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Outro, this.vOutro.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Internal, this.vInterno.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Sangria, this.vSangria.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Suprimento, this.vSuprimento.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Troco, this.vTroco.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Recebido, this.vRecebido.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Vendido, this.vVendido.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Cancelado, this.vCancelado.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                data.Add(Nov_Desconto, this.vDesconto.ToString("f4", System.Globalization.CultureInfo.InvariantCulture));
                //data.Add(Index, ID);
                //data.Add(Ant_FinishTime, this.Temporario.FinishTime);
                //data.Add(Ant_Dinheiro, this.Temporario.vDinheiro);
                //data.Add(Ant_Debido, this.Temporario.vDebito);
                //data.Add(Ant_Credito, this.Temporario.vCredito);
                //data.Add(Ant_Cheque, this.Temporario.vCheque);
                //data.Add(Ant_ValeAlimentacao, this.Temporario.vValeAlimentacao);
                //data.Add(Ant_ValeRefeica, this.Temporario.vValeRefeicao);
                //data.Add(Ant_Outro, this.Temporario.vOutro);
                //data.Add(Ant_Internal, this.Temporario.vInterno);
                //data.Add(Ant_Sangria, this.Temporario.vSangria);
                //data.Add(Ant_Suprimento, this.Temporario.vSuprimento);
                //data.Add(Ant_Troco, this.Temporario.vTroco);
                //data.Add(Ant_Recebido, this.Temporario.vRecebido);
                //data.Add(Ant_Vendido, this.Temporario.vVendido);
                //data.Add(Ant_Cancelado, this.Temporario.vCancelado);
                //data.Add(Ant_Desconto, this.Temporario.vDesconto);

                //data.Add(Nov_FinishTime, this.FinishTime);
                //data.Add(Nov_Dinheiro, this.vDinheiro);
                //data.Add(Nov_Debido, this.vDebito);
                //data.Add(Nov_Credito, this.vCredito);
                //data.Add(Nov_Cheque, this.vCheque);
                //data.Add(Nov_ValeAlimentacao, this.vValeAlimentacao);
                //data.Add(Nov_ValeRefeica, this.vValeRefeicao);
                //data.Add(Nov_Outro, this.vOutro);
                //data.Add(Nov_Internal, this.vInterno);
                //data.Add(Nov_Sangria, this.vSangria);
                //data.Add(Nov_Suprimento, this.vSuprimento);
                //data.Add(Nov_Troco, this.vTroco);
                //data.Add(Nov_Recebido, this.vRecebido);
                //data.Add(Nov_Vendido, this.vVendido);
                //data.Add(Nov_Cancelado, this.vCancelado);
                //data.Add(Nov_Desconto, this.vDesconto);
            }
            catch (Exception ex)
            {
                Noticia.Add(ex.Message);
            }
            return data;
        }
        internal void SetToDataValue(decimal _Desconto, decimal _Cancelado, decimal _Cheque, decimal _Credito, decimal _Debito, decimal _Dinheiro, decimal _Interno, decimal _Outro, decimal _Recebido, decimal _Sangria, decimal _Suprimento, decimal _Troco, decimal _ValeAlimentacao, decimal _ValeRefeicao, decimal _Vendido)
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
            this.vDesconto = _Desconto;
            return;
        }

        bool ICaixa_e.Add(IVender_e entidade)
        {
            if (entidade != null)
            {
                if (entidade.Get_Finish_Time == Vender_e._ValuaBaseFinishTime)
                {
                    Noticia.Add("Caixa_e Add IVender_e nao ta finalizado");
                    return false;
                }
                else
                {
                    entidade.Pagarmento(out IPagar_e _E);
                    this.vCheque=decimal.Add(this.vCheque, _E.Cheque);
                    this.vCredito=decimal.Add(this.vCredito, _E.Credito);
                    this.vDebito=decimal.Add(this.vDebito, _E.Debito);
                    this.vDinheiro=decimal.Add(this.vDinheiro, _E.Dinheiro);
                    this.vInterno=decimal.Add(this.vInterno, _E.Interno);
                    this.vOutro=decimal.Add(this.vOutro, _E.Outro);
                    this.vRecebido=decimal.Add(this.vRecebido, _E.Recebido);
                    this.vTroco=decimal.Add(this.vTroco, _E.Troco);
                    this.vValeAlimentacao=decimal.Add(this.vValeAlimentacao, _E.Vale_Alimentacao);
                    this.vValeRefeicao=decimal.Add(this.vValeRefeicao, _E.Vale_Refeicao);
                    this.vDesconto=decimal.Add(this.vDesconto, _E.Desconto);
                    this.vVendido=decimal.Add(this.vVendido, _E.Cobrado);
                    return true;
                }
            }
            else
            {
                Noticia.Add("Caixa_e Add IVender valor Nullo");
                return false;
            }
            //entidade.Pagarmento
            throw new NotImplementedException();
        }

        bool ICaixa_e.Remover(IVender_e vender_)
        {
            if (vender_ != null)
            {
              

            }
            else
            {
                vender_ = null;
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
