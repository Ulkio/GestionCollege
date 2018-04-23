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
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlModifierMatieres = new System.Windows.Forms.Panel();
            this.txtModifierSalle = new System.Windows.Forms.TextBox();
            this.lblSalle = new System.Windows.Forms.Label();
            this.btnAnnulerModifierMatiere = new System.Windows.Forms.Button();
            this.btnValiderModifierMatiere = new System.Windows.Forms.Button();
            this.txtMatiere = new System.Windows.Forms.TextBox();
            this.lblModifierMatiere = new System.Windows.Forms.Label();
            this.pnlNouvelleMatieres = new System.Windows.Forms.Panel();
            this.btnAnnulerNouvelleMatiere = new System.Windows.Forms.Button();
            this.btnValiderNouvelleMatiere = new System.Windows.Forms.Button();
            this.txtNouvelleSalle = new System.Windows.Forms.TextBox();
            this.lblNouvelleSalle = new System.Windows.Forms.Label();
            this.txtAjouter = new System.Windows.Forms.TextBox();
            this.lblNouvelleMatieres = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblMatieres = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lstMatieres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlModifierMatieres.SuspendLayout();
            this.pnlNouvelleMatieres.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(284, 324);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // pnlModifierMatieres
            // 
            this.pnlModifierMatieres.Controls.Add(this.txtModifierSalle);
            this.pnlModifierMatieres.Controls.Add(this.lblSalle);
            this.pnlModifierMatieres.Controls.Add(this.btnAnnulerModifierMatiere);
            this.pnlModifierMatieres.Controls.Add(this.btnValiderModifierMatiere);
            this.pnlModifierMatieres.Controls.Add(this.txtMatiere);
            this.pnlModifierMatieres.Controls.Add(this.lblModifierMatiere);
            this.pnlModifierMatieres.Location = new System.Drawing.Point(187, 189);
            this.pnlModifierMatieres.Name = "pnlModifierMatieres";
            this.pnlModifierMatieres.Size = new System.Drawing.Size(172, 124);
            this.pnlModifierMatieres.TabIndex = 17;
            this.pnlModifierMatieres.Visible = false;
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
            this.btnAnnulerModifierMatiere.Click += new System.EventHandler(this.btnAnnulerModifierMatiere_Click);
            // 
            // btnValiderModifierMatiere
            // 
            this.btnValiderModifierMatiere.Location = new System.Drawing.Point(7, 95);
            this.btnValiderModifierMatiere.Name = "btnValiderModifierMatiere";
            this.btnValiderModifierMatiere.Size = new System.Drawing.Size(75, 23);
            this.btnValiderModifierMatiere.TabIndex = 2;
            this.btnValiderModifierMatiere.Text = "Valider";
            this.btnValiderModifierMatiere.UseVisualStyleBackColor = true;
            this.btnValiderModifierMatiere.Click += new System.EventHandler(this.btnValiderModifierMatiere_Click);
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
            // pnlNouvelleMatieres
            // 
            this.pnlNouvelleMatieres.Controls.Add(this.btnAnnulerNouvelleMatiere);
            this.pnlNouvelleMatieres.Controls.Add(this.btnValiderNouvelleMatiere);
            this.pnlNouvelleMatieres.Controls.Add(this.txtNouvelleSalle);
            this.pnlNouvelleMatieres.Controls.Add(this.lblNouvelleSalle);
            this.pnlNouvelleMatieres.Controls.Add(this.txtAjouter);
            this.pnlNouvelleMatieres.Controls.Add(this.lblNouvelleMatieres);
            this.pnlNouvelleMatieres.Location = new System.Drawing.Point(12, 189);
            this.pnlNouvelleMatieres.Name = "pnlNouvelleMatieres";
            this.pnlNouvelleMatieres.Size = new System.Drawing.Size(169, 124);
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
            this.btnAnnulerNouvelleMatiere.Click += new System.EventHandler(this.btnAnnulerNouvelleMatiere_Click);
            // 
            // btnValiderNouvelleMatiere
            // 
            this.btnValiderNouvelleMatiere.Location = new System.Drawing.Point(7, 95);
            this.btnValiderNouvelleMatiere.Name = "btnValiderNouvelleMatiere";
            this.btnValiderNouvelleMatiere.Size = new System.Drawing.Size(75, 23);
            this.btnValiderNouvelleMatiere.TabIndex = 10;
            this.btnValiderNouvelleMatiere.Text = "Valider";
            this.btnValiderNouvelleMatiere.UseVisualStyleBackColor = true;
            this.btnValiderNouvelleMatiere.Click += new System.EventHandler(this.btnValiderNouvelleMatiere_Click);
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
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(274, 93);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(274, 64);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblMatieres
            // 
            this.lblMatieres.AutoSize = true;
            this.lblMatieres.BackColor = System.Drawing.Color.Transparent;
            this.lblMatieres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatieres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMatieres.Location = new System.Drawing.Point(12, 9);
            this.lblMatieres.Name = "lblMatieres";
            this.lblMatieres.Size = new System.Drawing.Size(113, 15);
            this.lblMatieres.TabIndex = 14;
            this.lblMatieres.Text = "Liste des matières :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(275, 35);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.lstMatieres.Items.AddRange(new object[] {
            "Français",
            "Anglais",
            "Mathématiques",
            "EPS"});
            this.lstMatieres.Location = new System.Drawing.Point(15, 35);
            this.lstMatieres.Name = "lstMatieres";
            this.lstMatieres.Size = new System.Drawing.Size(98, 95);
            this.lstMatieres.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Departement associé :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sciences",
            "Langue",
            "Histoire géo",
            "Activité Sportive et Culturelle"});
            this.comboBox1.Location = new System.Drawing.Point(138, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // frmGestionMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionCollege.Properties.Resources.GestionMatiereFond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 352);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlNouvelleMatieres);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.pnlModifierMatieres);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblMatieres);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lstMatieres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionMatiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Matiere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionMatiere_FormClosing);
            this.pnlModifierMatieres.ResumeLayout(false);
            this.pnlModifierMatieres.PerformLayout();
            this.pnlNouvelleMatieres.ResumeLayout(false);
            this.pnlNouvelleMatieres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}