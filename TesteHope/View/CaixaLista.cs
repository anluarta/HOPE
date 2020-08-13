using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Hope.Interface.ICaixa_e row;
            row = Program.ObjHope.Pos.Caixa.Select(iCaixaeBindingSource.Current);
            View.CaixaLeitura caixaLeitura = new CaixaLeitura(row);
            using (frmViewControlSecundario frm = new frmViewControlSecundario())
            {
                caixaLeitura.btnfechar.Click += new EventHandler(frm.btnfechar);
                caixaLeitura.Dock = DockStyle.Fill;
                frm.Controls.Add(caixaLeitura);
                frm.ShowDialog();
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
