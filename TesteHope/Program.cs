using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteHope
{
    static class Program
    {
        internal static  Hope.IHope ObjHope;

        internal static Hope.Interface.ICaixa_e CaixaOperacao;
        internal static Hope.Interface.IVender_e Vender;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPOSFull());
        }
    }
}
