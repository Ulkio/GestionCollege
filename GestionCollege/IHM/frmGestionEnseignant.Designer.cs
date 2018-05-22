namespace GestionCollege
{
    partial class frmGestionEnseignant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEnseignant));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMatiere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSalleDeCours = new System.Windows.Forms.TextBox();
            this.btnValiderEnseignant = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.Location = new System.Drawing.Point(21, 399);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 32);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuler.Location = new System.Drawing.Point(613, 396);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 32);
            this.btnAnnuler.TabIndex = 32;
            this.btnAnnuler.Text = "Fermer";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmer.Location = new System.Drawing.Point(504, 396);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(99, 32);
            this.btnConfirmer.TabIndex = 31;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(3, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Salle de cours :";
            // 
            // cbxMatiere
            // 
            this.cbxMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatiere.FormattingEnabled = true;
            this.cbxMatiere.Location = new System.Drawing.Point(186, 19);
            this.cbxMatiere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMatiere.Name = "cbxMatiere";
            this.cbxMatiere.Size = new System.Drawing.Size(161, 26);
            this.cbxMatiere.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Matière enseignée : ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(201, 137);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(186, 23);
            this.txtDate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date d\'entrée en fonction :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(201, 106);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 23);
            this.txtMail.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mail :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(201, 75);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(186, 23);
            this.txtTel.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Téléphone :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(201, 44);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(186, 23);
            this.txtPrenom.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prénom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(201, 13);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(186, 23);
            this.txtNom.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtSalleDeCours);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxMatiere);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 236);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 127);
            this.panel1.TabIndex = 34;
            this.panel1.Visible = false;
            // 
            // txtSalleDeCours
            // 
            this.txtSalleDeCours.Location = new System.Drawing.Point(186, 74);
            this.txtSalleDeCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalleDeCours.Name = "txtSalleDeCours";
            this.txtSalleDeCours.ReadOnly = true;
            this.txtSalleDeCours.Size = new System.Drawing.Size(160, 23);
            this.txtSalleDeCours.TabIndex = 30;
            // 
            // btnValiderEnseignant
            // 
            this.btnValiderEnseignant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValiderEnseignant.Location = new System.Drawing.Point(21, 175);
            this.btnValiderEnseignant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValiderEnseignant.Name = "btnValiderEnseignant";
            this.btnValiderEnseignant.Size = new System.Drawing.Size(111, 53);
            this.btnValiderEnseignant.TabIndex = 35;
            this.btnValiderEnseignant.Text = "Valider enseignant";
            this.btnValiderEnseignant.UseVisualStyleBackColor = true;
            this.btnValiderEnseignant.Click += new System.EventHandler(this.btnValiderEnseignant_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImprimer.Location = new System.Drawing.Point(126, 399);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(99, 32);
            this.btnImprimer.TabIndex = 36;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Visible = false;
            // 
            // frmGestionEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 444);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnValiderEnseignant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGestionEnseignant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Enseignant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionEnseignant_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMatiere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalleDeCours;
        private System.Windows.Forms.Button btnValiderEnseignant;
        private System.Windows.Forms.Button btnImprimer;
    }
}