using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TesteHope.View
{
    public partial class Vender : UserControl
    {
        const string _index = "Index {0}";
        const string _vendedor = "vendedor {0}";
        const string _id_caixa = "ID Caixa {0}";
        const string _finalizado = "Finalizado {0}";
        const string _recebido = "Recebido R$ {0}";
        const string _desconto = "Desconto R$ {0}";
        const string _troco = "Troco R$ {0}";
        const string _total_venda = "Total Venda R$ {0}";
        public Vender()
        {
            InitializeComponent();
            atualizarvalor();
        }
        void atualizarvalor()
        {
            lblColaborador.Text = string.Format(_vendedor, Program.Vender.Get_Nome_Vendedor);
            lblFinalizado.Text = string.Format(_finalizado, Program.Vender.Get_Finish_Time);
            lblIdCaixa.Text = string.Format(_id_caixa, Program.Vender.Get_ID_Caixa);
            lblIndex.Text = string.Format(_index, Program.Vender.Get_ID);
            lblTotalVenda.Text = string.Format(_total_venda, Program.Vender.Get_Valor_Total);
            iItemeBindingSource.DataSource = Program.Vender.GetDataByItem();
            lblRecebido.Text = string.Format(_recebido, Program.Vender.Get_Valor_Recebido);
            lblTroco.Text = string.Format(_troco, Program.Vender.Get_Valor_Troco);
            lblDesconto.Text = string.Format(_desconto, Program.Vender.Get_Valor_Desconto);
            lblRecebido.Text = string.Format(_recebido, Program.Vender.Get_Valor_Recebido);
            lblTroco.Text = string.Format(_troco, Program.Vender.Get_Valor_Troco);
            lblDesconto.Text = string.Format(_desconto, Program.Vender.Get_Valor_Desconto);
        }

        private void btnItemAdicionar_Click(object sender, EventArgs e)
        {
            using (frmViewControlSecundario frm = new frmViewControlSecundario())
            {
                View.ItemAdd itemAdd = new View.ItemAdd();
                itemAdd.Dock = DockStyle.Fill;
                itemAdd.btnfechar.Click += new EventHandler(frm.btnfechar);
                frm.Controls.Add(itemAdd);
                frm.ShowDialog();
            }
            atualizarvalor();

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            using (frmViewControlSecundario frm = new frmViewControlSecundario())
            {
                Pagamento pagamento = new Pagamento();
                pagamento.Dock = DockStyle.Fill;
                pagamento.btnfechar.Click += new EventHandler(frm.btnfechar);
                frm.Controls.Add(pagamento);
                frm.ShowDialog();
            }
            atualizarvalor();

        }

        private void btnItemEditar_Click(object sender, EventArgs e)
        {
            bool retor = false;
            Hope.Interface.IItem_e entidade = null;
            try
            {
                retor = Program.Vender.SelectItem(iItemeBindingSource.Current, out entidade);
            }
            catch (Hope.HException_c he)
            {
                MessageBox.Show(he.Message);
            }
            if (retor)
            {
                using (frmViewControlSecundario frm = new frmViewControlSecundario())
                {
                    ItemEditar editar = new ItemEditar(entidade);
                    editar.Dock = DockStyle.Fill;
                    editar.btnfechar.Click += new EventHandler(frm.btnfechar);
                    frm.Controls.Add(editar);
                    frm.ShowDialog();
                }
                atualizarvalor();

            }
            else
            {
                lblresultado.Text = Program.Vender.Notifica();
            }
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            bool v1 = Program.Vender.Finalizar();
            if (v1)
            {
                bool v2 = Program.CaixaOperacao.Add(Program.Vender);
                if (v2)
                {
                    bool v3 = Program.ObjHope.Pos.Vender.Gravar(Program.Vender);
                    if (v3)
                    {
                        MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
                        btnfechar.PerformClick();

                    }
                    else
                    {

                        lblresultado.Text = Program.ObjHope.Pos.Vender.Notificar();
                    }
                }
                else
                {
                    lblresultado.Text = Program.CaixaOperacao.Notifica();

                }
            }
            else
            {
                lblresultado.Text = Program.Vender.Notifica();
            }
        }
    }
}
