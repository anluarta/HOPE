using POS_Alessandro.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Alessandro
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLoginTrans frmLoginTrans = new FrmLoginTrans();
            frmLoginTrans.ShowDialog();

           // Application.Run(new NewFolder1.BackOffice());
        }
    }
}
