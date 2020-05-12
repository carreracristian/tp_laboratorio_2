namespace frmLogin
{
    partial class frmBusquedaDeAlumno
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
            this.BtnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBuscarAlumno
            // 
            this.BtnBuscarAlumno.Location = new System.Drawing.Point(231, 6);
            this.BtnBuscarAlumno.Name = "BtnBuscarAlumno";
            this.BtnBuscarAlumno.Size = new System.Drawing.Size(74, 20);
            this.BtnBuscarAlumno.TabIndex = 0;
            this.BtnBuscarAlumno.Text = "Buscar";
            this.BtnBuscarAlumno.UseVisualStyleBackColor = true;
            this.BtnBuscarAlumno.Click += new System.EventHandler(this.BtnBuscarAlumno_Click);
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(113, 6);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba el apellido:";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(113, 43);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(191, 21);
            this.cmbAlumnos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alumno/as:";
            // 
            // frmBusquedaDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 89);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.BtnBuscarAlumno);
            this.Name = "frmBusquedaDeAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar alumno por apellido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.Label label2;
    }
}