using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hope.Interface;
using System.Drawing.Printing;

namespace TesteHope.View
{
    public partial class VendaLista : UserControl
    {
        public VendaLista()
        {
            InitializeComponent();
            Hope.Interface.IConsulta consulta = Program.ObjHope.Pos.Vender.Consulta();
            consulta.Comando = Hope.Enums.Consulta_u.Comando.Select_All_From;
            if (Program.ObjHope.Pos.Vender.Fill(consulta, out Hope.Interface.IVender_e[] result))
            {
                iVendereBindingSource.DataSource = result;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
            }
        }

        private void btnVisualizarRegistro_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Pos.Vender.Select(iVendereBindingSource.Current, out IVender_e vender_))
            {
                if (Program.ObjHope.Pos.Vender.Print_Document(vender_, out PrintDocument doc))
                {
                    printPreviewDialog1.Document = doc;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
                }
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
            }
        }
    }
}
