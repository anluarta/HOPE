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
      internal static Hope.IHope objhope;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            objhope = new Hope.Hope_m();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BackOffice back = new BackOffice ();
           back.ShowDialog();

        }
    }
}
