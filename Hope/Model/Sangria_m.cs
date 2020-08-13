
using Hope.Entidade;
using System;
using System.Collections.Generic;

namespace Hope.Controle
{
    internal class Sangria_m : Sangria_c
    {
        public Sangria_m()
        {
            Noticia = new System.Collections.Generic.List<string>();
        }

        protected override bool Insert_Data_Value(Dictionary<string, object> keyValuesData)
        {
            if (keyValuesData!= null)
            {
                try
                {
                    HopeDataSet.Caixa_SangriaRow _SangriaRow = Hope.Hope_static.hopeData.Caixa_Sangria.NewCaixa_SangriaRow();
                    _SangriaRow.ID_Caixa = (int)keyValuesData[Sangria_e.Key_CaixaID];
                    _SangriaRow.ID_Colaborador = int.Parse(keyValuesData[Sangria_e.Key_ColacoradoID].ToString());
                    _SangriaRow.Observacao = (string)keyValuesData[Sangria_e.Key_Observacao];
                    _SangriaRow.Valor = (decimal)keyValuesData[Sangria_e.Key_Valor];
                    _SangriaRow.DataRegistro = DateTime.Now;
                    Hope.Hope_static.hopeData.Caixa_Sangria.AddCaixa_SangriaRow(_SangriaRow);
                    Noticia.Add("registro salvo");
                    return true;
                }
                catch (System.Exception e)
                {
                    Noticia.Add(e.Message);
                    return false;
                }
            }
            else
            {
                Noticia.Add("KeyValuesData esta nullo");
                return false;
            }
        }
    }
}