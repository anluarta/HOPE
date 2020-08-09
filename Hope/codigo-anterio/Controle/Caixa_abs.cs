using Hope.Beta;
using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope.Controle
{
    abstract class Caixa_abs : ICaixa_c
    {
        internal ListEnum.TipoSituacaoCaixa SituacaoCaixa = ListEnum.TipoSituacaoCaixa.Nulo;
        internal Recebimento_abs _Recebimento;
        internal Caixa_Ent_abs _MeuCaixa;
        protected bool CaixaAberto = false;
        protected abstract bool logouf_update_registro();
        protected abstract bool novo_Insert_Registro();
        protected abstract bool total_update_Registro();
        protected abstract bool fechar_Update_Registro();
        protected abstract bool select_all_from(out Entidade.ICaixa_Ent_c[] listaRegistro);
        protected abstract bool meucaixaaberto();
        private protected void teste() { }
        protected void teste2() { }
        protected internal void teste3() { }
        internal void teste4() { }
        private void teste5() { }
        protected abstract bool Reforco_Insert_Registrp(decimal valor, string observacao);
        protected abstract bool Sangria_Insert_Registrp(decimal valor, string observacao);
        internal bool reforco(decimal valor, string observacao)
        {
            
            _MeuCaixa.total_Ent_Abs._Reforco += valor;
            return Reforco_Insert_Registrp(valor, observacao);
        }
        internal bool sangria(decimal valor, string observacao)
        {
            _MeuCaixa.total_Ent_Abs._Sangria += valor;
            return Sangria_Insert_Registrp(valor, observacao);
        }
        internal bool iniciarmeucaixa()
        {
            SituacaoCaixa = ListEnum.TipoSituacaoCaixa.Nulo;
            _MeuCaixa.Clea();

            if (meucaixaaberto())
            {
                switch (SituacaoCaixa)
                {
                    case ListEnum.TipoSituacaoCaixa.Nulo:
                        return false;
                    case ListEnum.TipoSituacaoCaixa.Aberto:
                        Hope_c.informacao.Add("000", "Caixa ja aberto");
                        return true;
                    case ListEnum.TipoSituacaoCaixa.FaltaFechar:
                        Hope_c.informacao.Add("000", "Caixa com fechamento pedente");
                        return false;
                    default:
                        Hope_c.informacao.Add("000", "erro na situacao caixa");
                        return false;
                }
            }
            else if (novo_Insert_Registro())
            {
                Hope_c.informacao.Add("000", "CAixa iniciado");
                return true;
            }
            else
            {
                Hope_c.informacao.Add("000", "Erro inicarmeucaixa inserRegistro");
                return false;
            }
        }
        internal bool fecharmeucaixa()
        {

            if (fechar_Update_Registro())
            {
                _MeuCaixa.Clea();
                SituacaoCaixa = ListEnum.TipoSituacaoCaixa.Nulo;
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void Logouf()
        {
            if (SituacaoCaixa == ListEnum.TipoSituacaoCaixa.Aberto)
            {
                if (logouf_update_registro())
                {
                    SituacaoCaixa = ListEnum.TipoSituacaoCaixa.Nulo;
                    CaixaAberto = false;
                    _MeuCaixa.Clea();
                }
                else
                {
                    Hope_c.informacao.Add("000", "Erro ao gravar dados de saido do colaborado no logouf");
                    throw new Exception("CAIXA_ABS_LOUF 94l");
                }
            }
        }
        internal bool pagamento()
        {

            _MeuCaixa.total_Ent_Abs._Cupom_Vendido = decimal.Add(_MeuCaixa.total_Ent_Abs._Cupom_Vendido, Hope_c.vender._Pagar._NovoRegistro._Cobrado);
            _MeuCaixa.total_Ent_Abs._Recebimento = decimal.Add(_MeuCaixa.total_Ent_Abs._Recebimento, Hope_c.vender._Pagar._NovoRegistro._Recebido);
            _MeuCaixa.total_Ent_Abs._Cheque = decimal.Add(_MeuCaixa.total_Ent_Abs._Cheque, Hope_c.vender._Pagar._NovoRegistro._Cheque);
            _MeuCaixa.total_Ent_Abs._Credito = decimal.Add(_MeuCaixa.total_Ent_Abs._Credito, Hope_c.vender._Pagar._NovoRegistro._Credito);
            _MeuCaixa.total_Ent_Abs._Debito = decimal.Add(_MeuCaixa.total_Ent_Abs._Debito, Hope_c.vender._Pagar._NovoRegistro._Debito);
            _MeuCaixa.total_Ent_Abs._Dinheiro = decimal.Add(_MeuCaixa.total_Ent_Abs._Dinheiro, Hope_c.vender._Pagar._NovoRegistro._Dinheiro);
            _MeuCaixa.total_Ent_Abs._Interno = decimal.Add(_MeuCaixa.total_Ent_Abs._Interno, Hope_c.vender._Pagar._NovoRegistro._Interno);
            _MeuCaixa.total_Ent_Abs._Outro = decimal.Add(_MeuCaixa.total_Ent_Abs._Outro, Hope_c.vender._Pagar._NovoRegistro._Outro);
            _MeuCaixa.total_Ent_Abs._Vale_Alimentacao = decimal.Add(_MeuCaixa.total_Ent_Abs._Vale_Alimentacao, Hope_c.vender._Pagar._NovoRegistro._Vale_Alimentacao);
            _MeuCaixa.total_Ent_Abs._Vale_Refeicao = decimal.Add(_MeuCaixa.total_Ent_Abs._Vale_Refeicao, Hope_c.vender._Pagar._NovoRegistro._Vale_Refeicao);
            _MeuCaixa.total_Ent_Abs._Desconto = decimal.Add(_MeuCaixa.total_Ent_Abs._Desconto, Hope_c.vender._Pagar._NovoRegistro._Desconto);
            _MeuCaixa.total_Ent_Abs._Troco = decimal.Add(_MeuCaixa.total_Ent_Abs._Troco, Hope_c.vender._Pagar._NovoRegistro._Troco);
            return total_update_Registro();
        }
        IRecebimento_c Contrato.ICaixa_c.Recebimento { get => _Recebimento; }

        string Contrato.ICaixa_c.Reforco_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Reforco.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Sangria_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Sangria.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Dinheiro_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Dinheiro.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Debido_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Debito.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Credito_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Credito.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Cheque_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Cheque.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Vale_Alimentacao_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Vale_Alimentacao.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Vale_Refeicao_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Vale_Refeicao.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Outro_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Outro.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }
        string Contrato.ICaixa_c.Interno_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Interno.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        string Contrato.ICaixa_c.Recebimento_Total { get { if (CaixaAberto) { return _MeuCaixa.total_Ent_Abs._Recebimento.ToString("f3", CultureInfo.CurrentCulture); } else { return ""; } } }

        IInformacao_c ICaixa_c.Informacao => Hope_c.informacao;

        public bool DetalheValorTotalRegistro(object Current, out ICaixaTotal_Ent_c totais)
        {
            Caixa_Ent_abs c = Current as Caixa_Ent_abs;
            totais = c.total_Ent_Abs;
            //CaixaTotal_Ent_abs v = new CaixaTotal_Ent_b();
            //v._Cheque = 0;
            //v._Credito = 0;
            //v._Cupom_Cancelado = 0;
            //v._Cupom_Vendido = 0;
            //v._Debito = 0;
            //v._Dinheiro = 0;
            //v._Interno = 0;
            //v._Outro = 0;
            //v._Recebimento = 0;
            //v._Reforco = 0;
            //v._Sangria = 0;
            //v._Vale_Alimentacao = 0;
            //v._Vale_Refeicao = 0;
            //totais = v;
            return true;
        }

        bool ICaixa_c.EncerrarMeuCaixa()
        {
            if (Hope_c.colaborador.Autenticado)
            {
                return fecharmeucaixa();
            }
            else
            {
                Hope_c.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.IniciarMeuCaixa()
        {
            if (Hope_c.colaborador.Autenticado)
            {

                return iniciarmeucaixa();
            }
            else
            {
                Hope_c.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
        }

        bool ICaixa_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out ICaixa_Ent_c[] ListaResultado)
        {
            if (Comando.Contains(ListEnum.ComandoConsulta.Selec_All_From.ToString()))
            {
                return select_all_from(out ListaResultado);
            }
            else
            {
                ListaResultado = new ICaixa_Ent_c[0];
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.Reforco(decimal _Valor, string _Observacao)
        {
            if (Hope_c.colaborador.Autenticado)
            {
                if (SituacaoCaixa == ListEnum.TipoSituacaoCaixa.Aberto)
                {

                    return reforco(_Valor, _Observacao);
                }
                else
                {
                    Hope_c.informacao.Add("000", "Seu caixa nao ta aberto");

                    return false;
                }
            }
            else
            {
                Hope_c.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.Sangria(decimal _Valor, string _Observacao)
        {
            if (Hope_c.colaborador.Autenticado)
            {
                if (SituacaoCaixa == ListEnum.TipoSituacaoCaixa.Aberto)
                {
                    return sangria(_Valor, _Observacao);
                }
                else
                {
                    Hope_c.informacao.Add("000", "Seu caixa nao ta aberto");

                    return false;
                }
            }
            else
            {
                Hope_c.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.Situacao()
        {
            throw new NotImplementedException();
        }
    }
}
