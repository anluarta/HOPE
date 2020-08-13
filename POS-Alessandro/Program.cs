using Hope;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Alessandro
{
    static class Program
    {
        public static Hope.IHope objhope;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            objhope = new Hope_m();
            // Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);          
            // Application.Run(new NewFolder1.BackOffice());

            NewFolder1.FrmLogin frmLogin = new NewFolder1.FrmLogin();
            frmLogin.ShowDialog();

            NewFolder1.BackOffice backOffice = new NewFolder1.BackOffice();
            backOffice.ShowDialog();

            NewFolder1.FrenteDeCaixa frenteDeCaixa = new NewFolder1.FrenteDeCaixa();
            frenteDeCaixa.ShowDialog();
        }
    }
}
