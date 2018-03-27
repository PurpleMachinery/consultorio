namespace Consultorio
{
    partial class direcionarEsp
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
            this.listExistente = new System.Windows.Forms.ListBox();
            this.listMedico = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listExistente
            // 
            this.listExistente.FormattingEnabled = true;
            this.listExistente.Location = new System.Drawing.Point(25, 119);
            this.listExistente.Name = "listExistente";
            this.listExistente.Size = new System.Drawing.Size(204, 160);
            this.listExistente.TabIndex = 0;
            // 
            // listMedico
            // 
            this.listMedico.FormattingEnabled = true;
            this.listMedico.Location = new System.Drawing.Point(446, 119);
            this.listMedico.Name = "listMedico";
            this.listMedico.Size = new System.Drawing.Size(204, 160);
            this.listMedico.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "-->";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(304, 201);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<--";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(25, 55);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(190, 21);
            this.cmbMedico.TabIndex = 4;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(25, 36);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 5;
            this.lblMedico.Text = "Medico";
            // 
            // direcionarEsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 304);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listMedico);
            this.Controls.Add(this.listExistente);
            this.Name = "direcionarEsp";
            this.Text = "direcionarEsp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listExistente;
        private System.Windows.Forms.ListBox listMedico;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblMedico;
    }
}