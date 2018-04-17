namespace GestionCollege
{
    partial class Enseignant
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFiche = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstEnseignants = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(259, 239);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 15;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(259, 210);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(15, 164);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter Enseignant";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFiche
            // 
            this.btnFiche.Location = new System.Drawing.Point(185, 92);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(75, 23);
            this.btnFiche.TabIndex = 12;
            this.btnFiche.Text = "Fiche";
            this.btnFiche.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(185, 63);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(185, 34);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enseignants :";
            // 
            // lstEnseignants
            // 
            this.lstEnseignants.FormattingEnabled = true;
            this.lstEnseignants.Location = new System.Drawing.Point(12, 28);
            this.lstEnseignants.Name = "lstEnseignants";
            this.lstEnseignants.ScrollAlwaysVisible = true;
            this.lstEnseignants.Size = new System.Drawing.Size(167, 134);
            this.lstEnseignants.TabIndex = 8;
            // 
            // Enseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 269);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnFiche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEnseignants);
            this.Name = "Enseignant";
            this.Text = "Enseignant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEnseignants;
    }
}