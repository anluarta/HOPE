using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope.Beta
{
    class Caixa_b : Caixa_abs
    {
        public Caixa_b()
        {
            _MeuCaixa = new Beta.Caixa_Ent_b();
            _Recebimento = new Beta.Recebimento_b();
        }
        
        protected override bool novo_Insert_Registro()
        {
            teste();
            Hope_c.caixa.teste();
            teste
            HopeDataSet.CaixaRow row = Hope_c.localSet.Caixa.NewCaixaRow();
            row.ID_Colaborador = Hope_c.colaborador._Logado._ID_Colaborador;
            row.Dia_Hora_Abertura = DateTime.Now.ToString();
            Hope_c.localSet.Caixa.Rows.Add(row);
            row = Hope_c.localSet.Caixa.Rows[Hope_c.localSet.Caixa.Count - 1] as HopeDataSet.CaixaRow;
            _MeuCaixa = new Caixa_Ent_b()
            {
                _ID_Caixa = row.ID_Caixa,
                _ID_Colaborador = row.ID_Colaborador,
                _Abertura = row.Dia_Hora_Abertura

            };
            CaixaAberto = true;
            Hope_c.caixa.SituacaoCaixa = ListEnum.TipoSituacaoCaixa.Aberto;
            return true;
            throw new NotImplementedException();
        }

        protected override bool meucaixaaberto()
        {
            try
            {
                if (Hope_c.localSet.Caixa.Count != 0)
                {
                    foreach (HopeDataSet.CaixaRow item in Hope_c.localSet.Caixa.Rows)
                    {
                        if (item.ID_Colaborador == Hope_c.colaborador._Logado._ID_Colaborador)
                        {
                            if (item.Dia_Hora_Fechamento.Length < 4)
                            {
                                if (DateTime.TryParse(item.Dia_Hora_Fechamento, out DateTime fecha))
                                {
                                    break;
                                }
                                if (DateTime.TryParse(item.Dia_Hora_Abertura, out DateTime date))
                                {
                                    if (date < DateTime.Now.Subtract(new TimeSpan(11, 59, 59)))
                                    {
                                        Hope_c.caixa.SituacaoCaixa = ListEnum.TipoSituacaoCaixa.FaltaFechar;
                                    }
                                    else
                                    {
                                        Hope_c.caixa.SituacaoCaixa = ListEnum.TipoSituacaoCaixa.Aberto;
                                    }
                                }
                                Hope_c.caixa._MeuCaixa._ID_Caixa = item.ID_Caixa;
                                Hope_c.caixa._MeuCaixa._ID_Colaborador = item.ID_Colaborador;
                                Hope_c.caixa._MeuCaixa._Abertura = item.Dia_Hora_Abertura;
                                Hope_c.caixa._MeuCaixa._Fechamento = item.Dia_Hora_Fechamento;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Cancelado = item.Cancelado_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cheque = item.Cheque_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Credito = item.Credito_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Debito = item.Debito_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Desconto = item.Desconto_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Dinheiro = item.Dinheiro_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Interno = item.Interno_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Outro = item.Outro_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Recebimento = item.Recebimento_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Reforco = item.Reforco_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Sangria = item.Sangria_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Troco = item.Troco_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Alimentacao = item.Vale_Alimentacao_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Refeicao = item.Vale_Refeicao_Total;
                                Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Vendido = item.Venda_Total;
                                CaixaAberto = true;
                                return true;
                            }
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro na consulta lista meu caixa aberto" + e.Message);
            }
        }

        protected override bool fechar_Update_Registro()
        {
            if (Hope_c.localSet.Caixa.Count != 0)
            {
                foreach (HopeDataSet.CaixaRow item in Hope_c.localSet.Caixa.Select("ID_Caixa=" + Hope_c.caixa._MeuCaixa._ID_Caixa.ToString()))
                {
                    item.Dia_Hora_Fechamento = DateTime.Now.ToString();

                    item.Debito_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Debito;
                    item.Cancelado_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Cancelado;
                    item.Cheque_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cheque;
                    item.Credito_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Credito;
                    item.Dinheiro_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Dinheiro;
                    item.Interno_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Interno;
                    item.Outro_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Outro;
                    item.Recebimento_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Recebimento;
                    item.Vale_Alimentacao_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Alimentacao;
                    item.Vale_Refeicao_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Refeicao;
                    item.Venda_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Vendido;
                    item.Desconto_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Desconto;
                    item.Troco_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Troco;
                    Hope_c.localSet.AcceptChanges();
                    CaixaAberto = false;
                    return true;
                }
                Hope_c.informacao.Add("000", "Nao existe linha para ser alterado");

                return false;
            }
            else
            {
                Hope_c.informacao.Add("000", "Nao existe Linha registro no CAixa");
                return false;
            }
            throw new NotImplementedException();
        }

        protected override bool Reforco_Insert_Registrp(decimal valor, string observacao)
        {
            try
            {
                HopeDataSet.Caixa_ReforcoRow row = Hope_c.localSet.Caixa_Reforco.NewCaixa_ReforcoRow();
                row.ID_Caixa = Hope_c.caixa._MeuCaixa._ID_Caixa;
                row.ID_Colaborador = Hope_c.colaborador._Logado._ID_Colaborador;
                row.Data = DateTime.Now.ToString();
                row.Valor = valor;
                row.Observacao = observacao;
                Hope_c.localSet.Caixa_Reforco.Rows.Add(row);
                Hope_c.informacao.Add("000", "Registro salvo");
                total_update_Registro();
                return true;
            }
            catch (Exception e)
            {
                Hope_c.informacao.Add("000", e.Message);
                return false;
            }
        }

        protected override bool Sangria_Insert_Registrp(decimal valor, string observacao)
        {
            try
            {
                HopeDataSet.Caixa_SangriaRow row = Hope_c.localSet.Caixa_Sangria.NewCaixa_SangriaRow();
                row.ID_Caixa = Hope_c.caixa._MeuCaixa._ID_Caixa;
                row.ID_Colaborador = Hope_c.colaborador._Logado._ID_Colaborador;
                row.Data = DateTime.Now.ToString();
                row.Valor = valor;
                row.Observacao = observacao;
                Hope_c.localSet.Caixa_Sangria.Rows.Add(row);
                Hope_c.informacao.Add("000", "Registro salvo");
                total_update_Registro();
                return true;
            }
            catch (Exception e)
            {
                Hope_c.informacao.Add("000", e.Message);
                return false;
            }
        }

        protected override bool total_update_Registro()
        {
            foreach (HopeDataSet.CaixaRow item in Hope_c.localSet.Caixa.Select("ID_Caixa=" + Hope_c.caixa._MeuCaixa._ID_Caixa.ToString()))
            {
                item.Debito_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Debito;
                item.Cancelado_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Cancelado;
                item.Cheque_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cheque;
                item.Credito_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Credito;
                item.Dinheiro_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Dinheiro;
                item.Interno_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Interno;
                item.Outro_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Outro;
                item.Recebimento_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Recebimento;
                item.Vale_Alimentacao_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Alimentacao;
                item.Vale_Refeicao_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Refeicao;
                item.Venda_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Vendido;
                item.Desconto_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Desconto;
                item.Troco_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Troco;
                item.Reforco_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Reforco;
                item.Sangria_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Sangria;
                Hope_c.localSet.AcceptChanges();
                return true;
            }
            throw new NotImplementedException();
        }

        protected override bool select_all_from(out Entidade.ICaixa_Ent_c[] listaRegistro)
        {
            if (Hope_c.localSet.Caixa.Count != 0)
            {
                List<Entidade.ICaixa_Ent_c> li = new List<Entidade.ICaixa_Ent_c>();
                foreach (HopeDataSet.CaixaRow item in Hope_c.localSet.Caixa.Rows)
                {
                    li.Add(
                        new Caixa_Ent_b(
                           idcaixa: item.ID_Caixa,
                           idcolaborador: item.ID_Colaborador,
                           aberto: item.Dia_Hora_Abertura,
                           fechado: item.Dia_Hora_Fechamento,
                           totais: new CaixaTotal_Ent_b(
                                        debito: item.Debito_Total,
                                        cancelado: item.Cancelado_Total,
                                        cheque: item.Cheque_Total,
                                        credito: item.Credito_Total,
                                        dinheiro: item.Dinheiro_Total,
                                        interno: item.Interno_Total,
                                        outro: item.Outro_Total,
                                        recebimento: item.Recebimento_Total,
                                        valealimentacao: item.Vale_Alimentacao_Total,
                                        valerefeicao: item.Vale_Refeicao_Total,
                                        vendido: item.Venda_Total,
                                        desconto: item.Desconto_Total,
                                        troco: item.Troco_Total,
                                        reforco:item.Reforco_Total,
                                        sangria:item.Sangria_Total)
                           )
                        );
                }
                listaRegistro = li.ToArray();
                return true;
            }
            else
            {
                listaRegistro = new Entidade.ICaixa_Ent_c[0];
                return false;
            }
            throw new NotImplementedException();
        }

        protected override bool logouf_update_registro()
        {
            try
            {
                if (Hope_c.localSet.Caixa.Count != 0)
                {
                    foreach (HopeDataSet.CaixaRow item in Hope_c.localSet.Caixa.Rows)
                    {
                        if (item.ID_Caixa == Hope_c.caixa._MeuCaixa._ID_Caixa)
                        {
                            item.ID_Caixa = Hope_c.caixa._MeuCaixa._ID_Caixa;
                            item.ID_Colaborador = Hope_c.caixa._MeuCaixa._ID_Colaborador;
                            item.Dia_Hora_Abertura = Hope_c.caixa._MeuCaixa._Abertura;
                            item.Dia_Hora_Fechamento = Hope_c.caixa._MeuCaixa._Fechamento;
                            item.Cancelado_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Cancelado;
                            item.Cheque_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cheque;
                            item.Credito_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Credito;
                            item.Debito_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Debito;
                            item.Desconto_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Desconto;
                            item.Dinheiro_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Dinheiro;
                            item.Interno_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Interno;
                            item.Outro_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Outro;
                            item.Recebimento_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Recebimento;
                            item.Reforco_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Reforco;
                            item.Sangria_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Sangria;
                            item.Troco_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Troco;
                            item.Vale_Alimentacao_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Alimentacao;
                            item.Vale_Refeicao_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Vale_Refeicao;
                            item.Venda_Total = Hope_c.caixa._MeuCaixa.total_Ent_Abs._Cupom_Vendido;
                            Hope_c.localSet.AcceptChanges();
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Erro na logouf_update_registro" + e.Message);
            }
        }
    }
}
