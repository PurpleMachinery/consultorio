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
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=tbdsii;Data Source=(local)");
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
            String sql = "";
            if (cmbTipo.Text == "" || txtCPF.Text == "" || txtEndereco.Text == "" || txtNasc.Text == "" || txtNome.Text == "" || txtTel.Text == "" || (rbtFem.Checked==true||rbtMasc.Checked==false)) 
            {
                MessageBox.Show("Algum campo está vazio", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }
            char sexoo = 'N';
            if(rbtFem.Checked==true)
            {
                sexoo = 'f';
            }
            else if (rbtMasc.Checked == true)
            {
                sexoo = 'm';
            }
            if (cmbTipo.Text == "Medico")
            {
                sql = "insert into medicos (nome, cpf, nascimento, sexo, telefone, endereco, registroMedicina) values ('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtNasc.Text + "','" + sexoo + "','" + txtTel.Text + "','" + txtEndereco.Text + "','" + txtRM.Text + "');";
            }
            else if (cmbTipo.Text == "Atendente" )
            {
                sql = "insert into atendentes (nome, cpf, nascimento, sexo, telefone, endereco) values ('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtNasc.Text + "','" + sexoo + "','" + txtTel.Text + "','" + txtEndereco.Text + "');";
            }
            else if (cmbTipo.Text == "Paciente")
            {
                sql = "insert into pacientes (nome, cpf, nascimento, sexo, telefone, endereco) values ('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtNasc.Text + "','" + sexoo + "','" + txtTel.Text + "','" + txtEndereco.Text + "');";
            }
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
