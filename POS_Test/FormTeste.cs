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

        }

        private void btnIniciaMeuCaixa_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Caixa.IniciarMeuCaixa();
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
        }

        private void btnEnceraMeuCaixa_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Caixa.EncerrarMeuCaixa();
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());
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
            bool bfiltro = Program.ObjHope.Usuario.Localizar(Orden: cmbOrdenConsultaUsuario.SelectedItem.ToString(), Comando: cmbComandoConsultaUsuar.SelectedItem.ToString(), Coluna: cmbColunaConsultaUsuario.SelectedItem.ToString(), Limit: numUsuarioLimitFiltro.Value, Termo: txtTermoUsuario.Text, ListaRegistro: out Hope.Entidade.IUsuario_Ent_c[] ListaRegistro);
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());

            if (bfiltro)
            {
                iUsuarioBindingSource.DataSource = ListaRegistro;
            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            bool bfocus = Program.ObjHope.Usuario.SelecionaRegistro((object)dgvListaUsuario.SelectedRows);
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());

            if (bfocus)
            {
                View.UsuarioAlteraRegistro usuarioAltera = new View.UsuarioAlteraRegistro();
                usuarioAltera.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(usuarioAltera);
            }
        }
        private void btnFiltarCliente_Click(object sender, EventArgs e)
        {
            bool vfilrto = Program.ObjHope.Cliente.Localizar(Orden: cmbOrdenConsultaCliente.SelectedItem.ToString(), Comando: cmbColunaConsultaCliente.SelectedItem.ToString(), Coluna: cmbColunaConsultaCliente.SelectedItem.ToString(), Limit: numLimitConsultaCliente.Value, Termo: txtTermoCliente.Text, ListaResultado: out Hope.Entidade.ICliente_Ent_c[] listaResultado);
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());

            if (vfilrto)
            {
                iClienteBindingSource.DataSource = listaResultado;

            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Cliente.SelecionaRegistro((object)dgvListaCliente.SelectedRows))
            {
                View.ClienteAlterar clienteAlterar = new View.ClienteAlterar();
                clienteAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(clienteAlterar);

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.Informacao.ToMessageBox());
            }
        }
        private void btnFiltarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Produto.Localizar(Orden: cmbOrdenConsultaProduto.SelectedItem.ToString(), Comando: cmbComandoConsultaProduto.SelectedItem.ToString(), Coluna: cmbColunaConsultaProduto.SelectedItem.ToString(), Limit: numLimitConsultaProduto.Value, Termo: txtTermoProduto.Text,ListaRegistro: out Hope.Entidade.IProduto_Ent_c[] ListaResultado))
            {
                iProdutoBindingSource.DataSource = ListaResultado;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.SelecionaRegistro((object)dgvListaProduto.SelectedRows))
            {
                View.ProdutoAlterar produtoAlterar = new View.ProdutoAlterar();
                produtoAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(produtoAlterar);

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
            }
        }

        private void btnDetalheCaixaSelecionado_Click(object sender, EventArgs e)
        {
            if (dgvListaCaixa.SelectedRows.Count != 0)
            {

                bool vselec = Program.ObjHope.Caixa.DetalheValorTotalRegistro(dgvListaCaixa.SelectedRows[0],  out Hope.Entidade.ICaixaTotal_Ent_c Totais);
                if (vselec)
                {
                    View.CaixaDetalhe caixaDetalhe = new View.CaixaDetalhe();
                    caixaDetalhe.LoadICaixaTotal(Totais);
                    caixaDetalhe.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                    ExibicaoAcao(caixaDetalhe);
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());

                }
            }
        }

        private void btnFiltarCaixa_Click(object sender, EventArgs e)
        {
            bool vfiltro = Program.ObjHope.Caixa.Localizar(Comando:cmbComandoConsultaCaixa.SelectedText.ToString(),Coluna: cmbColunaConsultaCaixa.SelectedText.ToString(),Orden: cmbOrdenConusltaCaixa.SelectedText.ToString(), Limit:numLimitConsultaCaixa.Value , Termo:txtTermoCaixa.Text,ListaResultado: out Hope.Entidade.ICaixa_Ent_c[] registro);
            if (vfiltro)
            {
                iCaixaBindingSource.DataSource = registro;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());

            }
        }

        private void btnCupomIniciaNovoCupom_Click(object sender, EventArgs e)
        {
            bool vinicia = Program.ObjHope.Cupom.NovoRegistro();
            MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());

        }

        private void btnCupomFechar_Click(object sender, EventArgs e)
        {
            bool vinicia = Program.ObjHope.Cupom.FinalizarRegistro();
            MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());

        }

        private void btnCupomFiltraLista_Click(object sender, EventArgs e)
        {
            bool vfiltro = Program.ObjHope.Cupom.Localizar(Comando: cmbComandoConsultaCupom.SelectedItem.ToString(), Coluna: cmbColunaConsultaCupom.SelectedItem.ToString(), Orden: cmbOrdenConsultaCupom.SelectedItem.ToString(), Limit: numLimitConsultaCupom.Value, Termo: txtTermoCupom.Text, ListaRegistro: out Hope.Entidade.ICupom_Ent_c[] listaresgistro);
            MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
            if (vfiltro)
            {

            }
        }

        private void tabPageCRUD_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Mem Cache CRUD CLEA");
        }
    }
}
