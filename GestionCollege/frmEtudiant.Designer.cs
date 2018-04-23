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
            this.btnFiche = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblEtudiants = new System.Windows.Forms.Label();
            this.cbxEtudiants = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(237, 256);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 20;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // btnFiche
            // 
            this.btnFiche.Location = new System.Drawing.Point(12, 32);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(68, 23);
            this.btnFiche.TabIndex = 18;
            this.btnFiche.Text = "Fiche";
            this.btnFiche.UseVisualStyleBackColor = true;
            this.btnFiche.Click += new System.EventHandler(this.btnFiche_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(12, 119);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(68, 23);
            this.btnEditer.TabIndex = 17;
            this.btnEditer.Text = "Éditer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 90);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(68, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 61);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(68, 23);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblEtudiants
            // 
            this.lblEtudiants.AutoSize = true;
            this.lblEtudiants.BackColor = System.Drawing.Color.Transparent;
            this.lblEtudiants.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtudiants.Location = new System.Drawing.Point(9, 5);
            this.lblEtudiants.Name = "lblEtudiants";
            this.lblEtudiants.Size = new System.Drawing.Size(111, 24);
            this.lblEtudiants.TabIndex = 14;
            this.lblEtudiants.Text = "Étudiants";
            // 
            // cbxEtudiants
            // 
            this.cbxEtudiants.FormattingEnabled = true;
            this.cbxEtudiants.Location = new System.Drawing.Point(86, 32);
            this.cbxEtudiants.Name = "cbxEtudiants";
            this.cbxEtudiants.Size = new System.Drawing.Size(121, 21);
            this.cbxEtudiants.TabIndex = 13;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(156, 256);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionCollege.Properties.Resources.EtudiantImageFond;
            this.ClientSize = new System.Drawing.Size(324, 291);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.btnFiche);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblEtudiants);
            this.Controls.Add(this.cbxEtudiants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblEtudiants;
        private System.Windows.Forms.ComboBox cbxEtudiants;
        private System.Windows.Forms.Button btnQuitter;
    }
}