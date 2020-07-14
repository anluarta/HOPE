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
    public partial class CupomCliente : UserControl
    {
        public CupomCliente()
        {
            InitializeComponent();
        }

        private void btnFiltraCliente_Click(object sender, EventArgs e)
        {
            bool vfiltro = Program.ObjHope.Cliente.Localizar(cmbOperacaoConsultaClient.SelectedItem.ToString(), cmbLocalConsultaClien.SelectedItem.ToString(), cmbOrdenConsultaClient.SelectedItem.ToString(), 0, txtTermoClient.Text, out string msg,out Hope.Entidade.ICliente[] ListaResultado);
            MessageBox.Show(msg);
            if (vfiltro)
            {
                iClienteBindingSource.DataSource=ListaResultado;
            }
        }
    }
}
