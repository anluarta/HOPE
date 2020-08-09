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
        public Vender()
        {
            InitializeComponent();
        }
        void atualizarvalor()
        {
            lblColaborador.Text = string.Format(lblColaborador.Text, Program.Vender.Get_Colaborador);
            lblFinalizado.Text = string.Format(lblFinalizado.Text, Program.Vender.Get_Finish);
            lblIdCaixa.Text = string.Format(lblIdCaixa.Text, Program.Vender.Get_ID_Caixa);
            lblIndex.Text = string.Format(lblIndex.Text, Program.Vender.Get_ID);
            lblTotalVenda.Text = Program.Vender.Get_Valor_Total;
            iItemeBindingSource.DataSource = Program.Vender.GetDataByItem();
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
            iItemeBindingSource.DataSource = Program.Vender.GetDataByItem();
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
            lblRecebido.Text = Program.Vender.Get_Valor_Recebido;
            lblTroco.Text = Program.Vender.Get_Valor_Troco;
            lblDesconto.Text = Program.Vender.Get_Valor_Desconto;
        }

        private void btnItemEditar_Click(object sender, EventArgs e)
        {
            Hope.Interface.IItem_e entidade = null;
            try
            {
                entidade = Program.Vender.SelectItem(iItemeBindingSource.Current);
            }
            catch (Hope.HException_c he)
            {
                MessageBox.Show(he.Message);
            }
            using (frmViewControlSecundario frm = new frmViewControlSecundario())
            {
                View.ItemEditar editar = new ItemEditar(entidade);
                editar.Dock = DockStyle.Fill;
                editar.btnfechar.Click += new EventHandler(frm.btnfechar);
                frm.Controls.Add(editar);
                frm.ShowDialog();
            }
            iItemeBindingSource.DataSource = Program.Vender.GetDataByItem();
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            bool v1 = Program.Vender.Finalizar();
            if (v1)
            {
                bool v2 = Program.ObjHope.Pos.Vender.Gravar(Program.Vender);
                if (v2)
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
                lblresultado.Text = Program.Vender.Notifica();
            }
        }
    }
}
