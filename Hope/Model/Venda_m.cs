using Hope.Controle;
using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;

namespace Hope.Model
{
    internal class Venda_m : Vender_c
    {
        private Venda_m()
        {
            Noticia = new List<string>();
            Consulta = new Consulta_m._vender();
        }

        protected override bool Insert_New_Row(string Id_caixa,out Dictionary<int,object> keyValuesData)
        {
            try
            {
                HopeDataSet.VenderRow venderRow = Hope.Hope_static.hopeData.Vender.NewVenderRow();
                venderRow.Colaborador = Hope.Hope_static.Autenticacao.Colaborador.ToSerilazion();
                venderRow.Data_Hora_Abertura = DateTime.Now;
                venderRow.Data_Hora_Fechamento = Vender_e._ValuaBaseFinishTime;
                venderRow.ID_Caixa =Id_caixa;
                venderRow.Posicao =Vender_e.Posicao.Iniciado;
                Hope_static.hopeData.Vender.AddVenderRow(venderRow);
                venderRow = Hope_static.hopeData.Vender.Rows[Hope_static.hopeData.Vender.Rows.IndexOf(venderRow)] as HopeDataSet.VenderRow;
                keyValuesData = new Dictionary<int, object>();
                keyValuesData.Add(Vender_e.Key_Index, venderRow.ID_Vender);
                keyValuesData.Add(Vender_e.Key_Index, venderRow.ID_Caixa);
                keyValuesData.Add(Vender_e.Key_Index, venderRow.Posicao);
                keyValuesData.Add(Vender_e.Key_Index, venderRow.Colaborador);
                keyValuesData.Add(Vender_e.Key_Index, venderRow.Comprador);

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

        protected override bool Update_Row(Dictionary<string, object> keyValueData)
        {
            throw new NotImplementedException();
        }
    }
}