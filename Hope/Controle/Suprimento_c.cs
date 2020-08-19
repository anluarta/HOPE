using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace Hope.Controle
{
    internal abstract class Suprimento_c : ISuprimento
    {
        Consulta_c Consulta;
        internal List<string> Noticia;
        IConsulta ISuprimento.Consulta() { return Consulta; }

        protected abstract bool Insert_Data_Value(Dictionary<int, object> keyValuesData);
        internal bool Gravar(List<ISuprimento_e> suprimento_s)
        {
            if (suprimento_s != null)
            {
                if (suprimento_s.Count != 0)
                {
                    List<bool> vs = new List<bool>();
                    foreach (Suprimento_e item in suprimento_s)
                    {
                        vs.Add(Insert_Data_Value(item.GetKeysValueData()));
                    }
                    if (vs.Find(x => x == true))
                    {
                        Noticia.Add(Msg005);

                        return true;
                    }
                    else
                    {
                        Noticia.Add(Msg004);

                        return false;
                    }
                }
                else
                {
                    Noticia.Add(Msg003);

                    return false;
                }
            }
            else
            {
                Noticia.Add(Msg002);
                return false;
            }
        }

        bool ISuprimento.Find(IConsulta consulta, out ISuprimento_e[] suprimento_s)
        {
            throw new NotImplementedException();
        }

        bool ISuprimento.Select(object current, out ISuprimento_e suprimento_)
        {
            throw new NotImplementedException();
        }
       
        private void PrintPage_Suprimento(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            CalcArePrint(ref graphics);
        }
        Font Bold;
        ISuprimento_e _E;
        bool ISuprimento.Print_Document(ISuprimento_e suprimento_, out PrintDocument document)
        {
            if (suprimento_ != null)
            {
                _E = suprimento_;
                document = new PrintDocument();
                PageSettings settings = new PageSettings();
                Graphics graphics = document.PrinterSettings.CreateMeasurementGraphics();

                settings.PaperSize = CalcArePrint(graphics: ref graphics);
                document.DefaultPageSettings = settings;

                document.PrintPage += new PrintPageEventHandler(PrintPage_Suprimento);
                return true;
            }
            else
            {
                document = null;
                Noticia.Add("Erro Suprimento_c Print_Document valor suprimento_ nullo");
                return false;
            }
        }

        private PaperSize CalcArePrint(ref Graphics graphics)
        {
            Bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            //print header
            graphics.DrawString("Suprimento", Bold, Brushes.Black, 80, 5);
            graphics.DrawString("Data: " +_E.Data_Registro , Bold, Brushes.Black, 20, 45);
            graphics.DrawString("Valor: " + _E.Valor, Bold, Brushes.Black, 20, 65);
            graphics.DrawLine(Pens.Black, 10, 95, 250, 95);
            graphics.DrawString("Asinatura", Bold, Brushes.Black, 80, 125);
            return new PaperSize("Custom", (int)graphics.VisibleClipBounds.Width / 5, (int)graphics.VisibleClipBounds.Height / 5);

        }
        const string Msg001 = "Suprimento_c Msg-001:";
        const string Msg002 = "Suprimento_c Gravar Msg-002:Erro valor list suprimento_s nullo";
        const string Msg003 = "Suprimento_c Gravar Msg-003:Aviso valor list suprimento_s cont 0";
        const string Msg004 = "Suprimento_c Gravar Msg-004:Erro predicado retonou false";
        const string Msg005 = "Suprimento_c Gravar Msg-005:Aviso predicado retonou true";
       protected const string Msg006 = "Suprimento_c Insert_data_row Msg-006:Erro valor nullo Dicionary ";
       protected const string Msg007 = "Suprimento_c Insert_data_row Msg-006:Aviso Registro Gravado {0},{1}";
    }
}