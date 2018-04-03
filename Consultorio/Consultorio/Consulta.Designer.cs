namespace Consultorio
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.lblIdAtendente = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbEspecialidae = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.brnAgendar = new System.Windows.Forms.Button();
            this.cmbAtendente = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.mtxbData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Location = new System.Drawing.Point(13, 56);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblIdPaciente.TabIndex = 0;
            this.lblIdPaciente.Text = "Paciente";
            // 
            // lblIdAtendente
            // 
            this.lblIdAtendente.AutoSize = true;
            this.lblIdAtendente.Location = new System.Drawing.Point(12, 28);
            this.lblIdAtendente.Name = "lblIdAtendente";
            this.lblIdAtendente.Size = new System.Drawing.Size(56, 13);
            this.lblIdAtendente.TabIndex = 1;
            this.lblIdAtendente.Text = "Atendente";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(12, 84);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(73, 13);
            this.lblEspecialidade.TabIndex = 2;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(13, 137);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // cmbEspecialidae
            // 
            this.cmbEspecialidae.FormattingEnabled = true;
            this.cmbEspecialidae.Location = new System.Drawing.Point(112, 81);
            this.cmbEspecialidae.Name = "cmbEspecialidae";
            this.cmbEspecialidae.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidae.TabIndex = 8;
            this.cmbEspecialidae.Click += new System.EventHandler(this.cmbEspecialidae_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medico";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(112, 109);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbMedico.TabIndex = 10;
            // 
            // brnAgendar
            // 
            this.brnAgendar.Location = new System.Drawing.Point(59, 180);
            this.brnAgendar.Name = "brnAgendar";
            this.brnAgendar.Size = new System.Drawing.Size(140, 32);
            this.brnAgendar.TabIndex = 12;
            this.brnAgendar.Text = "Agendar";
            this.brnAgendar.UseVisualStyleBackColor = true;
            // 
            // cmbAtendente
            // 
            this.cmbAtendente.FormattingEnabled = true;
            this.cmbAtendente.Location = new System.Drawing.Point(112, 28);
            this.cmbAtendente.Name = "cmbAtendente";
            this.cmbAtendente.Size = new System.Drawing.Size(121, 21);
            this.cmbAtendente.TabIndex = 16;
            this.cmbAtendente.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(112, 56);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 17;
            this.cmbPaciente.Click += new System.EventHandler(this.cmbPaciente_Click_1);
            // 
            // mtxbData
            // 
            this.mtxbData.Location = new System.Drawing.Point(112, 137);
            this.mtxbData.Mask = "00/00/0000 90:00";
            this.mtxbData.Name = "mtxbData";
            this.mtxbData.Size = new System.Drawing.Size(121, 20);
            this.mtxbData.TabIndex = 18;
            this.mtxbData.ValidatingType = typeof(System.DateTime);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 223);
            this.Controls.Add(this.mtxbData);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.cmbAtendente);
            this.Controls.Add(this.brnAgendar);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEspecialidae);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblIdAtendente);
            this.Controls.Add(this.lblIdPaciente);
            this.Name = "frmConsulta";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Label lblIdAtendente;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbEspecialidae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Button brnAgendar;
        private System.Windows.Forms.ComboBox cmbAtendente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.MaskedTextBox mtxbData;
    }
}