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
    public partial class frmConsulta : Form
    {
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=tbdsii;Data Source=(local)");
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            mtxbData.Text = System.DateTime.Now.ToShortDateString() + System.DateTime.Now.ToShortTimeString();
            cmbMedico.Enabled = false;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            cmbAtendente.Items.Clear();
            String sql = "select nome from atendentes";
            var nomes = new List<String>();
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            using (var reader = comando.ExecuteReader())
            {
                for (int i = 0; reader.Read();i++ )
                {
                    cmbAtendente.Items.Add("" + reader.GetString(0));
                }
            }
            conn.Close();
        }

        private void cmbPaciente_Click_1(object sender, EventArgs e)
        {
            cmbAtendente.Items.Clear();
            String sql = "select nome from pacientes";
            var nomes = new List<String>();
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            using (var reader = comando.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    cmbPaciente.Items.Add("" + reader.GetString(0));
                }
            }
            conn.Close();
        }

        private void cmbEspecialidae_Click(object sender, EventArgs e)
        {
            cmbAtendente.Items.Clear();
            String sql = "select nome from especialidades";
            var nomes = new List<String>();
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            using (var reader = comando.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    cmbEspecialidae.Items.Add("" + reader.GetString(0));
                }
            }
            cmbMedico.Enabled = true;
            conn.Close();
        }
    }
}
