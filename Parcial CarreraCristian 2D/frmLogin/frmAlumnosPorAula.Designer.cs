namespace frmLogin
{
    partial class frmAlumnosPorAula
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbAulas = new System.Windows.Forms.ComboBox();
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 277);
            this.listBox1.TabIndex = 0;
            // 
            // cmbAulas
            // 
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.Location = new System.Drawing.Point(12, 26);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(121, 21);
            this.cmbAulas.TabIndex = 1;
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(208, 24);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(113, 23);
            this.btnMostrarAlumnos.TabIndex = 2;
            this.btnMostrarAlumnos.Text = "Mostrar alumnos";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione aula";
            // 
            // frmAlumnosPorAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarAlumnos);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.listBox1);
            this.Name = "frmAlumnosPorAula";
            this.Text = "frmAlumnosPorAula";
            this.Load += new System.EventHandler(this.frmAlumnosPorAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbAulas;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.Label label1;
    }
}