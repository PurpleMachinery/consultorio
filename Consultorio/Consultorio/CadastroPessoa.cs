using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Consultorio
{
    public partial class frmCadastro : Form
    {
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=dsii;Data Source=LAB-06-06");
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            SqlConnection sqlConnection1 = new SqlConnection("");
            String sql = "insert into pessoas (nome, cpf, nascimento, sexo, telefone, endereco) values ('wesley', '49004232893', '01-01-2018', 'm', '958192633', 'av va');";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
