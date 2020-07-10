using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Test.View
{
    public partial class ClienteLista : UserControl
    {
        public ClienteLista()
        {
            InitializeComponent();
            cmbOperacao.Items.AddRange(Program.ObjHope.GetOperacaoConsulta());
            cmbOrdenar.Items.AddRange(Program.ObjHope.GetOrden());
            cmbLocal.Items.AddRange(Program.ObjHope.GetClienteLocalConsulta());
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Cliente.Localizar(_orden: cmbOrdenar.SelectedItem.ToString(), _operacao: cmbOperacao.SelectedItem.ToString(), _local: cmbLocal.SelectedItem.ToString(), _limit: 0, _termo: txtTermo.Text))
            {
                iClienteVarBindingSource.DataSource = Program.ObjHope.Cliente.DataResultado;

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Cliente.FocusRegistro((object)dataGridView1.SelectedRows))
            {
                View.ClienteAlterar clienteAlterar = new ClienteAlterar();
                using (frmControlUser frm = new frmControlUser())
                {
                    clienteAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                    clienteAlterar.Dock = DockStyle.Fill;
                    frm.Controls.Add(clienteAlterar);
                    frm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);
            }
        }
    }
}
