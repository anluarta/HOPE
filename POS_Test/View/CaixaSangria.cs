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
    public partial class CaixaSangria : UserControl
    {
        public CaixaSangria()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool v = Program.ObjHope.Caixa.Sangria(numValor.Value, txtObservacao.Text);
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
            if (v)
            {
                btnVoltar.PerformClick();
            }
            
        }
    }
}
