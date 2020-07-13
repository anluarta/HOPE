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
    public partial class CaixaReforco : UserControl
    {
        public CaixaReforco()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Caixa.Reforco(txtValor.Text, txtObservacao.Text, out string msg))
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
