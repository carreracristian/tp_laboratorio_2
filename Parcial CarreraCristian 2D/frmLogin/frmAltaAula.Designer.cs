namespace frmLogin
{
    partial class frmAltaAula
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
            this.cmbxColores = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnGuardarAula = new System.Windows.Forms.Button();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxAlumnosSinAsignar = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbxAlumnosDelAula = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Docente";
            // 
            // cmbxColores
            // 
            this.cmbxColores.FormattingEnabled = true;
            this.cmbxColores.Location = new System.Drawing.Point(2, 34);
            this.cmbxColores.Name = "cmbxColores";
            this.cmbxColores.Size = new System.Drawing.Size(88, 21);
            this.cmbxColores.TabIndex = 4;
            this.cmbxColores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(196, 34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // btnGuardarAula
            // 
            this.btnGuardarAula.Location = new System.Drawing.Point(251, 302);
            this.btnGuardarAula.Name = "btnGuardarAula";
            this.btnGuardarAula.Size = new System.Drawing.Size(96, 23);
            this.btnGuardarAula.TabIndex = 9;
            this.btnGuardarAula.Text = "Guardar Aula";
            this.btnGuardarAula.UseVisualStyleBackColor = true;
            this.btnGuardarAula.Click += new System.EventHandler(this.btnGuardarAula_Click);
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(101, 34);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(84, 21);
            this.cmbTurnos.TabIndex = 10;
            this.cmbTurnos.SelectedIndexChanged += new System.EventHandler(this.cmbTurnos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alumnos sin aula";
            // 
            // lbxAlumnosSinAsignar
            // 
            this.lbxAlumnosSinAsignar.FormattingEnabled = true;
            this.lbxAlumnosSinAsignar.Location = new System.Drawing.Point(196, 87);
            this.lbxAlumnosSinAsignar.Name = "lbxAlumnosSinAsignar";
            this.lbxAlumnosSinAsignar.Size = new System.Drawing.Size(151, 212);
            this.lbxAlumnosSinAsignar.TabIndex = 12;
            // 
            // lbxAlumnosDelAula
            // 
            this.lbxAlumnosDelAula.FormattingEnabled = true;
            this.lbxAlumnosDelAula.Location = new System.Drawing.Point(0, 87);
            this.lbxAlumnosDelAula.Name = "lbxAlumnosDelAula";
            this.lbxAlumnosDelAula.Size = new System.Drawing.Size(150, 212);
            this.lbxAlumnosDelAula.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alumnos del aula";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(156, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(36, 37);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(156, 206);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(36, 37);
            this.btnQuitar.TabIndex = 19;
            this.btnQuitar.Text = ">";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // frmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 327);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxAlumnosDelAula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxAlumnosSinAsignar);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.btnGuardarAula);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbxColores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de aula";
            this.Load += new System.EventHandler(this.frmAltaAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxColores;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnGuardarAula;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxAlumnosSinAsignar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lbxAlumnosDelAula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
    }
}