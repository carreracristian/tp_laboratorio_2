namespace frmLogin
{
    partial class frmAltaDocente
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
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoDocente = new System.Windows.Forms.TextBox();
            this.txtDniDocente = new System.Windows.Forms.TextBox();
            this.txtHoraSalidaDocente = new System.Windows.Forms.TextBox();
            this.txtValorHoraDocente = new System.Windows.Forms.TextBox();
            this.btnGuardarDocente = new System.Windows.Forms.Button();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtHoraIngresoDocente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora salida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor de hora:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(52, 7);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(92, 20);
            this.txtNombreDocente.TabIndex = 8;
            this.txtNombreDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDocente_KeyPress);
            // 
            // txtApellidoDocente
            // 
            this.txtApellidoDocente.Location = new System.Drawing.Point(52, 36);
            this.txtApellidoDocente.Name = "txtApellidoDocente";
            this.txtApellidoDocente.Size = new System.Drawing.Size(92, 20);
            this.txtApellidoDocente.TabIndex = 9;
            this.txtApellidoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoDocente_KeyPress);
            // 
            // txtDniDocente
            // 
            this.txtDniDocente.Location = new System.Drawing.Point(201, 90);
            this.txtDniDocente.Name = "txtDniDocente";
            this.txtDniDocente.Size = new System.Drawing.Size(110, 20);
            this.txtDniDocente.TabIndex = 10;
            this.txtDniDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniDocente_KeyPress);
            // 
            // txtHoraSalidaDocente
            // 
            this.txtHoraSalidaDocente.Location = new System.Drawing.Point(231, 36);
            this.txtHoraSalidaDocente.Name = "txtHoraSalidaDocente";
            this.txtHoraSalidaDocente.Size = new System.Drawing.Size(80, 20);
            this.txtHoraSalidaDocente.TabIndex = 13;
            this.txtHoraSalidaDocente.TextChanged += new System.EventHandler(this.txtHoraSalidaDocente_TextChanged);
            this.txtHoraSalidaDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraSalidaDocente_KeyPress);
            // 
            // txtValorHoraDocente
            // 
            this.txtValorHoraDocente.Location = new System.Drawing.Point(239, 64);
            this.txtValorHoraDocente.Name = "txtValorHoraDocente";
            this.txtValorHoraDocente.Size = new System.Drawing.Size(72, 20);
            this.txtValorHoraDocente.TabIndex = 14;
            this.txtValorHoraDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHoraDocente_KeyPress);
            // 
            // btnGuardarDocente
            // 
            this.btnGuardarDocente.Location = new System.Drawing.Point(171, 116);
            this.btnGuardarDocente.Name = "btnGuardarDocente";
            this.btnGuardarDocente.Size = new System.Drawing.Size(140, 22);
            this.btnGuardarDocente.TabIndex = 15;
            this.btnGuardarDocente.Text = "Guardar Docente";
            this.btnGuardarDocente.UseVisualStyleBackColor = true;
            this.btnGuardarDocente.Click += new System.EventHandler(this.btnGuardarDocente_Click);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(52, 67);
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
            this.rbMasculino.Location = new System.Drawing.Point(52, 91);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 17;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtHoraIngresoDocente
            // 
            this.txtHoraIngresoDocente.Location = new System.Drawing.Point(237, 7);
            this.txtHoraIngresoDocente.Name = "txtHoraIngresoDocente";
            this.txtHoraIngresoDocente.Size = new System.Drawing.Size(74, 20);
            this.txtHoraIngresoDocente.TabIndex = 12;
            this.txtHoraIngresoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraIngresoDocente_KeyPress);
            // 
            // frmAltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 152);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.btnGuardarDocente);
            this.Controls.Add(this.txtValorHoraDocente);
            this.Controls.Add(this.txtHoraSalidaDocente);
            this.Controls.Add(this.txtHoraIngresoDocente);
            this.Controls.Add(this.txtDniDocente);
            this.Controls.Add(this.txtApellidoDocente);
            this.Controls.Add(this.txtNombreDocente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de docentes";
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
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtApellidoDocente;
        private System.Windows.Forms.TextBox txtDniDocente;
        private System.Windows.Forms.TextBox txtHoraSalidaDocente;
        private System.Windows.Forms.TextBox txtValorHoraDocente;
        private System.Windows.Forms.Button btnGuardarDocente;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtHoraIngresoDocente;
    }
}