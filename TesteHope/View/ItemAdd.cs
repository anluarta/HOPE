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
    public partial class ItemAdd : UserControl
    {
        public ItemAdd()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Pos.Vender.Item_Novo(Program.Vender, out Hope.Interface.IItem_e entidade))
            {
                bool v1 = entidade.Set_Descricao(descricao: txtDescricao.Text);
                bool v2 = entidade.Set_Unidade(descricao: txtUnidade.Text);
                bool v3 = entidade.Set_Quantidade(descricao: txtQuantidade.Text);
                bool v4 = entidade.Set_Venda(descricao: txtVenda.Text);
                if (v1 & v2 & v3 & v4)
                {
                    bool v5 = Program.Vender.Add(entidade);
                    if (v5)
                    {
                        bool v6 = Program.ObjHope.Pos.Vender.Gravar(Program.Vender);
                        if (v6)
                        {
                            var str = Program.ObjHope.Pos.Vender.Notificar();
                            if (str.Length != 0)
                            {
                                MessageBox.Show(str);
                            }
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
            else
            {
                lblResultado.Text = Program.ObjHope.Pos.Vender.Notificar();
            }
        }
    }
}
