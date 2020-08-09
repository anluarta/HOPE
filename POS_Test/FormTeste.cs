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
        Hope.Interface.ICaixa_e Caixa_Entidade;
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
            View.ColaboradorLogin colaboradorLogin = new View.ColaboradorLogin();
            colaboradorLogin.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
            ExibicaoAcao(colaboradorLogin);
            lbllogin.Text = Program.ObjHope.Autenticacao.Notifica.Mensagem();
            btnLogouf.Enabled = Program.ObjHope.Autenticacao.Autenticado;
            btnLogin.Enabled = !Program.ObjHope.Autenticacao.Autenticado;
        }

        private void btnIniciaMeuCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa_Entidade = Program.ObjHope.Pos.Caixa.Novo();
                if (Program.ObjHope.Pos.Caixa.Gravar(Caixa_Entidade))
                {

                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());
                }
            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
                
            }
           
        }

        private void btnEnceraMeuCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa_Entidade.Fechamento();
                if (Program.ObjHope.Pos.Caixa.Gravar(Caixa_Entidade))
                {

                }
                else
                {
                    MessageBox.Show(Program.ObjHope.Pos.Caixa.Notifica());
                }
            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
                
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
            const string lblformat = "R$ {0}";
            lbltotCredito.Text = string.Format(lblformat, Program.ObjHope.Caixa.Credito_Total);
            lbltotDebito.Text = string.Format(lblformat, Program.ObjHope.Caixa.Debido_Total);
            lbltotDinheiro.Text = string.Format(lblformat, Program.ObjHope.Caixa.Dinheiro_Total);
            lbltotInterno.Text = string.Format(lblformat, Program.ObjHope.Caixa.Interno_Total);
            lbltotOutro.Text = string.Format(lblformat, Program.ObjHope.Caixa.Outro_Total);
            lbltotRecebimento.Text = string.Format(lblformat, Program.ObjHope.Caixa.Recebimento_Total);
            lbltotReforco.Text = string.Format(lblformat, Program.ObjHope.Caixa.Reforco_Total);
            lbltotSangria.Text = string.Format(lblformat, Program.ObjHope.Caixa.Sangria_Total);
            lbltotValeAlimentacao.Text = string.Format(lblformat, Program.ObjHope.Caixa.Vale_Alimentacao_Total);
            lbltotValeRefeicao.Text = string.Format(lblformat, Program.ObjHope.Caixa.Vale_Refeicao_Total);
        }

        private void btnFiltarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Program.ObjHope.BackOffice.Colaborador.Consulta.Comando = Hope.Enums.Consulta_u.Comando.Select_All_From;
                iColaboradorEntcBindingSource.DataSource = Program.ObjHope.BackOffice.Colaborador.Find(Program.ObjHope.BackOffice.Colaborador.Consulta);

            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {

            bool bfocus = Program.ObjHope.BackOffice.Colaborador.SelecionaRegistro(iColaboradorEntcBindingSource.Current);
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
            try
            {
                Program.ObjHope.BackOffice.Comprador.Consulta.Comando = Hope.Enums.Consulta_u.Comando.Select_All_From;
                iCompradorEntcBindingSource.DataSource = Program.ObjHope.BackOffice.Comprador.Find(Program.ObjHope.BackOffice.Comprador.Consulta);
            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.BackOffice.Comprador.SelecionaRegistro(iCompradorEntcBindingSource.Current))
            {
                View.CompradorAlterar clienteAlterar = new View.CompradorAlterar();
                clienteAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(clienteAlterar);
            }
            else
            {
                MessageBox.Show(Program.ObjHope.BackOffice.Comprador.Informacao.ToMessageBox());
            }
        }
        private void btnFiltarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Program.ObjHope.BackOffice.Comprador.Consulta.Comando = Hope.Enums.Consulta_u.Comando.Select_All_From;
                iProdutoEntcBindingSource.DataSource = Program.ObjHope.BackOffice.Comprador.Find(Program.ObjHope.BackOffice.Comprador.Consulta);
            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.BackOffice.Produto.SelecionaRegistro((object)dgvListaProduto.SelectedRows))
            {
                View.ProdutoAlterar produtoAlterar = new View.ProdutoAlterar();
                produtoAlterar.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                ExibicaoAcao(produtoAlterar);

            }
            else
            {
                MessageBox.Show(Program.ObjHope.BackOffice.Produto.Informacao.ToMessageBox());
            }
        }

        private void btnDetalheCaixaSelecionado_Click(object sender, EventArgs e)
        {
            if (dgvListaCaixa.SelectedRows.Count != 0)
            {

                bool vselec = Program.ObjHope.Caixa.DetalheValorTotalRegistro(iCaixaEntcBindingSource.Current, out Hope.Entidade.ICaixaTotal_Ent_c Totais);
                if (vselec)
                {
                    View.CaixaDetalhe caixaDetalhe = new View.CaixaDetalhe();
                    caixaDetalhe.LoadICaixaTotal(Totais);
                    caixaDetalhe.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                    ExibicaoAcao(caixaDetalhe);
                }
                else
                {
                    MessageBox.Show(Program.ObjHope.BackOffice.Produto.Informacao.ToMessageBox());

                }
            }
        }

        private void btnFiltarCaixa_Click(object sender, EventArgs e)
        {
            bool vfiltro = Program.ObjHope.Caixa.Localizar(Comando: cmbComandoConsultaCaixa.Text, Coluna: cmbColunaConsultaCaixa.Text, Orden: cmbOrdenConusltaCaixa.Text, Limit: numLimitConsultaCaixa.Value, Termo: txtTermoCaixa.Text, ListaResultado: out Hope.Entidade.ICaixa_Ent_c[] registro);
            if (vfiltro)
            {
                iCaixaEntcBindingSource.DataSource = registro;
            }
            else
            {
                MessageBox.Show(Program.ObjHope.BackOffice.Produto.Informacao.ToMessageBox());

            }
        }

        private void btnNovoRegistroVenda_Click(object sender, EventArgs e)
        {
            bool vinicia = Program.ObjHope.Vender.NovoRegistro();

        }

        private void btnCupomFechar_Click(object sender, EventArgs e)
        {
            bool vinicia = Program.ObjHope.Vender.FinalizarRegistro();

        }

        private void btnVenderFiltraLista_Click(object sender, EventArgs e)
        {
            bool vfiltro = Program.ObjHope.Vender.Localizar(Comando: cmbComandoConsultaCupom.Text, Coluna: cmbColunaConsultaCupom.Text, Orden: cmbOrdenConsultaCupom.Text, Limit: numLimitConsultaCupom.Value, Termo: txtTermoCupom.Text, ListaRegistro: out Hope.Entidade.IVender_Ent_c[] listaresgistro);
            if (vfiltro)
            {
                iVenderEntcBindingSource.DataSource = listaresgistro;
            }
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
            Program.ObjHope.Autenticacao.Logout();
            btnLogouf.Enabled = Program.ObjHope.Autenticacao.Autenticado;
            btnLogin.Enabled = !Program.ObjHope.Autenticacao.Autenticado;
        }
    }
}
