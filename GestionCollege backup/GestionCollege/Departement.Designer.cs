namespace GestionCollege
{
    partial class Departement
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
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnFiche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMatieres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEnseignants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDepartement = new System.Windows.Forms.ListBox();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(11, 298);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.ReadOnly = true;
            this.txtMoyenne.Size = new System.Drawing.Size(56, 20);
            this.txtMoyenne.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Moyenne département :";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(11, 248);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtResponsable.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Responsable département :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(11, 182);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(114, 23);
            this.btnAjouter.TabIndex = 40;
            this.btnAjouter.Text = "Ajouter département";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(193, 57);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 39;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(193, 28);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 38;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Enabled = false;
            this.btnAcceder.Location = new System.Drawing.Point(571, 182);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 37;
            this.btnAcceder.Text = "Accéder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnFiche
            // 
            this.btnFiche.Enabled = false;
            this.btnFiche.Location = new System.Drawing.Point(350, 182);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(75, 23);
            this.btnFiche.TabIndex = 36;
            this.btnFiche.Text = "Fiche";
            this.btnFiche.UseVisualStyleBackColor = true;
            this.btnFiche.Click += new System.EventHandler(this.btnFiche_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Matières :";
            // 
            // lstMatieres
            // 
            this.lstMatieres.FormattingEnabled = true;
            this.lstMatieres.Location = new System.Drawing.Point(571, 28);
            this.lstMatieres.Name = "lstMatieres";
            this.lstMatieres.ScrollAlwaysVisible = true;
            this.lstMatieres.Size = new System.Drawing.Size(176, 147);
            this.lstMatieres.TabIndex = 34;
            this.lstMatieres.SelectedIndexChanged += new System.EventHandler(this.lstMatieres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Enseignants";
            // 
            // lstEnseignants
            // 
            this.lstEnseignants.FormattingEnabled = true;
            this.lstEnseignants.Location = new System.Drawing.Point(350, 28);
            this.lstEnseignants.Name = "lstEnseignants";
            this.lstEnseignants.ScrollAlwaysVisible = true;
            this.lstEnseignants.Size = new System.Drawing.Size(176, 147);
            this.lstEnseignants.TabIndex = 32;
            this.lstEnseignants.SelectedIndexChanged += new System.EventHandler(this.lstEnseignants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Département :";
            // 
            // lstDepartement
            // 
            this.lstDepartement.FormattingEnabled = true;
            this.lstDepartement.Location = new System.Drawing.Point(11, 28);
            this.lstDepartement.Name = "lstDepartement";
            this.lstDepartement.ScrollAlwaysVisible = true;
            this.lstDepartement.Size = new System.Drawing.Size(176, 147);
            this.lstDepartement.TabIndex = 30;
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(690, 308);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 46;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // Departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 335);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.txtMoyenne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.btnFiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMatieres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstEnseignants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDepartement);
            this.Name = "Departement";
            this.Text = "Departement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMatieres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEnseignants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDepartement;
        private System.Windows.Forms.Button btnAccueil;
    }
}