namespace frmLogin
{
    partial class frmRecaudacionPorAula
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
            this.comboBoxSeleccionColorAulaParaRecaudacion = new System.Windows.Forms.ComboBox();
            this.txtRecaudacionDeAula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un aula:";
            // 
            // comboBoxSeleccionColorAulaParaRecaudacion
            // 
            this.comboBoxSeleccionColorAulaParaRecaudacion.FormattingEnabled = true;
            this.comboBoxSeleccionColorAulaParaRecaudacion.Location = new System.Drawing.Point(107, 10);
            this.comboBoxSeleccionColorAulaParaRecaudacion.Name = "comboBoxSeleccionColorAulaParaRecaudacion";
            this.comboBoxSeleccionColorAulaParaRecaudacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeleccionColorAulaParaRecaudacion.TabIndex = 1;
            // 
            // txtRecaudacionDeAula
            // 
            this.txtRecaudacionDeAula.Location = new System.Drawing.Point(107, 41);
            this.txtRecaudacionDeAula.Name = "txtRecaudacionDeAula";
            this.txtRecaudacionDeAula.Size = new System.Drawing.Size(121, 20);
            this.txtRecaudacionDeAula.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Recaudacion:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRecaudacionPorAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 74);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecaudacionDeAula);
            this.Controls.Add(this.comboBoxSeleccionColorAulaParaRecaudacion);
            this.Controls.Add(this.label1);
            this.Name = "frmRecaudacionPorAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudacion por aula";
            this.Load += new System.EventHandler(this.frmRecaudacionPorAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSeleccionColorAulaParaRecaudacion;
        private System.Windows.Forms.TextBox txtRecaudacionDeAula;
        private System.Windows.Forms.Button button1;
    }
}