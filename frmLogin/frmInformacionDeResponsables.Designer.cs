﻿namespace frmLogin
{
    partial class frmInformacionDeResponsables
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
            this.comboBoxSeleccionarAula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxResponsables = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxSeleccionarAula
            // 
            this.comboBoxSeleccionarAula.FormattingEnabled = true;
            this.comboBoxSeleccionarAula.Location = new System.Drawing.Point(12, 25);
            this.comboBoxSeleccionarAula.Name = "comboBoxSeleccionarAula";
            this.comboBoxSeleccionarAula.Size = new System.Drawing.Size(142, 21);
            this.comboBoxSeleccionarAula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione aula";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar Responsables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxResponsables
            // 
            this.listBoxResponsables.FormattingEnabled = true;
            this.listBoxResponsables.Location = new System.Drawing.Point(12, 51);
            this.listBoxResponsables.Name = "listBoxResponsables";
            this.listBoxResponsables.Size = new System.Drawing.Size(336, 277);
            this.listBoxResponsables.TabIndex = 6;
            // 
            // frmInformacionDeResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 334);
            this.Controls.Add(this.listBoxResponsables);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSeleccionarAula);
            this.Name = "frmInformacionDeResponsables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion de responsables";
            this.Load += new System.EventHandler(this.frmInformacionDeResponsables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSeleccionarAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxResponsables;
    }
}