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
    public partial class PreLoadCargaDado : UserControl
    {
        public PreLoadCargaDado()
        {
            InitializeComponent();
            foreach (string item in Program.Vs.ToArray())
            {
                richTextBox1.AppendText(item);
            }
        }
    }
}
