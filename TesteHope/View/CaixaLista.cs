using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TesteHope.View
{
    public partial class CaixaLista : UserControl
    {
        public CaixaLista()
        {
            InitializeComponent();
        }

        private void btnVisualizarLeitura_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Pos.Caixa.Print_Document(iCaixaeBindingSource.Current,out PrintDocument document))
            {
                printPreviewDialog1.Document = document;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());
            }

        }

        private void CaixaLista_Load(object sender, EventArgs e)
        {
            Hope.Interface.IConsulta consulta = Program.ObjHope.Pos.Caixa.Consulta();

            consulta.Comando = Hope.Enums.Consulta_u.Comando.Select_All_From;

            if (Program.ObjHope.Pos.Caixa.Find(consulta, out Hope.Interface.ICaixa_e[] result))
            {
                iCaixaeBindingSource.DataSource = result;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());
            }
        }
    }
}
