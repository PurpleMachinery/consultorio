using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta tt = new frmConsulta();
            tt.MdiParent = this;
            tt.Show();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro tt = new frmCadastro();
            tt.MdiParent = this;
            tt.Show();
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecialidade tt = new frmEspecialidade();
            tt.MdiParent = this;
            tt.Show();
        }

        private void registrarEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirecionar tt = new frmDirecionar();
            tt.MdiParent = this;
            tt.Show();
        }
    }
}
