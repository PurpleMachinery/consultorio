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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.txtRM.Enabled = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Medico")
            {
                this.txtRM.Enabled = true;
            }
            else
            {
                this.txtRM.Text = "";
                this.txtRM.Enabled = false;
            }
        }
    }
}
