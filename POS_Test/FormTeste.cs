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
        private void FormTeste_Shown(object sender, EventArgs e)
        {
            cmbColunaConsultaCaixa.Items.AddRange(Program.ObjHope.ArrayCaixaConsultaColuna);
            cmbColunaConsultaCliente.Items.AddRange(Program.ObjHope.ArrayClienteConsultaColuna);
            cmbColunaConsultaCupom.Items.AddRange(Program.ObjHope.ArrayCupomConsultaColuna);
            cmbColunaConsultaProduto.Items.AddRange(Program.ObjHope.ArrayProdutoConsultaColuna);
            cmbColunaConsultaUsuario.Items.AddRange(Program.ObjHope.ArrayUsuarioConsultaColuna);
            cmbComandoConsualtaCliente.Items.AddRange(Program.ObjHope.ArrayConsultaComando);
            cmbComandoConsultaCaixa.Items.AddRange(Program.ObjHope.ArrayConsultaComando);
            cmbComandoConsultaCupom.Items.AddRange(Program.ObjHope.ArrayConsultaComando);
            cmbComandoConsultaProduto.Items.AddRange(Program.ObjHope.ArrayConsultaComando);
            cmbComandoConsultaUsuar.Items.AddRange(Program.ObjHope.ArrayConsultaComando);
            cmbCondicaoConsultaCaixa.Items.AddRange(Program.ObjHope.ArrayCondicaoConsulta);
            cmbCondicaoConsultaCliente.Items.AddRange(Program.ObjHope.ArrayCondicaoConsulta);
            cmbCondicaoConsultaCupom.Items.AddRange(Program.ObjHope.ArrayCondicaoConsulta);
            cmbCondicaoConsultaPRoduto.Items.AddRange(Program.ObjHope.ArrayCondicaoConsulta);
            cmbCondicaoConsultaUsuario.Items.AddRange(Program.ObjHope.ArrayCondicaoConsulta);
            cmbOrdenConsultaCliente.Items.AddRange(Program.ObjHope.ArrayConsultaOrden);
            cmbOrdenConsultaCupom.Items.AddRange(Program.ObjHope.ArrayConsultaOrden);
            cmbOrdenConsultaProduto.Items.AddRange(Program.ObjHope.ArrayConsultaOrden);
            cmbOrdenConsultaUsuario.Items.AddRange(Program.ObjHope.ArrayConsultaOrden);
            cmbOrdenConusltaCaixa.Items.AddRange(Program.ObjHope.ArrayConsultaOrden);
        }
        private void ExibicaoAcao(Control control)
        {
            control.Dock = DockStyle.Fill;
            frm.MinimumSize = control.Size;
            frm.Size = control.Size;
            frm.Controls.Add(control);
            frm.Controls[frm.Controls.IndexOf(control)].BringToFront();
            frm.CreateGraphics();
            frm.ShowDialog();

        }
        private void btnNovoColaborador_Click(object sender, EventArgs e)
        {
            View.ColaboradorNovoRegistro usuarioNovo = new View.ColaboradorNovoRegistro();
            usuarioNovo.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(usuarioNovo);
        }


        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            View.CompradorNovo clienteNovo = new View.CompradorNovo();
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
            View.ColaboradorLogin colaboradorLogin  = new View.ColaboradorLogin();
            colaboradorLogin.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(colaboradorLogin);
            lbllogin.Text = Program.ObjHope.Colaborador.Informacao.ToMessageBox();
            btnLogouf.Enabled = Program.ObjHope.Colaborador.Autenticado;
            btnLogin.Enabled = !Program.ObjHope.Colaborador.Autenticado;
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
            const string lblformat = "R$ {0}";
            lbltotCredito.Text =string.Format(lblformat, Program.ObjHope.Caixa.Credito_Total);
            lbltotDebito.Text =string.Format(lblformat, Program.ObjHope.Caixa.Debido_Total);
            lbltotDinheiro.Text =string.Format(lblformat, Program.ObjHope.Caixa.Dinheiro_Total);
            lbltotInterno.Text =string.Format(lblformat, Program.ObjHope.Caixa.Interno_Total);
            lbltotOutro.Text =string.Format(lblformat, Program.ObjHope.Caixa.Outro_Total);
            lbltotRecebimento.Text =string.Format(lblformat, Program.ObjHope.Caixa.Recebimento_Total);
            lbltotReforco.Text =string.Format(lblformat, Program.ObjHope.Caixa.Reforco_Total);
            lbltotSangria.Text =string.Format(lblformat, Program.ObjHope.Caixa.Sangria_Total);
            lbltotValeAlimentacao.Text =string.Format(lblformat, Program.ObjHope.Caixa.Vale_Alimentacao_Total);
            lbltotValeRefeicao.Text =string.Format(lblformat, Program.ObjHope.Caixa.Vale_Refeicao_Total);
        }

        private void btnFiltarUsuario_Click(object sender, EventArgs e)
        {
            bool bfiltro = Program.ObjHope.Colaborador.Localizar(Orden: cmbOrdenConsultaUsuario.Text, Comando: cmbComandoConsultaUsuar.Text, Coluna: cmbColunaConsultaUsuario.Text, Limit: numUsuarioLimitFiltro.Value, Termo: txtTermoUsuario.Text, ListaRegistro: out Hope.Entidade.IColaborador_Ent_c[] ListaRegistro);
            MessageBox.Show(Program.ObjHope.Colaborador.Informacao.ToMessageBox());

            if (bfiltro)
            {
                iColaboradorEntcBindingSource.DataSource = ListaRegistro;
            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {

            bool bfocus = Program.ObjHope.Colaborador.SelecionaRegistro(iColaboradorEntcBindingSource.Current);
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());

            if (bfocus)
            {

                View.ColaboradorAlteraRegistro usuarioAltera = new View.ColaboradorAlteraRegistro();
                usuarioAltera.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(usuarioAltera);
            }
        }
        private void btnFiltarCliente_Click(object sender, EventArgs e)
        {
            bool vfilrto = Program.ObjHope.Comprador.Localizar(Orden: cmbOrdenConsultaCliente.Text, Comando: cmbColunaConsultaCliente.Text, Coluna: cmbColunaConsultaCliente.Text, Limit: numLimitConsultaCliente.Value, Termo: txtTermoCliente.Text, ListaResultado: out Hope.Entidade.IComprador_Ent_c[] listaResultado);
            MessageBox.Show(Program.ObjHope.Caixa.Informacao.ToMessageBox());

            if (vfilrto)
            {
                iCompradorEntcBindingSource.DataSource = listaResultado;
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Comprador.SelecionaRegistro(iCompradorEntcBindingSource.Current))
            {
                View.CompradorAlterar clienteAlterar = new View.CompradorAlterar();
                clienteAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(clienteAlterar);
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Comprador.Informacao.ToMessageBox());
            }
        }
        private void btnFiltarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Produto.Localizar(Orden: cmbOrdenConsultaProduto.Text, Comando: cmbComandoConsultaProduto.Text, Coluna: cmbColunaConsultaProduto.Text, Limit: numLimitConsultaProduto.Value, Termo: txtTermoProduto.Text,ListaRegistro: out Hope.Entidade.IProduto_Ent_c[] ListaResultado))
            {
                iProdutoEntcBindingSource.DataSource = ListaResultado;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Produto.SelecionaRegistro((object)dgvListaProduto.SelectedRows))
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

                bool vselec = Program.ObjHope.Caixa.DetalheValorTotalRegistro(iCaixaEntcBindingSource.Current,  out Hope.Entidade.ICaixaTotal_Ent_c Totais);
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
            bool vfiltro = Program.ObjHope.Caixa.Localizar(Comando:cmbComandoConsultaCaixa.Text,Coluna: cmbColunaConsultaCaixa.Text,Orden: cmbOrdenConusltaCaixa.Text, Limit:numLimitConsultaCaixa.Value , Termo:txtTermoCaixa.Text,ListaResultado: out Hope.Entidade.ICaixa_Ent_c[] registro);
            if (vfiltro)
            {
                iCaixaEntcBindingSource.DataSource = registro;
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
            //bool vfiltro = Program.ObjHope.Cupom.Localizar(Comando: cmbComandoConsultaCupom.SelectedItem.ToString(), Coluna: cmbColunaConsultaCupom.SelectedItem.ToString(), Orden: cmbOrdenConsultaCupom.SelectedItem.ToString(), Limit: numLimitConsultaCupom.Value, Termo: txtTermoCupom.Text, ListaRegistro: out Hope.Entidade.ICupom_Ent_c[] listaresgistro);
            //MessageBox.Show(Program.ObjHope.Produto.Informacao.ToMessageBox());
            //if (vfiltro)
            //{

            //}
        }

        private void tabPageCRUD_Leave(object sender, EventArgs e)
        {
            iColaboradorEntcBindingSource.Clear();
            iCompradorEntcBindingSource.Clear();
            iProdutoEntcBindingSource.Clear();
            MessageBox.Show("Mem Cache CRUD CLEA");
        }

        private void btnLogouf_Click(object sender, EventArgs e)
        {
            Program.ObjHope.Colaborador.Logouf();
            btnLogouf.Enabled = Program.ObjHope.Colaborador.Autenticado;
            btnLogin.Enabled = !Program.ObjHope.Colaborador.Autenticado;
        }
    }
}
