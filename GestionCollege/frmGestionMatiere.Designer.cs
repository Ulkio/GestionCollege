namespace GestionCollege
{
    partial class frmGestionMatiere
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.pnlModifierMatieres = new System.Windows.Forms.Panel();
            this.pnlNouvelleMatieres = new System.Windows.Forms.Panel();
            this.btnAnnulerNouvelleMatiere = new System.Windows.Forms.Button();
            this.btnValiderNouvelleMatiere = new System.Windows.Forms.Button();
            this.txtNouvelleSalle = new System.Windows.Forms.TextBox();
            this.lblNouvelleSalle = new System.Windows.Forms.Label();
            this.txtAjouter = new System.Windows.Forms.TextBox();
            this.lblNouvelleMatieres = new System.Windows.Forms.Label();
            this.txtModifierSalle = new System.Windows.Forms.TextBox();
            this.lblSalle = new System.Windows.Forms.Label();
            this.btnAnnulerModifierMatiere = new System.Windows.Forms.Button();
            this.btnValiderModifierMatiere = new System.Windows.Forms.Button();
            this.txtMatiere = new System.Windows.Forms.TextBox();
            this.lblModifierMatiere = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblMatieres = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lstMatieres = new System.Windows.Forms.ListBox();
            this.pnlModifierMatieres.SuspendLayout();
            this.pnlNouvelleMatieres.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(257, 237);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 19;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(257, 266);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 18;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            // 
            // pnlModifierMatieres
            // 
            this.pnlModifierMatieres.Controls.Add(this.txtModifierSalle);
            this.pnlModifierMatieres.Controls.Add(this.lblSalle);
            this.pnlModifierMatieres.Controls.Add(this.btnAnnulerModifierMatiere);
            this.pnlModifierMatieres.Controls.Add(this.btnValiderModifierMatiere);
            this.pnlModifierMatieres.Controls.Add(this.txtMatiere);
            this.pnlModifierMatieres.Controls.Add(this.lblModifierMatiere);
            this.pnlModifierMatieres.Location = new System.Drawing.Point(15, 165);
            this.pnlModifierMatieres.Name = "pnlModifierMatieres";
            this.pnlModifierMatieres.Size = new System.Drawing.Size(172, 124);
            this.pnlModifierMatieres.TabIndex = 17;
            this.pnlModifierMatieres.Visible = false;
            // 
            // pnlNouvelleMatieres
            // 
            this.pnlNouvelleMatieres.Controls.Add(this.btnAnnulerNouvelleMatiere);
            this.pnlNouvelleMatieres.Controls.Add(this.btnValiderNouvelleMatiere);
            this.pnlNouvelleMatieres.Controls.Add(this.txtNouvelleSalle);
            this.pnlNouvelleMatieres.Controls.Add(this.lblNouvelleSalle);
            this.pnlNouvelleMatieres.Controls.Add(this.txtAjouter);
            this.pnlNouvelleMatieres.Controls.Add(this.lblNouvelleMatieres);
            this.pnlNouvelleMatieres.Location = new System.Drawing.Point(18, 165);
            this.pnlNouvelleMatieres.Name = "pnlNouvelleMatieres";
            this.pnlNouvelleMatieres.Size = new System.Drawing.Size(172, 124);
            this.pnlNouvelleMatieres.TabIndex = 9;
            this.pnlNouvelleMatieres.Visible = false;
            // 
            // btnAnnulerNouvelleMatiere
            // 
            this.btnAnnulerNouvelleMatiere.Location = new System.Drawing.Point(88, 95);
            this.btnAnnulerNouvelleMatiere.Name = "btnAnnulerNouvelleMatiere";
            this.btnAnnulerNouvelleMatiere.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNouvelleMatiere.TabIndex = 11;
            this.btnAnnulerNouvelleMatiere.Text = "Annuler";
            this.btnAnnulerNouvelleMatiere.UseVisualStyleBackColor = true;
            // 
            // btnValiderNouvelleMatiere
            // 
            this.btnValiderNouvelleMatiere.Location = new System.Drawing.Point(7, 95);
            this.btnValiderNouvelleMatiere.Name = "btnValiderNouvelleMatiere";
            this.btnValiderNouvelleMatiere.Size = new System.Drawing.Size(75, 23);
            this.btnValiderNouvelleMatiere.TabIndex = 10;
            this.btnValiderNouvelleMatiere.Text = "Valider";
            this.btnValiderNouvelleMatiere.UseVisualStyleBackColor = true;
            // 
            // txtNouvelleSalle
            // 
            this.txtNouvelleSalle.Location = new System.Drawing.Point(7, 69);
            this.txtNouvelleSalle.Name = "txtNouvelleSalle";
            this.txtNouvelleSalle.Size = new System.Drawing.Size(156, 20);
            this.txtNouvelleSalle.TabIndex = 9;
            // 
            // lblNouvelleSalle
            // 
            this.lblNouvelleSalle.AutoSize = true;
            this.lblNouvelleSalle.Location = new System.Drawing.Point(4, 53);
            this.lblNouvelleSalle.Name = "lblNouvelleSalle";
            this.lblNouvelleSalle.Size = new System.Drawing.Size(128, 13);
            this.lblNouvelleSalle.TabIndex = 8;
            this.lblNouvelleSalle.Text = "Nouvelle Salle de cours : ";
            // 
            // txtAjouter
            // 
            this.txtAjouter.Location = new System.Drawing.Point(7, 29);
            this.txtAjouter.Name = "txtAjouter";
            this.txtAjouter.Size = new System.Drawing.Size(157, 20);
            this.txtAjouter.TabIndex = 4;
            // 
            // lblNouvelleMatieres
            // 
            this.lblNouvelleMatieres.AutoSize = true;
            this.lblNouvelleMatieres.Location = new System.Drawing.Point(3, 5);
            this.lblNouvelleMatieres.Name = "lblNouvelleMatieres";
            this.lblNouvelleMatieres.Size = new System.Drawing.Size(92, 13);
            this.lblNouvelleMatieres.TabIndex = 7;
            this.lblNouvelleMatieres.Text = "Nouvelle matière :";
            // 
            // txtModifierSalle
            // 
            this.txtModifierSalle.Location = new System.Drawing.Point(7, 69);
            this.txtModifierSalle.Name = "txtModifierSalle";
            this.txtModifierSalle.Size = new System.Drawing.Size(156, 20);
            this.txtModifierSalle.TabIndex = 5;
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Location = new System.Drawing.Point(4, 53);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(123, 13);
            this.lblSalle.TabIndex = 4;
            this.lblSalle.Text = "Modifier Salle de cours : ";
            // 
            // btnAnnulerModifierMatiere
            // 
            this.btnAnnulerModifierMatiere.Location = new System.Drawing.Point(88, 95);
            this.btnAnnulerModifierMatiere.Name = "btnAnnulerModifierMatiere";
            this.btnAnnulerModifierMatiere.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerModifierMatiere.TabIndex = 3;
            this.btnAnnulerModifierMatiere.Text = "Annuler";
            this.btnAnnulerModifierMatiere.UseVisualStyleBackColor = true;
            // 
            // btnValiderModifierMatiere
            // 
            this.btnValiderModifierMatiere.Location = new System.Drawing.Point(7, 95);
            this.btnValiderModifierMatiere.Name = "btnValiderModifierMatiere";
            this.btnValiderModifierMatiere.Size = new System.Drawing.Size(75, 23);
            this.btnValiderModifierMatiere.TabIndex = 2;
            this.btnValiderModifierMatiere.Text = "Valider";
            this.btnValiderModifierMatiere.UseVisualStyleBackColor = true;
            // 
            // txtMatiere
            // 
            this.txtMatiere.Location = new System.Drawing.Point(7, 30);
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.Size = new System.Drawing.Size(156, 20);
            this.txtMatiere.TabIndex = 1;
            // 
            // lblModifierMatiere
            // 
            this.lblModifierMatiere.AutoSize = true;
            this.lblModifierMatiere.Location = new System.Drawing.Point(4, 7);
            this.lblModifierMatiere.Name = "lblModifierMatiere";
            this.lblModifierMatiere.Size = new System.Drawing.Size(113, 13);
            this.lblModifierMatiere.TabIndex = 0;
            this.lblModifierMatiere.Text = "Modifier nom matière : ";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(257, 93);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(257, 64);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // lblMatieres
            // 
            this.lblMatieres.AutoSize = true;
            this.lblMatieres.Location = new System.Drawing.Point(12, 9);
            this.lblMatieres.Name = "lblMatieres";
            this.lblMatieres.Size = new System.Drawing.Size(97, 13);
            this.lblMatieres.TabIndex = 14;
            this.lblMatieres.Text = "Liste des matières :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(258, 35);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(15, 136);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // lstMatieres
            // 
            this.lstMatieres.FormattingEnabled = true;
            this.lstMatieres.Location = new System.Drawing.Point(15, 35);
            this.lstMatieres.Name = "lstMatieres";
            this.lstMatieres.Size = new System.Drawing.Size(236, 95);
            this.lstMatieres.TabIndex = 11;
            // 
            // frmGestionMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 298);
            this.Controls.Add(this.pnlNouvelleMatieres);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.pnlModifierMatieres);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblMatieres);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lstMatieres);
            this.Name = "frmGestionMatiere";
            this.Text = "Gestion Matiere";
            this.pnlModifierMatieres.ResumeLayout(false);
            this.pnlModifierMatieres.PerformLayout();
            this.pnlNouvelleMatieres.ResumeLayout(false);
            this.pnlNouvelleMatieres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel pnlModifierMatieres;
        private System.Windows.Forms.Panel pnlNouvelleMatieres;
        private System.Windows.Forms.Button btnAnnulerNouvelleMatiere;
        private System.Windows.Forms.Button btnValiderNouvelleMatiere;
        private System.Windows.Forms.TextBox txtNouvelleSalle;
        private System.Windows.Forms.Label lblNouvelleSalle;
        private System.Windows.Forms.TextBox txtAjouter;
        private System.Windows.Forms.Label lblNouvelleMatieres;
        private System.Windows.Forms.TextBox txtModifierSalle;
        private System.Windows.Forms.Label lblSalle;
        private System.Windows.Forms.Button btnAnnulerModifierMatiere;
        private System.Windows.Forms.Button btnValiderModifierMatiere;
        private System.Windows.Forms.TextBox txtMatiere;
        private System.Windows.Forms.Label lblModifierMatiere;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblMatieres;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.ListBox lstMatieres;
    }
}