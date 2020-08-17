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
    public partial class FrmBoasVindas : Form
    {
        public FrmBoasVindas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
            else
            {
                circularProgressBar1.Text = cont.ToString();

                circularProgressBar1.PerformLayout();
                circularProgressBar1.Increment(cont);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0) ;
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            LblNomeWelcome.Text = Program.objhope.Autenticacao.Colaborador().Get_Nome_Vendedo;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            //  timer1.Stop();


        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
