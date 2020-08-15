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
    public partial class FrmCpf : Form
    {
        public FrmCpf()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // caso o cpf ou cnpj seja valido e tem que esta no label que se encontra na tela de venda precisamento no rodapé 
            //visualmente visuvel. 36154413890.como exemplo demostrado .

        }
    }
}
