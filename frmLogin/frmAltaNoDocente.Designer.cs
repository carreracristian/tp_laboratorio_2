namespace frmLogin
{
    partial class frmAltaNoDocente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreAltaNoDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoAltaNoDocente = new System.Windows.Forms.TextBox();
            this.txtDniAltaNoDocente = new System.Windows.Forms.TextBox();
            this.comboBoxEcargo = new System.Windows.Forms.ComboBox();
            this.txtHoraIngresoNoDocente = new System.Windows.Forms.TextBox();
            this.txtHoraSalidaNoDocente = new System.Windows.Forms.TextBox();
            this.GuardarNoDocente = new System.Windows.Forms.Button();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora Ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora Egreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cargo:";
            // 
            // txtNombreAltaNoDocente
            // 
            this.txtNombreAltaNoDocente.Location = new System.Drawing.Point(54, 12);
            this.txtNombreAltaNoDocente.Name = "txtNombreAltaNoDocente";
            this.txtNombreAltaNoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAltaNoDocente.TabIndex = 8;
            this.txtNombreAltaNoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAltaNoDocente_KeyPress);
            // 
            // txtApellidoAltaNoDocente
            // 
            this.txtApellidoAltaNoDocente.Location = new System.Drawing.Point(54, 42);
            this.txtApellidoAltaNoDocente.Name = "txtApellidoAltaNoDocente";
            this.txtApellidoAltaNoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAltaNoDocente.TabIndex = 9;
            this.txtApellidoAltaNoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoAltaNoDocente_KeyPress);
            // 
            // txtDniAltaNoDocente
            // 
            this.txtDniAltaNoDocente.Location = new System.Drawing.Point(36, 75);
            this.txtDniAltaNoDocente.Name = "txtDniAltaNoDocente";
            this.txtDniAltaNoDocente.Size = new System.Drawing.Size(118, 20);
            this.txtDniAltaNoDocente.TabIndex = 10;
            this.txtDniAltaNoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniAltaNoDocente_KeyPress);
            // 
            // comboBoxEcargo
            // 
            this.comboBoxEcargo.FormattingEnabled = true;
            this.comboBoxEcargo.Location = new System.Drawing.Point(200, 75);
            this.comboBoxEcargo.Name = "comboBoxEcargo";
            this.comboBoxEcargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEcargo.TabIndex = 12;
            // 
            // txtHoraIngresoNoDocente
            // 
            this.txtHoraIngresoNoDocente.Location = new System.Drawing.Point(234, 10);
            this.txtHoraIngresoNoDocente.Name = "txtHoraIngresoNoDocente";
            this.txtHoraIngresoNoDocente.Size = new System.Drawing.Size(85, 20);
            this.txtHoraIngresoNoDocente.TabIndex = 13;
            this.txtHoraIngresoNoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraIngresoNoDocente_KeyPress);
            // 
            // txtHoraSalidaNoDocente
            // 
            this.txtHoraSalidaNoDocente.Location = new System.Drawing.Point(234, 42);
            this.txtHoraSalidaNoDocente.Name = "txtHoraSalidaNoDocente";
            this.txtHoraSalidaNoDocente.Size = new System.Drawing.Size(87, 20);
            this.txtHoraSalidaNoDocente.TabIndex = 14;
            this.txtHoraSalidaNoDocente.TextChanged += new System.EventHandler(this.txtHoraSalidaNoDocente_TextChanged);
            this.txtHoraSalidaNoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraSalidaNoDocente_KeyPress);
            // 
            // GuardarNoDocente
            // 
            this.GuardarNoDocente.Location = new System.Drawing.Point(167, 109);
            this.GuardarNoDocente.Name = "GuardarNoDocente";
            this.GuardarNoDocente.Size = new System.Drawing.Size(152, 20);
            this.GuardarNoDocente.TabIndex = 15;
            this.GuardarNoDocente.Text = "Guardar";
            this.GuardarNoDocente.UseVisualStyleBackColor = true;
            this.GuardarNoDocente.Click += new System.EventHandler(this.GuardarNoDocente_Click);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(36, 101);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 16;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(36, 124);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 17;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // frmAltaNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 151);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.GuardarNoDocente);
            this.Controls.Add(this.txtHoraSalidaNoDocente);
            this.Controls.Add(this.txtHoraIngresoNoDocente);
            this.Controls.Add(this.comboBoxEcargo);
            this.Controls.Add(this.txtDniAltaNoDocente);
            this.Controls.Add(this.txtApellidoAltaNoDocente);
            this.Controls.Add(this.txtNombreAltaNoDocente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaNoDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de administrativo";
            this.Load += new System.EventHandler(this.frmAltaNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreAltaNoDocente;
        private System.Windows.Forms.TextBox txtApellidoAltaNoDocente;
        private System.Windows.Forms.TextBox txtDniAltaNoDocente;
        private System.Windows.Forms.ComboBox comboBoxEcargo;
        private System.Windows.Forms.TextBox txtHoraIngresoNoDocente;
        private System.Windows.Forms.TextBox txtHoraSalidaNoDocente;
        private System.Windows.Forms.Button GuardarNoDocente;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
    }
}