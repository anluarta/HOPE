using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace Hope.Controle
{
    internal abstract class Sangria_c : ISangria
    {
        internal List<string> Noticia;
        IConsulta ISangria.Consulta => throw new NotImplementedException();
        protected abstract bool Insert_Data_Value(Dictionary<string, object> keyValuesData);
        internal bool Gravar(List<Sangria_e> sangria_s)
        {
            if (sangria_s !=null)
            {
                if (sangria_s.Count!=0)
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

        ISangria_e[] ISangria.Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        ISangria_e ISangria.Select(object current)
        {
            throw new NotImplementedException();
        }
        public bool Sangria(/*Decimal valor, string observacao*/)
        {
            //Caixa_Sangria = valor;
            //Observacao = observacao;

            //this.Print.PrintPage += new PrintPageEventHandler(Sangria_PrintPage);
            //this.Print.PrinterSettings.PrintFileName = "Sangria";

            //this.Print.BeginPrint += PrintDocument_BeginPrint;
            //this.Print.EndPrint += PrintDocument_EndPrint;
            //this.Print.Print();
            //if (InicioImpresao)
            //{
            //    while (!FimImpresao)
            //    {
            //        System.Threading.Thread.Sleep(100);
            //    }
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return false;
        }
        private void Sangria_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Graphics graphics = e.Graphics;
            ////print header
            //graphics.DrawString("Sangria", Bold, Brushes.Black, 80, 5);
            //graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), Bold, Brushes.Black, 20, 45);
            //graphics.DrawString("Valor: " + Caixa_Sangria.ToString("f2"), Bold, Brushes.Black, 20, 65);
            //graphics.DrawLine(Pens.Black, 10, 95, 250, 95);
            //graphics.DrawString("Asinatura", Bold, Brushes.Black, 80, 125);
            //graphics.DrawString(Observacao, Bold, Brushes.Black, 10, 200);
        }
    }
}