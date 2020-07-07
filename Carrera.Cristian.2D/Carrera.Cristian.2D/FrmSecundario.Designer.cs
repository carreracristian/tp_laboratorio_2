namespace Carrera.Cristian._2D
{
    partial class FrmSecundario
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
            this.lbxAlumnosEvaluados = new System.Windows.Forms.ListBox();
            this.dataAulas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProxAlumno = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtAlumnoEvaluado = new System.Windows.Forms.TextBox();
            this.labelRecreo = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proximo alumno a ser evaluado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de aulas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alumno en evaluacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alumnos ya evaluados";
            // 
            // lbxAlumnosEvaluados
            // 
            this.lbxAlumnosEvaluados.FormattingEnabled = true;
            this.lbxAlumnosEvaluados.Location = new System.Drawing.Point(28, 361);
            this.lbxAlumnosEvaluados.Name = "lbxAlumnosEvaluados";
            this.lbxAlumnosEvaluados.Size = new System.Drawing.Size(585, 173);
            this.lbxAlumnosEvaluados.TabIndex = 6;
            // 
            // dataAulas
            // 
            this.dataAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAulas.Location = new System.Drawing.Point(28, 72);
            this.dataAulas.Name = "dataAulas";
            this.dataAulas.Size = new System.Drawing.Size(235, 125);
            this.dataAulas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Docente asignado a evaluar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aula de evaluacion";
            // 
            // txtProxAlumno
            // 
            this.txtProxAlumno.Location = new System.Drawing.Point(28, 25);
            this.txtProxAlumno.Name = "txtProxAlumno";
            this.txtProxAlumno.Size = new System.Drawing.Size(585, 20);
            this.txtProxAlumno.TabIndex = 13;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(28, 269);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(585, 20);
            this.txtDocente.TabIndex = 14;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(28, 317);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(182, 20);
            this.txtAula.TabIndex = 15;
            // 
            // txtAlumnoEvaluado
            // 
            this.txtAlumnoEvaluado.Location = new System.Drawing.Point(28, 222);
            this.txtAlumnoEvaluado.Name = "txtAlumnoEvaluado";
            this.txtAlumnoEvaluado.Size = new System.Drawing.Size(585, 20);
            this.txtAlumnoEvaluado.TabIndex = 16;
            // 
            // labelRecreo
            // 
            this.labelRecreo.AutoSize = true;
            this.labelRecreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRecreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecreo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRecreo.Location = new System.Drawing.Point(279, 73);
            this.labelRecreo.Name = "labelRecreo";
            this.labelRecreo.Size = new System.Drawing.Size(334, 37);
            this.labelRecreo.TabIndex = 17;
            this.labelRecreo.Text = "TIEMPO DE RECREO";
            this.labelRecreo.Visible = false;
            this.labelRecreo.Click += new System.EventHandler(this.labelRecreo_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(283, 139);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(0, 13);
            this.labelTiempo.TabIndex = 18;
            // 
            // FrmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 544);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelRecreo);
            this.Controls.Add(this.txtAlumnoEvaluado);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtProxAlumno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataAulas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxAlumnosEvaluados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EVALUACIONES";
            this.Load += new System.EventHandler(this.FrmSecundario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxAlumnosEvaluados;
        private System.Windows.Forms.DataGridView dataAulas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProxAlumno;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtAlumnoEvaluado;
        private System.Windows.Forms.Label labelRecreo;
        private System.Windows.Forms.Label labelTiempo;
    }
}