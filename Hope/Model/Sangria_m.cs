
using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;

namespace Hope.Controle
{
    internal class Sangria_m : Sangria_c
    {
        public Sangria_m()
        {
            Noticia = new List<string>();
        }

        protected override bool Insert_Data_Value(Dictionary<int, object> keyValuesData)
        {
            if (keyValuesData!= null)
            {
                try
                {
                    HopeDataSet.Caixa_SangriaRow _SangriaRow = Hope.Hope_static.hopeData.Caixa_Sangria.NewCaixa_SangriaRow();
                    _SangriaRow.ID_Caixa = (int)keyValuesData[Sangria_e.Key_CaixaID];
                    _SangriaRow.Colaborador = (string)keyValuesData[Sangria_e.Key_Colacorado];
                    _SangriaRow.Observacao = (string)keyValuesData[Sangria_e.Key_Observacao];
                    _SangriaRow.Valor = (decimal)keyValuesData[Sangria_e.Key_Valor];
                    _SangriaRow.DataRegistro = DateTime.Now;
                    Hope_static.hopeData.Caixa_Sangria.AddCaixa_SangriaRow(_SangriaRow);
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

        protected override bool Select_All_From(out ISangria_e[] sangria_s)
        {
            if (Hope_static.hopeData.Caixa_Sangria.Count!= 0)
            {
                List<ISangria_e> vs = new List<ISangria_e>();
                foreach (HopeDataSet.Caixa_SangriaRow item in Hope_static.hopeData.Caixa_Sangria.Rows)
                {
                    vs.Add
                        (
                            new Sangria_e
                            (
                                index:item.ID_sangria,
                                idCaixa:item.ID_Caixa,
                                colaborador:item.Colaborador,
                                dataregistro:item.DataRegistro,
                                observacao:item.Observacao,
                                valor:item.Valor
                            ) 
                        );
                }
                sangria_s = vs.ToArray();
                return true;
            }
            else
            {
                sangria_s = null;
                Noticia.Add("nao existe registro");
                return false;
            }
        }
    }
}