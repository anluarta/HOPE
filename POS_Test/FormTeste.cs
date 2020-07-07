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
                Program.nHope = Hope.Nucleo.New(true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

        }
        private void des_Ativa(bool acao)
        {
            groupBox1.Enabled = acao;
            groupBox2.Enabled = acao;
            groupBox3.Enabled = acao;
            groupBox4.Enabled = acao;
        }
        private void FormTeste_Shown(object sender, EventArgs e)
        {
            carreganucleo();
        }
        private void ExibicaoAcao(Control control)
        {
            control.Dock = DockStyle.Fill;
            frm.Size = control.Size;
            frm.MinimumSize = control.Size;
            frm.Controls.Add(control);
            frm.Controls[frm.Controls.IndexOf(control)].BringToFront();
            frm.ShowDialog();

        }
        private void btnNewUsuario_Click(object sender, EventArgs e)
        {
            View.UsuarioNovo usuarioNovo = new View.UsuarioNovo();
            usuarioNovo.btnVoltar.Click += new EventHandler(frm_Close_Clisk);
            ExibicaoAcao(usuarioNovo);
        }

        private void frm_Close_Clisk(object sender, EventArgs e)
        {
            frm.Controls.Clear();
            frm.Close();
        }

        private void btnListUsuario_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.UsuarioLista());
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.ClienteNovo());
        }

        private void btnListCliente_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.ClienteLista());
        }

        private void btnNewProduto_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.ProdutoNovo());
        }

        private void btnListProduto_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.ProdutoLista());
        }

        private void btnNewCaixa_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.CaixaNovo());
        }

        private void btnListCaixa_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.CaixaLista());
        }

        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.CaixaRecebimento());
        }

        private void btnNewCupom_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.CupomNovo());
        }

        private void btnListCupom_Click(object sender, EventArgs e)
        {
            ExibicaoAcao(new View.CupomList());
        }
    }
}
