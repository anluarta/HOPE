using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteHope.View
{
    public partial class ItemEditar : UserControl
    {
        public ItemEditar()
        {
            InitializeComponent();
        }
        public ItemEditar(Hope.Interface.IItem_e item):this()
        {
            txtDescricao.Text = item.Get_Descricao;
            txtQuantidade.Text = item.Get_Quantidade;
            txtSubTotal.Text = item.Get_Sub_Total;
            txtUnidade.Text = item.Get_Unidade;
            txtVenda.Text = item.Get_Venda;

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Hope.Interface.IItem_e entidade = Program.ObjHope.Pos.Vender.Items(Program.Vender);
            bool v1 = entidade.Set_Descricao(descricao: txtDescricao.Text);
            bool v2 = entidade.Set_Unidade(descricao: txtDescricao.Text);
            bool v3 = entidade.Set_Quantidade(descricao: txtDescricao.Text);
            bool v4 = entidade.Set_Venda(descricao: txtDescricao.Text);
            if (v1&v2&v3&v4)
            {
                bool v5 = Program.Vender.Add(entidade);
                if (v5)
                {
                    bool v6 = Program.ObjHope.Pos.Vender.Gravar(Program.Vender);
                    if (v6)
                    {
                        MessageBox.Show(Program.ObjHope.Pos.Vender.Notificar());
                        btnfechar.PerformClick();
                    }
                    else
                    {
                        lblResultado.Text = Program.ObjHope.Pos.Vender.Notificar();
                    }
                }
                else
                {
                    lblResultado.Text = Program.Vender.Notifica();
                }
            }
            else
            {
                lblResultado.Text = entidade.Notifica();
            }
        }
    }
}
