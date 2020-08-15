using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace POS_Alessandro.NewFolder1
{
    public partial class FrmLoginTrans : Form
    {
        public FrmLoginTrans()
        {
            InitializeComponent();
        }

        private void TxtUsuarioTrans_Enter(object sender, EventArgs e)
        {
            if (TxtUsuarioTrans.Text == "Usuario") ;
            TxtUsuarioTrans.Text = "";
            TxtUsuarioTrans.ForeColor = Color.LightGray;



        }

        private void TxtUsuarioTrans_Leave(object sender, EventArgs e)
        {
            if (TxtUsuarioTrans.Text == "") ;
            TxtUsuarioTrans.Text = "Usuario";
            TxtUsuarioTrans.ForeColor = Color.DimGray;
        }

        private void TxtSenhaTrans_Enter(object sender, EventArgs e)
        {
            if (TxtSenhaTrans.Text == "Senha") ;
            TxtSenhaTrans.Text = "";
            TxtSenhaTrans.ForeColor = Color.LightGray;
            TxtSenhaTrans.UseSystemPasswordChar = true;

        }

        private void TxtSenhaTrans_Leave(object sender, EventArgs e)
        {
            if (TxtSenhaTrans.Text == "") ;
            TxtSenhaTrans.Text = "Senha";
            TxtSenhaTrans.ForeColor = Color.DimGray;
            TxtSenhaTrans.UseSystemPasswordChar = false;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLoginTrans_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void TxtUsuarioTrans_TextChanged(object sender, EventArgs e)
        {

        }
    }




}











