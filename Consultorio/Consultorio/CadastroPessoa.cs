using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Consultorio
{
    public partial class frmCadastro : Form
    {
        SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=dsii;User Id=sa;Password=info211;");
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
            String sql = "insert into pessoas (nome, cpf, nascimento, sexo, telefone, endereco) values ('wesley', '49004232893', '2018-08-08', '958192633','av teste')";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
