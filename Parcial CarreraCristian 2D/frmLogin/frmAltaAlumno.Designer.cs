namespace frmLogin
{
    partial class frmAltaAlumno
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtLegajoAlumno = new System.Windows.Forms.TextBox();
            this.txtPrecioCuotaAlumno = new System.Windows.Forms.TextBox();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.rbFemeninoAlumno = new System.Windows.Forms.RadioButton();
            this.rbMasculinoAlumno = new System.Windows.Forms.RadioButton();
            this.txtApellidoResponsable = new System.Windows.Forms.TextBox();
            this.txtDniResponsable = new System.Windows.Forms.TextBox();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbMasculinoResponsable = new System.Windows.Forms.RadioButton();
            this.rbFeemeninoResponsable = new System.Windows.Forms.RadioButton();
            this.txtNumeroResponsable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxParentesco = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Legajo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio Cuota:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datos del responsable:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(54, 6);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(97, 20);
            this.txtNombreAlumno.TabIndex = 8;
            this.txtNombreAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAlumno_KeyPress);
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(54, 57);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(97, 20);
            this.txtDniAlumno.TabIndex = 9;
            this.txtDniAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniAlumno_KeyPress);
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(54, 32);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(97, 20);
            this.txtApellidoAlumno.TabIndex = 10;
            this.txtApellidoAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoAlumno_KeyPress);
            // 
            // txtLegajoAlumno
            // 
            this.txtLegajoAlumno.Location = new System.Drawing.Point(232, 69);
            this.txtLegajoAlumno.Name = "txtLegajoAlumno";
            this.txtLegajoAlumno.Size = new System.Drawing.Size(107, 20);
            this.txtLegajoAlumno.TabIndex = 11;
            this.txtLegajoAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajoAlumno_KeyPress);
            // 
            // txtPrecioCuotaAlumno
            // 
            this.txtPrecioCuotaAlumno.Location = new System.Drawing.Point(232, 43);
            this.txtPrecioCuotaAlumno.Name = "txtPrecioCuotaAlumno";
            this.txtPrecioCuotaAlumno.Size = new System.Drawing.Size(107, 20);
            this.txtPrecioCuotaAlumno.TabIndex = 13;
            this.txtPrecioCuotaAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCuotaAlumno_KeyPress);
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(235, 208);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(106, 21);
            this.btnGuardarAlumno.TabIndex = 15;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // rbFemeninoAlumno
            // 
            this.rbFemeninoAlumno.AutoSize = true;
            this.rbFemeninoAlumno.Checked = true;
            this.rbFemeninoAlumno.Location = new System.Drawing.Point(20, 16);
            this.rbFemeninoAlumno.Name = "rbFemeninoAlumno";
            this.rbFemeninoAlumno.Size = new System.Drawing.Size(71, 17);
            this.rbFemeninoAlumno.TabIndex = 16;
            this.rbFemeninoAlumno.TabStop = true;
            this.rbFemeninoAlumno.Text = "Femenino";
            this.rbFemeninoAlumno.UseVisualStyleBackColor = true;
            // 
            // rbMasculinoAlumno
            // 
            this.rbMasculinoAlumno.AutoSize = true;
            this.rbMasculinoAlumno.Location = new System.Drawing.Point(111, 16);
            this.rbMasculinoAlumno.Name = "rbMasculinoAlumno";
            this.rbMasculinoAlumno.Size = new System.Drawing.Size(71, 17);
            this.rbMasculinoAlumno.TabIndex = 17;
            this.rbMasculinoAlumno.Text = "Masculno";
            this.rbMasculinoAlumno.UseVisualStyleBackColor = true;
            // 
            // txtApellidoResponsable
            // 
            this.txtApellidoResponsable.Location = new System.Drawing.Point(54, 157);
            this.txtApellidoResponsable.Name = "txtApellidoResponsable";
            this.txtApellidoResponsable.Size = new System.Drawing.Size(97, 20);
            this.txtApellidoResponsable.TabIndex = 23;
            this.txtApellidoResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoResponsable_KeyPress);
            // 
            // txtDniResponsable
            // 
            this.txtDniResponsable.Location = new System.Drawing.Point(54, 182);
            this.txtDniResponsable.Name = "txtDniResponsable";
            this.txtDniResponsable.Size = new System.Drawing.Size(97, 20);
            this.txtDniResponsable.TabIndex = 22;
            this.txtDniResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniResponsable_KeyPress);
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.Location = new System.Drawing.Point(54, 131);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(97, 20);
            this.txtNombreResponsable.TabIndex = 21;
            this.txtNombreResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreResponsable_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "DNI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre:";
            // 
            // rbMasculinoResponsable
            // 
            this.rbMasculinoResponsable.AutoSize = true;
            this.rbMasculinoResponsable.Location = new System.Drawing.Point(112, 19);
            this.rbMasculinoResponsable.Name = "rbMasculinoResponsable";
            this.rbMasculinoResponsable.Size = new System.Drawing.Size(71, 17);
            this.rbMasculinoResponsable.TabIndex = 25;
            this.rbMasculinoResponsable.Text = "Masculno";
            this.rbMasculinoResponsable.UseVisualStyleBackColor = true;
            // 
            // rbFeemeninoResponsable
            // 
            this.rbFeemeninoResponsable.AutoSize = true;
            this.rbFeemeninoResponsable.Checked = true;
            this.rbFeemeninoResponsable.Location = new System.Drawing.Point(21, 19);
            this.rbFeemeninoResponsable.Name = "rbFeemeninoResponsable";
            this.rbFeemeninoResponsable.Size = new System.Drawing.Size(71, 17);
            this.rbFeemeninoResponsable.TabIndex = 24;
            this.rbFeemeninoResponsable.TabStop = true;
            this.rbFeemeninoResponsable.Text = "Femenino";
            this.rbFeemeninoResponsable.UseVisualStyleBackColor = true;
            // 
            // txtNumeroResponsable
            // 
            this.txtNumeroResponsable.Location = new System.Drawing.Point(54, 208);
            this.txtNumeroResponsable.Name = "txtNumeroResponsable";
            this.txtNumeroResponsable.Size = new System.Drawing.Size(97, 20);
            this.txtNumeroResponsable.TabIndex = 27;
            this.txtNumeroResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroResponsable_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Telefono:";
            // 
            // comboBoxParentesco
            // 
            this.comboBoxParentesco.FormattingEnabled = true;
            this.comboBoxParentesco.Location = new System.Drawing.Point(220, 157);
            this.comboBoxParentesco.Name = "comboBoxParentesco";
            this.comboBoxParentesco.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParentesco.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Parentesco:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasculinoAlumno);
            this.groupBox1.Controls.Add(this.rbFemeninoAlumno);
            this.groupBox1.Location = new System.Drawing.Point(157, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 38);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo alumno";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMasculinoResponsable);
            this.groupBox2.Controls.Add(this.rbFeemeninoResponsable);
            this.groupBox2.Location = new System.Drawing.Point(157, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 41);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo responsable";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Color:";
            // 
            // frmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 244);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxParentesco);
            this.Controls.Add(this.txtNumeroResponsable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtApellidoResponsable);
            this.Controls.Add(this.txtDniResponsable);
            this.Controls.Add(this.txtNombreResponsable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.txtPrecioCuotaAlumno);
            this.Controls.Add(this.txtLegajoAlumno);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de alumno";
            this.Load += new System.EventHandler(this.frmAltaAlumno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtLegajoAlumno;
        private System.Windows.Forms.TextBox txtPrecioCuotaAlumno;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.RadioButton rbFemeninoAlumno;
        private System.Windows.Forms.RadioButton rbMasculinoAlumno;
        private System.Windows.Forms.TextBox txtApellidoResponsable;
        private System.Windows.Forms.TextBox txtDniResponsable;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbMasculinoResponsable;
        private System.Windows.Forms.RadioButton rbFeemeninoResponsable;
        private System.Windows.Forms.TextBox txtNumeroResponsable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxParentesco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
    }
}