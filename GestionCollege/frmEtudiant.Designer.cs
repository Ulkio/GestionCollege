namespace GestionCollege
{
    partial class frmEtudiant
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
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnFiche = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblEtudiants = new System.Windows.Forms.Label();
            this.cbxEtudiants = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(432, 285);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 20;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(432, 256);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 19;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnFiche
            // 
            this.btnFiche.Location = new System.Drawing.Point(294, 198);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(75, 23);
            this.btnFiche.TabIndex = 18;
            this.btnFiche.Text = "Fiche";
            this.btnFiche.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Éditer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(294, 256);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(294, 227);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // lblEtudiants
            // 
            this.lblEtudiants.AutoSize = true;
            this.lblEtudiants.Location = new System.Drawing.Point(294, 143);
            this.lblEtudiants.Name = "lblEtudiants";
            this.lblEtudiants.Size = new System.Drawing.Size(51, 13);
            this.lblEtudiants.TabIndex = 14;
            this.lblEtudiants.Text = "Étudiants";
            // 
            // cbxEtudiants
            // 
            this.cbxEtudiants.FormattingEnabled = true;
            this.cbxEtudiants.Location = new System.Drawing.Point(297, 171);
            this.cbxEtudiants.Name = "cbxEtudiants";
            this.cbxEtudiants.Size = new System.Drawing.Size(121, 21);
            this.cbxEtudiants.TabIndex = 13;
            // 
            // frmEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnFiche);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblEtudiants);
            this.Controls.Add(this.cbxEtudiants);
            this.Name = "frmEtudiant";
            this.Text = "Etudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblEtudiants;
        private System.Windows.Forms.ComboBox cbxEtudiants;
    }
}