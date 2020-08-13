using Hope.Controle;
using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hope.Model
{
    class Caixa_m : Caixa_c
    {
        public Caixa_m()
        {
            _Consulta = new Consulta_m._caixa();
            Noticia = new List<string>();
            _Suprimento = new Suprimento_m();
            _Sangria = new Sangria_m();
        }

        protected override bool Insert_New_Row(out int Index, out DateTime start)
        {
            try
            {
                HopeDataSet.CaixaRow row = Hope_static.hopeData.Caixa.NewCaixaRow();
                row.Colaborador = Hope_static.Autenticacao.Colaborador.ToSerilazion();
                row.Dia_Hora_Abertura = DateTime.Now;
                Hope_static.hopeData.Caixa.AddCaixaRow(row);
                row = Hope_static.hopeData.Caixa.Rows[Hope_static.hopeData.Caixa.Rows.IndexOf(row)] as HopeDataSet.CaixaRow;
                Index = row.ID_Caixa;
                start = row.Dia_Hora_Abertura;
                Noticia.Add("Caixa novo Susceso");
                return true;
            }
            catch (Exception e)
            {
                Noticia.Add("Erro Insert_New_Row");
                Noticia.Add(e.Message);
                Index = 0;
                start = DateTime.Parse("01/01/01 23:59:59");
                return false;

            }
        }

        protected override bool Select_All_From(out ICaixa_e[] caixa_s)
        {
            if (Hope.Hope_static.hopeData.Caixa.Count != 0)
            {
                List<ICaixa_e> vs = new List<ICaixa_e>();
                foreach (HopeDataSet.CaixaRow item in Hope.Hope_static.hopeData.Caixa.Rows)
                {
                    // busca o colaborado na base de dados
                    IColaborador_e _E= new Colaborador_e(item.Colaborador);
                   
                    // adiciona a linha de registro ja no formato pra exibicao
                    vs.Add
                        (
                        new Entidade.Caixa_e
                        (
                            Index: item.ID_Caixa,
                            colaborador: _E,
                            start: item.Dia_Hora_Abertura,
                            finish: item.Dia_Hora_Fechamento,
                            _Dinheiro: item.Dinheiro_Total,
                            _Debito: item.Debito_Total,
                            _Credito: item.Credito_Total,
                            _Cheque: item.Cheque_Total,
                            _ValeAlimentacao: item.Vale_Alimentacao_Total,
                            _ValeRefeicao: item.Vale_Refeicao_Total,
                            _Outro: item.Outro_Total,
                            _Interno: item.Interno_Total,
                            _Sangria: item.Sangria_Total,
                            _Suprimento: item.Suprimento_Total,
                            _Troco: item.Troco_Total,
                            _Recebido: item.Recebimento_Total,
                            _Vendido: item.Venda_Total,
                            _Cancelado: item.Cancelado_Total,
                            _Desconto: item.Desconto_Total
                        )
                        );
                }
                caixa_s = vs.ToArray();
                return true;
            }
            else
            {
                Noticia.Add("Nao existe registro");
                caixa_s = null;
                return false;
            }
        }

        protected override bool Update_Row(Dictionary<string, string> keyValueData)
        {
            string filter = string.Format("ID_Caixa={0}", keyValueData[Caixa_e.Index]);
            object oRow = Hope_static.hopeData.Caixa.Select(filter)[0];
            if (oRow != null)
            {
                HopeDataSet.CaixaRow caixaRow = oRow as HopeDataSet.CaixaRow;
                if (caixaRow.ID_Caixa == int.Parse(keyValueData[Caixa_e.Index]))
                {
                    caixaRow.BeginEdit();
                    caixaRow.Dia_Hora_Fechamento = DateTime.Parse(keyValueData[Caixa_e.Nov_FinishTime], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Cancelado_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Cancelado], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Cheque_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Cheque], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Credito_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Credito], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Debito_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Debido], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Desconto_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Desconto], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Dinheiro_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Dinheiro], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Interno_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Internal], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Outro_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Outro], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Recebimento_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Recebido], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Suprimento_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Suprimento], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Sangria_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Sangria], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Troco_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Troco], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Vale_Alimentacao_Total = decimal.Parse(keyValueData[Caixa_e.Nov_ValeAlimentacao], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Vale_Refeicao_Total = decimal.Parse(keyValueData[Caixa_e.Nov_ValeRefeica], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.Venda_Total = decimal.Parse(keyValueData[Caixa_e.Nov_Vendido], System.Globalization.CultureInfo.InvariantCulture);
                    caixaRow.EndEdit();
                    caixaRow.AcceptChanges();
                    return true;
                }
                else
                {
                    Noticia.Add("caixaRow Index nao e igual");
                    return false;
                }
                //Ant_FinishTime
                //Ant_Dinheiro
                //Ant_Debido
                //Ant_Credito
                //Ant_Cheque
                //Ant_ValeAlimentacao
                //Ant_ValeRefeica
                //Ant_Outro
                //Ant_Internal
                //Ant_Sangria
                //Ant_Suprimento
                //Ant_Troco
                //Ant_Recebido
                //Ant_Vendido
                //Ant_Cancelado
                //Nov_FinishTime
                //Nov_Dinheiro
                //Nov_Debido
                //Nov_Credito
                //Nov_Cheque
                //Nov_ValeAlimentacao
                //Nov_ValeRefeica
                //Nov_Outro
                //Nov_Internal
                //Nov_Sangria
                //Nov_Suprimento
                //Nov_Troco
                //Nov_Recebido
                //Nov_Vendido
                //Nov_Cancelado

            }
            else
            {
                Noticia.Add("oRow valor nullo");
                return false;
            }
        }
    }
}