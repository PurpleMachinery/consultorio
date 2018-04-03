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
    public partial class frmDirecionar : Form
    {
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=tbdsii;Data Source=(local)");
        public frmDirecionar()
        {
            InitializeComponent();
        }

        private void cmbMedico_Click(object sender, EventArgs e)
        {
            cmbMedico.Items.Clear();
            String sql = "select nome from medicos";
            var nomes = new List<String>();
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            using (var reader = comando.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    cmbMedico.Items.Add("" + reader.GetString(0));
                }
            }
            cmbMedico.Enabled = true;
            conn.Close();
        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            listExistente.Items.Clear();
            String sql = "select nome from especialidades";
            var nomes = new List<String>();
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            using (var reader = comando.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    listExistente.Items.Add("" + reader.GetString(0));
                }
            }
            cmbMedico.Enabled = true;
            conn.Close();


            listMedico.Items.Clear();
            String sql2 = "select nome from especialidades";
            SqlCommand comando2 = new SqlCommand(sql2, conn);
            conn.Open();
            using (var reader = comando.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    listExistente.Items.Add("" + reader.GetString(0));
                }
            }
            cmbMedico.Enabled = true;
            conn.Close();
        }
    }
}
