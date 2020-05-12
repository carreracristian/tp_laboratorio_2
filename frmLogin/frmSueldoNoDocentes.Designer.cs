namespace frmLogin
{
    partial class frmSueldoNoDocentes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularSueldos = new System.Windows.Forms.Button();
            this.txtTotalDeSueldos = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de no docentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            // 
            // btnCalcularSueldos
            // 
            this.btnCalcularSueldos.Location = new System.Drawing.Point(12, 269);
            this.btnCalcularSueldos.Name = "btnCalcularSueldos";
            this.btnCalcularSueldos.Size = new System.Drawing.Size(138, 23);
            this.btnCalcularSueldos.TabIndex = 7;
            this.btnCalcularSueldos.Text = "Calcular total de sueldos";
            this.btnCalcularSueldos.UseVisualStyleBackColor = true;
            this.btnCalcularSueldos.Click += new System.EventHandler(this.btnCalcularSueldos_Click);
            // 
            // txtTotalDeSueldos
            // 
            this.txtTotalDeSueldos.Location = new System.Drawing.Point(189, 271);
            this.txtTotalDeSueldos.Name = "txtTotalDeSueldos";
            this.txtTotalDeSueldos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDeSueldos.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 238);
            this.listBox1.TabIndex = 5;
            // 
            // frmSueldoNoDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularSueldos);
            this.Controls.Add(this.txtTotalDeSueldos);
            this.Controls.Add(this.listBox1);
            this.Name = "frmSueldoNoDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sueldo de no docentes";
            this.Load += new System.EventHandler(this.frmSueldoNoDocentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularSueldos;
        private System.Windows.Forms.TextBox txtTotalDeSueldos;
        private System.Windows.Forms.ListBox listBox1;
    }
}