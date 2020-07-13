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
    public partial class UsuarioListaRegistro : UserControl
    {
        public UsuarioListaRegistro()
        {
            InitializeComponent();
            cmbLocal.Items.AddRange(Program.ObjHope.GetUsuarioLocalConsulta());
            cmbOperacao.Items.AddRange(Program.ObjHope.GetOperacaoConsulta());
            cmbOrdenar.Items.AddRange(Program.ObjHope.GetOrden());
        }
        private void btnFiltar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.Localizar(_orden: cmbOrdenar.SelectedItem.ToString(),_operacao: cmbOperacao.SelectedItem.ToString(),_local: cmbLocal.SelectedItem.ToString(),_limit:0,_termo: txtTermo.Text))
            {
                iUsuarioBindingSource.DataSource = Program.ObjHope.Usuario.DadoResultado;

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Program.ObjHope.Usuario.FocusRegistro((object)dgvListaUsuario.SelectedRows))
            {
                View.UsuarioAlteraRegistro usuarioAltera = new UsuarioAlteraRegistro();
                using (frmControlUser frm= new frmControlUser())
                {
                    usuarioAltera.btnVoltar.Click += new EventHandler(frm.BtnVoltar);
                    usuarioAltera.Dock = DockStyle.Fill;
                    frm.Controls.Add(usuarioAltera);
                    frm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show(Program.ObjHope.Usuario.StrMsgResult);
            }
        }
    }
}
