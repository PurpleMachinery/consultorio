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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            mtxbData.Text = System.DateTime.Now.ToShortDateString() + System.DateTime.Now.ToShortTimeString();
            cmbMedico.Enabled = false;
        }
    }
}
