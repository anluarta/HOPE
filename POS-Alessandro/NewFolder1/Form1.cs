﻿using System;
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
           TxtUsuarioTrans.Text = "Usuario";
           TxtUsuarioTrans.ForeColor = Color.LightGray;



        }

        private void TxtUsuarioTrans_Leave(object sender, EventArgs e)
        {
            //if (TxtUsuarioTrans.Text == "") ;
            //TxtUsuarioTrans.Text = "Usuario";
            //TxtUsuarioTrans.ForeColor = Color.DimGray;
        }

        private void TxtSenhaTrans_Enter(object sender, EventArgs e)
        {
           // if (TxtSenhaTrans.Text == "") ;
           // TxtSenhaTrans.Text = "";
           // TxtSenhaTrans.ForeColor = Color.LightGray;
           TxtSenhaTrans.UseSystemPasswordChar = true;

        }

        private void TxtSenhaTrans_Leave(object sender, EventArgs e)
        {
           // if (TxtSenhaTrans.Text == "Senha") ;
            //TxtSenhaTrans.Text = "";
            //TxtSenhaTrans.ForeColor = Color.DimGray;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrarTRans_Click(object sender, EventArgs e)
        {
            if (Program.objhope.Autenticacao.Login(TxtUsuarioTrans.Text, TxtSenhaTrans.Text))
            {
                MessageBox.Show(Program.objhope.Autenticacao.Notifica());
            }
            else
            {
                MessageBox.Show(Program.objhope.Autenticacao.Notifica());
            }
            if (Program.objhope.Autenticacao.Autenticado)
            {
                FrmBoasVindas frm = new FrmBoasVindas();
                frm.ShowDialog();
            FrmFrenteDeCaixa frmFrenteDe = new FrmFrenteDeCaixa();
            frmFrenteDe.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //so ira aparecer caso seja errado a senha ou usuario
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //so ira aparecer caso seja errado a senha ou usuario
        }
        GUI_V_2.Form1 form1;
        private void button1_Click(object sender, EventArgs e)
        {
            //FrmCaixaClosed frmCaixa = new FrmCaixaClosed();
            //frmCaixa.ShowDialog();

            form1 = new GUI_V_2.Form1();
            form1.btnVenda.Click += BtnVenda_Click;
            form1.ShowDialog();

        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
           // form1.AbrirFormEnPanel(new FrmFrenteDeCaixa());
            
        }
    }




}











