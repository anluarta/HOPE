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
            frm.Size = control.Size;
            frm.MinimumSize = control.Size;
            frm.Controls.Add(control);
            frm.Controls[frm.Controls.IndexOf(control)].BringToFront();
            frm.Refresh();
            frm.ShowDialog();

        }
        private void btnNewUsuario_Click(object sender, EventArgs e)
        {
            View.UsuarioNovoRegistro usuarioNovo = new View.UsuarioNovoRegistro();
            usuarioNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(usuarioNovo);
        }


        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            View.ClienteNovo clienteNovo = new View.ClienteNovo();
            clienteNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(clienteNovo);
        }



        private void btnNewProduto_Click(object sender, EventArgs e)
        {
            View.ProdutoNovo produtoNovo = new View.ProdutoNovo();
            produtoNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(produtoNovo);
        }


        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            View.CaixaRecebimento caixaRecebimento = new View.CaixaRecebimento();
            caixaRecebimento.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(caixaRecebimento);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.Autenticado(out string MsgResult))
            {
                lbllogin.Text = MsgResult;
                if (MessageBox.Show(MsgResult, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.ObjHope.Usuario.Sair(out string Logof);
                    lbllogin.Text = Logof;
                }
                else
                {
                    return;
                }
            }
            else
            {
                View.UsuarioLogin usuarioLogin = new View.UsuarioLogin();
                usuarioLogin.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(usuarioLogin);
                lbllogin.Text = MsgResult;
            }
        }

        private void btnIniciaMeuCaixa_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Caixa.IniciarMeuCaixa(out string mgs))
            {
                MessageBox.Show(mgs);
            }
            else
            {
                MessageBox.Show(mgs);
            }
        }

        private void btnEnceraMeuCaixa_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Caixa.EncerrarMeuCaixa(out string mgs))
            {
                MessageBox.Show(mgs);
            }
            else
            {
                MessageBox.Show(mgs);
            }
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            View.CaixaSangria caixaSangria = new View.CaixaSangria();
            caixaSangria.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(caixaSangria);
        }

        private void btnReforco_Click(object sender, EventArgs e)
        {
            View.CaixaReforco caixaReforco = new View.CaixaReforco();
            caixaReforco.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(caixaReforco);
        }

        private void btnAtualizarMeuCaixa_Click(object sender, EventArgs e)
        {
            bool vAtualmeucaixa = Program.ObjHope.Caixa.Situacao(out string msgmeucaixa);
            lblresultmeucaixa.Text = msgmeucaixa;
            lbltotContaCliente.Text = Program.ObjHope.Caixa.ContaClienteTotal;
            lbltotCredito.Text = Program.ObjHope.Caixa.CreditoTotal;
            lbltotDebito.Text = Program.ObjHope.Caixa.DebidoTotal;
            lbltotDinheiro.Text = Program.ObjHope.Caixa.DinheiroTotal;
            lbltotInterno.Text = Program.ObjHope.Caixa.InternoTotal;
            lbltotOutro.Text = Program.ObjHope.Caixa.OutroTotal;
            lbltotRecebimento.Text = Program.ObjHope.Caixa.RecebimentoTotal;
            lbltotReforco.Text = Program.ObjHope.Caixa.ReforcoTotal;
            lbltotSangria.Text = Program.ObjHope.Caixa.SangriaTotal;
            lbltotValeAlimentacao.Text = Program.ObjHope.Caixa.ValeAlimentacaoTotal;
            lbltotValeRefeicao.Text = Program.ObjHope.Caixa.ValeRefeicaoTotal;
        }

        private void btnFiltarUsuario_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.Localizar(_orden: cmbOrdenConsultaUsuario.SelectedItem.ToString(), _operacao: cmboperacaoConsultaUsuar.SelectedItem.ToString(), _local: cmbLocalConsultaUsuario.SelectedItem.ToString(), _limit: 0, _termo: txtTermoUsuario.Text))
            {
                iUsuarioBindingSource.DataSource = Program.ObjHope.Usuario.DadoResultado;

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);

            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.FocusRegistro((object)dgvListaUsuario.SelectedRows))
            {
                View.UsuarioAlteraRegistro usuarioAltera = new View.UsuarioAlteraRegistro();
                usuarioAltera.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(usuarioAltera);

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);
            }
        }
        private void btnFiltarCliente_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Cliente.Localizar(_orden: cmbOrdenConsultaClient.SelectedItem.ToString(), _operacao: cmbOperacaoConsultaClient.SelectedItem.ToString(), _local: cmbLocalConsultaClien.SelectedItem.ToString(), _limit: 0, _termo: txtTermoClient.Text))
            {
                iClienteBindingSource.DataSource = Program.ObjHope.Cliente.DataResultado;

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);

            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Cliente.FocusRegistro((object)dgvListaCliente.SelectedRows))
            {
                View.ClienteAlterar clienteAlterar = new View.ClienteAlterar();
                clienteAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(clienteAlterar);

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);
            }
        }
        private void btnFiltarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Produto.Localizar(_orden: cmbOrdenConsultaprod.SelectedItem.ToString(), _operacao: cmbOperacaConsultaProd.SelectedItem.ToString(), _local: cmbLocalConsultaProd.SelectedItem.ToString(), _limit: 0, _termo: txtTermoCultaProd.Text))
            {
                iProdutoBindingSource.DataSource = Program.ObjHope.Produto.DadoResultado;

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.StrMsgResultado);

            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.FocusRegistro((object)dgvListaProduto.SelectedRows))
            {
                View.ProdutoAlterar produtoAlterar = new View.ProdutoAlterar();
                produtoAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(produtoAlterar);

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.StrMsgResultado);
            }
        }

        private void btnDetalheCaixaSelecionado_Click(object sender, EventArgs e)
        {
            if (dgvListaCaixa.SelectedRows.Count!=0)
            {

                bool vselec = Program.ObjHope.Caixa.DetalheValorTotalRegistro(dgvListaCaixa.SelectedRows[0], out string msgdetalhe, out Hope.Entidade.ICaixaTotal Totais);
                if (vselec)
                {
                    View.CaixaDetalhe caixaDetalhe = new View.CaixaDetalhe();
                    caixaDetalhe.LoadICaixaTotal(Totais);
                    caixaDetalhe.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                    ExibicaoAcao(caixaDetalhe);
                }
                else
                {
                    MessageBox.Show(msgdetalhe);
                }
            } 
        }

        private void btnFiltarCaixa_Click(object sender, EventArgs e)
        {
            bool vfiltro = Program.ObjHope.Caixa.Localizar(cmbOperacaoConsultaCaixa.SelectedText.ToString(), cmbLocalConsultaCaixa.SelectedText.ToString(), cmbOrdenarConsultaCaixa.SelectedText.ToString(), 0, txtTermoCaixa.Text, out Hope.Entidade.ICaixa[] registro,out string msgresult);
            if (vfiltro)
            {
                iCaixaBindingSource.DataSource = registro;
            }
            else
            {
                MessageBox.Show(msgresult);
            }
        }

        private void btnCupomIniciaNovoCupom_Click(object sender, EventArgs e)
        {
            bool vinicia = Program.ObjHope.Cupom.NovoRegistro(out string msg);
            MessageBox.Show(msg);
        }

        private void btnCupomFechar_Click(object sender, EventArgs e)
        {
            bool vinicia = Program.ObjHope.Cupom.FecharRegistro(out string msg);
            MessageBox.Show(msg);
        }
    }
}
