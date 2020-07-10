using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Test
{
    static class Program
    {
        internal static Hope.IHope ObjHope;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ObjHope = Hope.AbsHope.Beta();
            Application.Run(new FormTeste());
        }
    }
}
