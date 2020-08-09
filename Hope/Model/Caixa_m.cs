using Hope.Controle;
using System;
using System.Windows.Forms;

namespace Hope.Model
{
    class Caixa_m : Caixa_c
    {
        public Caixa_m()
        {
            _Consulta = new Model.Consulta_m._caixa();
            Noticia = new System.Collections.Generic.List<string>();
        }

        protected override bool Insert_New_Row(out int Index, out DateTime start)
        {
            try
            {
                HopeDataSet.CaixaRow row = Hope_static.hopeData.Caixa.NewCaixaRow();
                row.ID_Colaborador = Hope.Hope_static.Autenticacao.Colaborador.ID;
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
    }
}