using Hope.Controle;
using Hope.Entidade;
using System;
using System.Collections.Generic;

namespace Hope.Model
{
    internal class Suprimento_m : Suprimento_c
    {
        public Suprimento_m()
        {
            Noticia = new List<string>();
        }
        protected override bool Insert_Data_Value(Dictionary<int, object> keyValuesData)
        {
            if (keyValuesData!=null)
            {
                try
                {
                    HopeDataSet.Caixa_SuprimentoRow _SuprimentoRow = Hope.Hope_static.hopeData.Caixa_Suprimento.NewCaixa_SuprimentoRow();
                    _SuprimentoRow.ID_Caixa = (int)keyValuesData[Suprimento_e.Key_CaixaID];
                    _SuprimentoRow.Colaborador = (string)keyValuesData[Suprimento_e.Key_Colaborado];
                    _SuprimentoRow.Valor = (decimal)keyValuesData[Suprimento_e.Key_Valor];
                    _SuprimentoRow.Observacao = (string)keyValuesData[Suprimento_e.Key_Observacao];
                    _SuprimentoRow.DataRegistro = DateTime.Now;
                    Hope.Hope_static.hopeData.Caixa_Suprimento.AddCaixa_SuprimentoRow(_SuprimentoRow);
                    Noticia.Add("Registro salvo");
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
                Noticia.Add("KeyValuesData valor nulo");
                return false;
            }
        }
    }
}