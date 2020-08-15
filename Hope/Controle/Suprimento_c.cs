using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace Hope.Controle
{
    internal abstract class Suprimento_c : ISuprimento
    {
        internal List<string> Noticia;
        IConsulta ISuprimento.Consulta => throw new NotImplementedException();

        protected abstract bool Insert_Data_Value(Dictionary <string,object> keyValuesData );
        internal bool Gravar(List<Suprimento_e> suprimento_s)
        {
            if (suprimento_s!=null)
            {
                if (suprimento_s.Count!=0)
                {
                    List<bool> vs = new List<bool>();
                    foreach (Suprimento_e item in suprimento_s)
                    {
                        vs.Add(Insert_Data_Value(item.GetKeysValueData()));
                    }
                    if (vs.Find(x=>x == true))
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

        ISuprimento_e[] ISuprimento.Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        ISuprimento_e ISuprimento.Select(object current)
        {
            throw new NotImplementedException();
        }
        public bool Suprimento(/*decimal valor*/)
        {
            //Caixa_Suprimento = valor;
            return false;
            //this.Print.PrintPage += new PrintPageEventHandler(PrintPage_Suprimento);
            //this.Print.PrinterSettings.PrintFileName = "Suprimento";
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
        }
        private void PrintPage_Suprimento(object sender, PrintPageEventArgs e)
        {
            //Graphics graphics = e.Graphics;

            ////print header
            //graphics.DrawString("Suprimento", Bold, Brushes.Black, 80, 5);
            //graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), Bold, Brushes.Black, 20, 45);
            //graphics.DrawString("Valor: " + Caixa_Suprimento.ToString("f2"), Bold, Brushes.Black, 20, 65);
            //graphics.DrawLine(Pens.Black, 10, 95, 250, 95);
            //graphics.DrawString("Asinatura", Bold, Brushes.Black, 80, 125);

        }
    }
}