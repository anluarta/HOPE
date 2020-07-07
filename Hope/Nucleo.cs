using Hope.IFace;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public class Nucleo 
    {
        public static IEstatdoOperacional ObjEstado { get; protected set; }
        public static IUsuario ObjUsuario { get; internal set; }
        public static ICliente ObjCliente { get; protected set; }
        Nucleo()
        {
            if (ObjEstado.IsDebug)
            {
                ObjUsuario = new Dbg.Usuario(); 
            }
            else
            {
                ObjUsuario = new Pdc.Usuario();
            }
        }
        public static Nucleo New(Boolean _debug)
        {
            ObjEstado = new EstadoOperacional(_debug);
            if (_debug)
            {
                ObjEstado.MeuConsole.Show();
                return new Nucleo();
            }
            else
            {

                Properties.Settings settings = new Properties.Settings();
                if (!settings.IsCreatDataBase)
                {
                    using (frmStatus status = new frmStatus())
                    {
                        status.ShowDialog();
                    }
                }
                settings = null;
                return new Nucleo();
            }
        }

    }
}
