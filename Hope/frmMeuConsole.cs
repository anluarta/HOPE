using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope
{
    public partial class frmMeuConsole : Form
    {
        public frmMeuConsole()
        {
            InitializeComponent();
           
        }

        private void frmMeuConsole_Activated(object sender, EventArgs e)
        {
            if (Nucleo.ObjEstado == null)
            {
                MessageBox.Show("Erro no estado execucao");
                return;
            }
            txtLosa.Clear();
            for (int i = 0; i < Nucleo.ObjEstado.TempoExecucao.Count; i++)
            {
                txtLosa.AppendText(Nucleo.ObjEstado.TempoExecucao[i].ToString());
            }
        }
    }
}
