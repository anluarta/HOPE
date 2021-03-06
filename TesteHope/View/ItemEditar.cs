﻿using System;
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
        Hope.Interface.IItem_e Item_Ativo;
        public ItemEditar()
        {
            InitializeComponent();
        }
        public ItemEditar(Hope.Interface.IItem_e item) : this()
        {
            txtDescricao.Text = item.Get_Descricao;
            txtQuantidade.Text = item.Get_Quantidade.ToString();
            txtSubTotal.Text = item.Get_Sub_Total.ToString();
            txtUnidade.Text = item.Get_Unidade;
            txtVenda.Text = item.Get_Venda.ToString();
            Item_Ativo = item;
        }

        private void btngravar_Click(object sender, EventArgs e)
        {

            bool v1 = Item_Ativo.Set_Descricao(descricao: txtDescricao.Text);
            bool v2 = Item_Ativo.Set_Unidade(descricao: txtUnidade.Text);
            bool v3 = Item_Ativo.Set_Quantidade(descricao: txtQuantidade.Text);
            bool v4 = Item_Ativo.Set_Venda(descricao: txtVenda.Text);
            if (v1 & v2 & v3 & v4)
            {
                bool v5 = Program.Vender.Update(Item_Ativo);
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
                lblResultado.Text = Item_Ativo.Notifica();
            }
        }
    }
}
