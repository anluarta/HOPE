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
    public partial class FrmCaixaClosed : Form
    {
        public FrmCaixaClosed()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void encerrarCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voltarOperarCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
