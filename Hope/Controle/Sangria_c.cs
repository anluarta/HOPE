using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace Hope.Controle
{
    internal abstract class Sangria_c : ISangria
    {
        Consulta_c Consulta;
        internal List<string> Noticia;
        bool ISangria.Consulta(out IConsulta consulta)
        {
            if (Hope_static.Autenticacao.Autenticado)
            {
                consulta = this.Consulta;
                return true;
            }
            else
            {
                Noticia.Add("noao esta logado");
                consulta = null;
                return false;
            }
        }
        protected abstract bool Insert_Data_Value(Dictionary<int, object> keyValuesData);
        protected abstract bool Select_All_From(out ISangria_e[] sangria_s);
        internal bool Gravar(List<Sangria_e> sangria_s)
        {
            if (sangria_s != null)
            {
                if (sangria_s.Count != 0)
                {
                    List<bool> vs = new List<bool>();
                    foreach (Sangria_e item in sangria_s)
                    {
                        vs.Add(Insert_Data_Value(item.GetKeyValuesData()));
                    }
                    if (vs.Find(x => x == true))
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;

            }
        }

        bool ISangria.Find(IConsulta consulta, out ISangria_e[] sangria_s)
        {
            if (consulta != null)
            {
                switch (consulta.Comando)
                {
                    case Enums.Consulta_u.Comando.Select_All_From:
                        if (Select_All_From(out sangria_s))
                        {
                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    default:
                        sangria_s = null;
                        Noticia.Add("Sangria_c find valor consulta comando nao existe");
                        return false;
                }
            }
            else
            {
                sangria_s = null;
                Noticia.Add("Sangria_c find valor consulta nullo");
                return false;
            }
        }

        bool ISangria.Select(object current, out ISangria_e sangria_)
        {
            if (current != null)
            {
                if (current is ISangria_e)
                {
                    sangria_ = (ISangria_e)current;
                    return true;
                }
                else
                {
                    sangria_ = null;
                    Noticia.Add("Sangria_c Select Current valor nao e ISangria_e");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Sangria_c select current valor nullo");
                sangria_ = null;
                return false;
            }
        }
        Font Bold;
        ISangria_e _E;
        bool ISangria.Print_Document(ISangria_e sangria_, PrintDocument document)
        {
            if (sangria_ != null)
            {
                _E = sangria_;
                document = new PrintDocument();
                PageSettings settings = new PageSettings();
                Graphics graphics = document.PrinterSettings.CreateMeasurementGraphics();

                settings.PaperSize = CalcArePrint(graphics: ref graphics);
                document.DefaultPageSettings = settings;

                document.PrintPage += new PrintPageEventHandler(Sangria_PrintPage);
                return true;
            }
            else
            {
                document = null;
                Noticia.Add("Erro Sangria_c Print_Document valor sangria_ nullo");
                return false;
            }
        }
      
        private void Sangria_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            CalcArePrint(ref graphics);
        }
        private PaperSize CalcArePrint(ref Graphics graphics)
        {
            Bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            //print header
            graphics.DrawString("Sangria", Bold, Brushes.Black, 80, 5);
            graphics.DrawString("Data: " + _E.Data_Registro, Bold, Brushes.Black, 20, 45);
            graphics.DrawString("Valor: " + _E.Valor, Bold, Brushes.Black, 20, 65);
            graphics.DrawLine(Pens.Black, 10, 95, 250, 95);
            graphics.DrawString("Asinatura", Bold, Brushes.Black, 80, 125);
            graphics.DrawString(_E.Observacao, Bold, Brushes.Black, 10, 200);
            return new PaperSize("Custom", (int)graphics.VisibleClipBounds.Width / 5, (int)graphics.VisibleClipBounds.Height / 5);

        }
    }
}