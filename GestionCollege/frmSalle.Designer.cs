﻿namespace GestionCollege
{
    partial class frmSalle
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
            this.lstMatieres = new System.Windows.Forms.ListBox();
            this.lblMatieres = new System.Windows.Forms.Label();
            this.btnEditerSalle = new System.Windows.Forms.Button();
            this.lstSalle = new System.Windows.Forms.ListBox();
            this.lblSalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMatieres
            // 
            this.lstMatieres.FormattingEnabled = true;
            this.lstMatieres.Location = new System.Drawing.Point(400, 177);
            this.lstMatieres.Name = "lstMatieres";
            this.lstMatieres.Size = new System.Drawing.Size(120, 95);
            this.lstMatieres.TabIndex = 20;
            // 
            // lblMatieres
            // 
            this.lblMatieres.AutoSize = true;
            this.lblMatieres.Location = new System.Drawing.Point(397, 152);
            this.lblMatieres.Name = "lblMatieres";
            this.lblMatieres.Size = new System.Drawing.Size(114, 13);
            this.lblMatieres.TabIndex = 19;
            this.lblMatieres.Text = "Matières dans la salle :";
            // 
            // btnEditerSalle
            // 
            this.btnEditerSalle.Location = new System.Drawing.Point(284, 278);
            this.btnEditerSalle.Name = "btnEditerSalle";
            this.btnEditerSalle.Size = new System.Drawing.Size(75, 20);
            this.btnEditerSalle.TabIndex = 18;
            this.btnEditerSalle.Text = "Editer";
            this.btnEditerSalle.UseVisualStyleBackColor = true;
            // 
            // lstSalle
            // 
            this.lstSalle.FormattingEnabled = true;
            this.lstSalle.Location = new System.Drawing.Point(284, 177);
            this.lstSalle.Name = "lstSalle";
            this.lstSalle.Size = new System.Drawing.Size(87, 95);
            this.lstSalle.TabIndex = 17;
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Location = new System.Drawing.Point(281, 152);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(36, 13);
            this.lblSalle.TabIndex = 16;
            this.lblSalle.Text = "Salle :";
            // 
            // frmSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMatieres);
            this.Controls.Add(this.lblMatieres);
            this.Controls.Add(this.btnEditerSalle);
            this.Controls.Add(this.lstSalle);
            this.Controls.Add(this.lblSalle);
            this.Name = "frmSalle";
            this.Text = "frmSalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMatieres;
        private System.Windows.Forms.Label lblMatieres;
        private System.Windows.Forms.Button btnEditerSalle;
        private System.Windows.Forms.ListBox lstSalle;
        private System.Windows.Forms.Label lblSalle;
    }
}