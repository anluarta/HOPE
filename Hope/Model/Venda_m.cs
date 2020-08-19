using Hope.Controle;
using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hope.Model
{
    internal class Venda_m : Vender_c
    {
        internal Venda_m()
        {
            Noticia = new List<string>();
            Consulta = new Consulta_m._vender();
        }

        protected override bool Deletar_Row(Dictionary<int, object> keyValueData)
        {
            object result = Hope_static.hopeData.Vender.FindByIndex((int)keyValueData[Vender_e.Key_Index]);
            if (result != null)
            {
                HopeDataSet.VenderRow venderRow = (HopeDataSet.VenderRow)result;
                Hope_static.hopeData.Vender.RemoveVenderRow(venderRow);
                if (Hope_static.hopeData.Vender.Contains<HopeDataSet.VenderRow>(venderRow))
                {
                    Noticia.Add("Erro Venda_m Deletar_Row o valor nao foi apagado do registro");
                    return false;
                }
                else
                {
                    Noticia.Add("Venda_m Deletar_Row valor apagado do registro");
                    return true;
                }
            }
            else
            {
                Noticia.Add("Venda_m Deletar_Row valor nullo");
                return false;
            }
        }

        protected override bool Insert_New_Row(string Id_caixa, out Dictionary<int, object> keyValuesData)
        {
            try
            {

                HopeDataSet.VenderRow venderRow = Hope.Hope_static.hopeData.Vender.NewVenderRow();
                //venderRow.Index
                venderRow.ID_Caixa = Id_caixa;
                venderRow.Data_Time_Start = DateTime.Now;
                venderRow.Data_Time_Finish = Vender_e._ValuaBaseFinishTime;
                venderRow.Posicao = Vender_e.ListPosicao.Iniciado.ToString();
                venderRow.Colaborador = Hope.Hope_static.Autenticacao.Colaborador.ToSerilazion();
                venderRow.Item_s = "";
                venderRow.Troco = 0;
                venderRow.Total_Recebido = 0;
                venderRow.Total_Venda = 0;
                venderRow.Desconto = 0;
                venderRow.Pagamento = "";
                Hope_static.hopeData.Vender.AddVenderRow(venderRow);
                venderRow = Hope_static.hopeData.Vender.Rows[Hope_static.hopeData.Vender.Rows.IndexOf(venderRow)] as HopeDataSet.VenderRow;
                keyValuesData = new Dictionary<int, object>();
                keyValuesData.Add(Vender_e.Key_Index, venderRow.Index);
                keyValuesData.Add(Vender_e.Key_ID_Caixa, venderRow.ID_Caixa);
                keyValuesData.Add(Vender_e.Key_Start_Time, venderRow.Data_Time_Start);
                keyValuesData.Add(Vender_e.Key_Finish_Time, venderRow.Data_Time_Finish);
                keyValuesData.Add(Vender_e.Key_Posicao, venderRow.Posicao);
                keyValuesData.Add(Vender_e.Key_Colaborado, venderRow.Colaborador);
                keyValuesData.Add(Vender_e.Key_Item_s, venderRow.Item_s);
                keyValuesData.Add(Vender_e.Key_Troco, venderRow.Troco);
                keyValuesData.Add(Vender_e.Key_Total_Recebido, venderRow.Total_Recebido);
                keyValuesData.Add(Vender_e.Key_Total_Venda, venderRow.Total_Venda);
                keyValuesData.Add(Vender_e.Key_Desconto, venderRow.Desconto);
                keyValuesData.Add(Vender_e.Key_Pagamento, venderRow.Pagamento);
                return true;

            }
            catch (Exception e)
            {
                Noticia.Add(e.Message);
                keyValuesData = null;
                return false;
            }
        }

        protected override bool Select_All_From(out IVender_e[] vender_s)
        {
            if (Hope.Hope_static.hopeData.Vender.Count != 0)
            {
                List<IVender_e> vs = new List<IVender_e>();
                foreach (HopeDataSet.VenderRow item in Hope.Hope_static.hopeData.Vender.Rows)
                {
                    IVender_e vender_E = new Vender_e
                        (
                            index: item.Index,
                            id_caixa: item.ID_Caixa,
                            start_time: item.Data_Time_Start,
                            finish_time: item.Data_Time_Finish,
                            posicao: item.Posicao,
                            colaborador: item.Colaborador,
                            item_s: item.Item_s,
                            troco: item.Troco,
                            recebido: item.Total_Recebido,
                            total_venda: item.Total_Venda,
                            desconto: item.Desconto,
                            pagamento: item.Pagamento
                        );
                    vs.Add(vender_E);
                }
                vender_s = vs.ToArray();
                return true;
            }
            else
            {
                Noticia.Add("Nao existe registro");
                vender_s = null;
                return false;
            }
        }

        protected override bool Update_Row(Dictionary<int, object> keyValueData)
        {
            try
            {
                HopeDataSet.VenderRow venderRow = Hope_static.hopeData.Vender.FindByIndex(int.Parse(keyValueData[Vender_e.Key_Index].ToString()));
                if (venderRow != null)
                {
                    venderRow.Colaborador = keyValueData[Vender_e.Key_Colaborado].ToString();
                    venderRow.Data_Time_Finish = (DateTime)keyValueData[Vender_e.Key_Finish_Time];
                    venderRow.Data_Time_Start = (DateTime)keyValueData[Vender_e.Key_Start_Time];
                    venderRow.Item_s = keyValueData[Vender_e.Key_Item_s].ToString();
                    venderRow.Pagamento = keyValueData[Vender_e.Key_Pagamento].ToString();
                    venderRow.Posicao = keyValueData[Vender_e.Key_Posicao].ToString();
                    venderRow.Desconto = (decimal)keyValueData[Vender_e.Key_Desconto];
                    venderRow.Total_Recebido = (decimal)keyValueData[Vender_e.Key_Total_Recebido];
                    venderRow.Total_Venda = (decimal)keyValueData[Vender_e.Key_Total_Venda];
                    venderRow.Troco = (decimal)keyValueData[Vender_e.Key_Troco];
                    venderRow.AcceptChanges();
                    Hope_static.hopeData.AcceptChanges();
                    return true;
                }
                else
                {
                    Noticia.Add("Erro ao localizar index da venda no dataset");
                    return false;
                }
            }
            catch (Exception e)
            {
                Noticia.Add(e.Message);
                return false;
            }
        }
    }
}