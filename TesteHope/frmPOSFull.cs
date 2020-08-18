using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteHope
{
    public partial class frmPOSFull : Form
    {
        View.Login vwLogin;
        View.CaixaLeitura vwCaixaLeitura;
        View.CaixaSangria vwCaixaSangria;
        View.CaixaSuprimento vwCaixaSuprimento;
        View.CaixaLista vwCaixalista;
        View.Vender vwVenda;
        View.VendaLista vwVendaLista;
        public frmPOSFull()
        {
            InitializeComponent();
            Program.ObjHope = new Hope.Hope_m();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldatetime.Text = DateTime.Now.ToString();
            if (count == 100)
            {
                count = 0;
                lblCaixaResult.Text = "";
            }
            else
            {
                count++;
            }
        }
        void Exibicao(Control control)
        {
            control.Dock = DockStyle.Fill;
            if (pnlView.Controls.Contains(control))
            {
                int indexControl = pnlView.Controls.IndexOf(control);
                pnlView.Controls[indexControl].BringToFront();
                return;
            }
            else
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(control);
                return;
            }
        }
        void Remocao(Control control)
        {
            if (pnlView.Controls.Contains(control))
            {
                int indexControl = pnlView.Controls.IndexOf(control);
                pnlView.Controls.Remove(control);
                return;
            }
            else
            {
                MessageBox.Show("Controle View nao Localziado no pnlView");
                return;
            }
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwLogin = new View.Login();
            vwLogin.btnfechar.Click += new EventHandler(vwLogin_btnfechar_Click);
            Exibicao(vwLogin);
        }

        private void vwLogin_btnfechar_Click(object sender, EventArgs e)
        {
            Remocao(vwLogin);
            vwLogin = null;
        }

        private void logouthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Autenticacao.Logout();
            MessageBox.Show(Program.ObjHope.Autenticacao.Notifica());
        }

        private void BtnCaixaNovo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.ObjHope.Pos.Caixa.Novo(out Program.CaixaOperacao))
                {
                    lblCaixaResult.Text = Program.ObjHope.Pos.Caixa.Notifica();
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());
                }
            }
            catch (Hope.HException_c he)
            {
                MessageBox.Show(he.Message);
            }
        }

        private void BtnCaixaFechamento_Click(object sender, EventArgs e)
        {
            if (Program.CaixaOperacao != null)
            {
                Program.CaixaOperacao.Fechamento();
                try
                {
                    if (Program.ObjHope.Pos.Caixa.Gravar(Program.CaixaOperacao, out Program.CaixaOperacao))
                    {
                        lblCaixaResult.Text = Program.ObjHope.Pos.Caixa.Notifica();
                        Program.CaixaOperacao = null;
                    }
                    else
                    {
                        lblCaixaResult.Text = Program.ObjHope.Pos.Caixa.Notifica();
                    }
                }
                catch (Hope.HException_c he)
                {
                    MessageBox.Show(he.Message);
                }
            }
            else
            {
                MessageBox.Show("Caixaoperacao esta nullo");
            }
        }

        private void BtnCaixaSangria_Click(object sender, EventArgs e)
        {
            vwCaixaSangria = new View.CaixaSangria();
            vwCaixaSangria.btnfechar.Click += new EventHandler(vwSangria_btnfechar_Click);
            Exibicao(vwCaixaSangria);
        }

        private void vwSangria_btnfechar_Click(object sender, EventArgs e)
        {
            Remocao(vwCaixaSangria);
            vwCaixaSangria = null;

        }

        private void BtnCaixaSuprimento_Click(object sender, EventArgs e)
        {
            vwCaixaSuprimento = new View.CaixaSuprimento();
            vwCaixaSuprimento.btnfechar.Click += new EventHandler(vwSuprimento_btnfechar_Click);
            Exibicao(vwCaixaSuprimento);
        }

        private void vwSuprimento_btnfechar_Click(object sender, EventArgs e)
        {
            Remocao(vwCaixaSuprimento);
            vwCaixaSuprimento = null;
        }

        private void BtnCaixaLeitura_Click(object sender, EventArgs e)
        {
            if (Program.CaixaOperacao != null)
            {
                vwCaixaLeitura = new View.CaixaLeitura(Program.CaixaOperacao);
                vwCaixaLeitura.btnfechar.Click += new EventHandler(vwLeitura_btnfechar_Click);
                Exibicao(vwCaixaLeitura);
            }
            else
            {
                MessageBox.Show("CaixaOperacao esta nullo");
            }
        }

        private void vwLeitura_btnfechar_Click(object sender, EventArgs e)
        {
            Remocao(vwCaixaLeitura);
            vwCaixaLeitura = null;

        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            try
            {

                //if (Program.ObjHope.Pos.Vender.Gravar(Program.Vender))
                //{
                //    MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
                //}
                if (Program.ObjHope.Pos.Vender.Novo(Program.CaixaOperacao, out Hope.Interface.IVender_e result))
                {
                    Program.Vender = result;
                    vwVenda = new View.Vender();
                    vwVenda.btnfechar.Click += new EventHandler(vwVenda_btnfechar_Click);
                    Exibicao(vwVenda);
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
                }
            }
            catch (Hope.HException_c he)
            {
                MessageBox.Show(he.Message);
            }

        }

        private void vwVenda_btnfechar_Click(object sender, EventArgs e)
        {
            Remocao(vwVenda);
            vwVenda = null;
        }

        private void btnListaVenda_Click(object sender, EventArgs e)
        {
            vwVendaLista = new View.VendaLista();
            vwVendaLista.btnfechar.Click += new EventHandler(vwVendaLista_btnfechar_Click);
            vwVendaLista.btnCarregarRegistro.Click += new EventHandler(vwVendaLista_btnCarreagarRegistro);
            Exibicao(vwVendaLista);
        }

        private void vwVendaLista_btnCarreagarRegistro(object sender, EventArgs e)
        {
            if (Program.ObjHope.Pos.Vender.Continuar_Registro(vwVendaLista.iVendereBindingSource.Current, out Hope.Interface.IVender_e result))
            {
                Remocao(vwVendaLista);
                Program.Vender = result;
                vwVenda = new View.Vender();
                vwVenda.btnfechar.Click += new EventHandler(vwVenda_btnfechar_Click);
                Exibicao(vwVenda);
                vwVendaLista = null;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
            }
        }

        private void vwVendaLista_btnfechar_Click(object sender, EventArgs e)
        {

            Remocao(vwVendaLista);
            vwVendaLista = null;
        }

        private void btnCaixaLista_Click(object sender, EventArgs e)
        {
            vwCaixalista = new View.CaixaLista();
            vwCaixalista.btnfechar.Click += new EventHandler(vwCaixalista_btnfechar_Click);
            Exibicao(vwCaixalista);
        }

        private void vwCaixalista_btnfechar_Click(object sender, EventArgs e)
        {
            Remocao(vwCaixalista);
            vwCaixalista = null;
        }

        private void preLoadHopeCarrgarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.PreLoadHope();

            Exibicao(new View.PreLoadCargaDado());

        }
    }
}
