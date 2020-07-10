using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Test
{
    public partial class FormTeste : Form
    {
        frmControlUser frm;

        public FormTeste()
        {
            InitializeComponent();
            frm = new frmControlUser();
        }
        private void carreganucleo()
        {
            try
            {
               // Program.nHope = Hope.Nucleo.New(true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

        }
        private void FormTeste_Shown(object sender, EventArgs e)
        {
            carreganucleo();
        }
        private void ExibicaoAcao(Control control)
        {
            control.Dock = DockStyle.Fill;
            frm.Size =control.Size;
            frm.MinimumSize = control.Size;
            frm.Controls.Add(control);
            frm.Controls[frm.Controls.IndexOf(control)].BringToFront();
            frm.Refresh();
            frm.ShowDialog();

        }
        private void btnNewUsuario_Click(object sender, EventArgs e)
        {
            View.UsuarioNovo usuarioNovo = new View.UsuarioNovo();
            usuarioNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(usuarioNovo);
        }

        private void frm_Close_Clisk(object sender, EventArgs e)
        {
            frm.Controls.Clear();
            frm.Close();
        }

        private void btnListUsuario_Click(object sender, EventArgs e)
        {
            View.UsuarioLista usuarioLista = new View.UsuarioLista();
            usuarioLista.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(usuarioLista);
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            View.ClienteNovo clienteNovo = new View.ClienteNovo();
            clienteNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(clienteNovo);
        }

        private void btnListCliente_Click(object sender, EventArgs e)
        {
            View.ClienteLista clienteLista = new View.ClienteLista();
            clienteLista.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(clienteLista);
        }

        private void btnNewProduto_Click(object sender, EventArgs e)
        {
            View.ProdutoNovo produtoNovo = new View.ProdutoNovo();
            produtoNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(produtoNovo);
        }

        private void btnListProduto_Click(object sender, EventArgs e)
        {
            View.ProdutoLista produtoLista = new View.ProdutoLista();
            produtoLista.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(produtoLista);
        }

        private void btnNewCaixa_Click(object sender, EventArgs e)
        {
            View.CaixaNovo caixaNovo = new View.CaixaNovo();
          //  caixaNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(caixaNovo);
        }

        private void btnListCaixa_Click(object sender, EventArgs e)
        {
            View.CaixaLista caixaLista = new View.CaixaLista();
            caixaLista.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(caixaLista);
        }

        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            View.CaixaRecebimento caixaRecebimento = new View.CaixaRecebimento();
          //  caixaRecebimento.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(caixaRecebimento);
        }

        private void btnNewCupom_Click(object sender, EventArgs e)
        {
            
            View.CupomNovo cupomNovo = new View.CupomNovo();
           // cupomNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(cupomNovo);
        }

        private void btnListCupom_Click(object sender, EventArgs e)
        {
            View.CupomList cupomList = new View.CupomList();
            cupomList.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(cupomList);
        }
    }
}
