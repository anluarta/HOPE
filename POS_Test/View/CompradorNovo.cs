using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Test.View
{
    public partial class CompradorNovo : UserControl
    {
        public CompradorNovo()
        {
            InitializeComponent();
            cmbTipoCliente.Items.AddRange(Program.ObjHope.ArrayTipoCliente);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Hope.Interface.IComprador_e comprador = Program.ObjHope.BackOffice.Comprador.Novo();
                bool v1 = comprador.Set_Nome_Comprador(txtNomeCompleto_Razao.Text);
                bool v2 = comprador.Set_Numero_Documento(txtCpf_Cnpj.Text);
                if (v1&v2)
                {
                    bool v3 = Program.ObjHope.BackOffice.Comprador.Gravar(comprador);
                    if (v3)
                    {
                        btnVoltar.PerformClick();
                    }
                    else
                    {
                        Program.ObjHope.BackOffice.Comprador.Notifica.Mensagem();
                    }
                }
                else
                {
                    comprador.Notifica.Mensagem();

                }


            }
            catch (Hope.HException he)
            {
                MessageBox.Show(he.Message);
            }
        }
    }
}
