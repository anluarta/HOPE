using Hope.Controle;
using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;

namespace Hope.Model
{
    internal class Venda_m : Vender_c
    {
        internal Venda_m()
        {
            Noticia = new List<string>();
            Consulta = new Consulta_m._vender();
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
            throw new NotImplementedException();
        }

        protected override bool Update_Row(Dictionary<int, object> keyValueData)
        {
            throw new NotImplementedException();
        }
    }
}