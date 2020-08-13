using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Alessandro.NewFolder1
{
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        private void BnfBtnPdv_Click(object sender, EventArgs e)
        {
            FrenteDeCaixa frenteDeCaixa = new FrenteDeCaixa();
            frenteDeCaixa.ShowDialog();

            
        }
    }
}
