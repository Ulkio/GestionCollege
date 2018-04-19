namespace GestionCollege
{
    partial class frmMatiere
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.btnEditerMatiere = new System.Windows.Forms.Button();
            this.btnEditerDepartement = new System.Windows.Forms.Button();
            this.btnFicheEtudiants = new System.Windows.Forms.Button();
            this.btnFicheEnseignants = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lvlSalleDeCours = new System.Windows.Forms.Label();
            this.lstEtudiants = new System.Windows.Forms.ListBox();
            this.lstEnseignants = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEtudiants = new System.Windows.Forms.Label();
            this.lblEnseignants = new System.Windows.Forms.Label();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.btnAjouterNote = new System.Windows.Forms.Button();
            this.pnlAjouterNote = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cbxMatiere = new System.Windows.Forms.ComboBox();
            this.pnlAjouterNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.Location = new System.Drawing.Point(378, 418);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 35;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = false;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 33;
            // 
            // lblMoyenne
            // 
            this.lblMoyenne.AutoSize = true;
            this.lblMoyenne.BackColor = System.Drawing.Color.Transparent;
            this.lblMoyenne.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyenne.Location = new System.Drawing.Point(12, 125);
            this.lblMoyenne.Name = "lblMoyenne";
            this.lblMoyenne.Size = new System.Drawing.Size(101, 16);
            this.lblMoyenne.TabIndex = 32;
            this.lblMoyenne.Text = "Moyenne Matiere :";
            // 
            // btnEditerMatiere
            // 
            this.btnEditerMatiere.BackColor = System.Drawing.Color.Transparent;
            this.btnEditerMatiere.Location = new System.Drawing.Point(216, 45);
            this.btnEditerMatiere.Name = "btnEditerMatiere";
            this.btnEditerMatiere.Size = new System.Drawing.Size(75, 20);
            this.btnEditerMatiere.TabIndex = 31;
            this.btnEditerMatiere.Text = "Editer";
            this.btnEditerMatiere.UseVisualStyleBackColor = false;
            this.btnEditerMatiere.Click += new System.EventHandler(this.btnEditerMatiere_Click);
            // 
            // btnEditerDepartement
            // 
            this.btnEditerDepartement.BackColor = System.Drawing.Color.Transparent;
            this.btnEditerDepartement.Location = new System.Drawing.Point(216, 5);
            this.btnEditerDepartement.Name = "btnEditerDepartement";
            this.btnEditerDepartement.Size = new System.Drawing.Size(75, 20);
            this.btnEditerDepartement.TabIndex = 30;
            this.btnEditerDepartement.Text = "Editer";
            this.btnEditerDepartement.UseVisualStyleBackColor = false;
            this.btnEditerDepartement.Click += new System.EventHandler(this.btnEditerDepartement_Click);
            // 
            // btnFicheEtudiants
            // 
            this.btnFicheEtudiants.BackColor = System.Drawing.SystemColors.Control;
            this.btnFicheEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFicheEtudiants.Location = new System.Drawing.Point(4, 331);
            this.btnFicheEtudiants.Name = "btnFicheEtudiants";
            this.btnFicheEtudiants.Size = new System.Drawing.Size(91, 23);
            this.btnFicheEtudiants.TabIndex = 29;
            this.btnFicheEtudiants.Text = "Fiche étudiant";
            this.btnFicheEtudiants.UseVisualStyleBackColor = false;
            this.btnFicheEtudiants.Click += new System.EventHandler(this.btnFicheEtudiants_Click);
            // 
            // btnFicheEnseignants
            // 
            this.btnFicheEnseignants.BackColor = System.Drawing.Color.Transparent;
            this.btnFicheEnseignants.Location = new System.Drawing.Point(341, 331);
            this.btnFicheEnseignants.Name = "btnFicheEnseignants";
            this.btnFicheEnseignants.Size = new System.Drawing.Size(112, 23);
            this.btnFicheEnseignants.TabIndex = 28;
            this.btnFicheEnseignants.Text = "Fiche enseignant";
            this.btnFicheEnseignants.UseVisualStyleBackColor = false;
            this.btnFicheEnseignants.Click += new System.EventHandler(this.btnFicheEnseignants_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 27;
            // 
            // lvlSalleDeCours
            // 
            this.lvlSalleDeCours.AutoSize = true;
            this.lvlSalleDeCours.BackColor = System.Drawing.Color.Transparent;
            this.lvlSalleDeCours.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSalleDeCours.Location = new System.Drawing.Point(12, 86);
            this.lvlSalleDeCours.Name = "lvlSalleDeCours";
            this.lvlSalleDeCours.Size = new System.Drawing.Size(82, 16);
            this.lvlSalleDeCours.TabIndex = 26;
            this.lvlSalleDeCours.Text = "Salle de cours :";
            // 
            // lstEtudiants
            // 
            this.lstEtudiants.FormattingEnabled = true;
            this.lstEtudiants.Items.AddRange(new object[] {
            "Jean",
            "Guillaume",
            "Maxence"});
            this.lstEtudiants.Location = new System.Drawing.Point(75, 178);
            this.lstEtudiants.Name = "lstEtudiants";
            this.lstEtudiants.Size = new System.Drawing.Size(126, 147);
            this.lstEtudiants.TabIndex = 25;
            // 
            // lstEnseignants
            // 
            this.lstEnseignants.FormattingEnabled = true;
            this.lstEnseignants.Items.AddRange(new object[] {
            "Jackie Chan",
            "Jean Claude Van Damne",
            "Bruce Lee"});
            this.lstEnseignants.Location = new System.Drawing.Point(327, 178);
            this.lstEnseignants.Name = "lstEnseignants";
            this.lstEnseignants.Size = new System.Drawing.Size(126, 147);
            this.lstEnseignants.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // lblEtudiants
            // 
            this.lblEtudiants.AutoSize = true;
            this.lblEtudiants.BackColor = System.Drawing.Color.Transparent;
            this.lblEtudiants.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtudiants.Location = new System.Drawing.Point(12, 175);
            this.lblEtudiants.Name = "lblEtudiants";
            this.lblEtudiants.Size = new System.Drawing.Size(63, 16);
            this.lblEtudiants.TabIndex = 21;
            this.lblEtudiants.Text = "Étudiants :";
            // 
            // lblEnseignants
            // 
            this.lblEnseignants.AutoSize = true;
            this.lblEnseignants.BackColor = System.Drawing.Color.Transparent;
            this.lblEnseignants.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnseignants.Location = new System.Drawing.Point(244, 175);
            this.lblEnseignants.Name = "lblEnseignants";
            this.lblEnseignants.Size = new System.Drawing.Size(83, 16);
            this.lblEnseignants.TabIndex = 20;
            this.lblEnseignants.Text = "Enseignant(s) :";
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.BackColor = System.Drawing.Color.Transparent;
            this.lblMatiere.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatiere.Location = new System.Drawing.Point(12, 45);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(54, 16);
            this.lblMatiere.TabIndex = 19;
            this.lblMatiere.Text = "Matière :";
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartement.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartement.Location = new System.Drawing.Point(12, 6);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(81, 16);
            this.lblDepartement.TabIndex = 18;
            this.lblDepartement.Text = "Département :";
            // 
            // btnAjouterNote
            // 
            this.btnAjouterNote.BackColor = System.Drawing.SystemColors.Control;
            this.btnAjouterNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterNote.Location = new System.Drawing.Point(101, 331);
            this.btnAjouterNote.Name = "btnAjouterNote";
            this.btnAjouterNote.Size = new System.Drawing.Size(100, 23);
            this.btnAjouterNote.TabIndex = 36;
            this.btnAjouterNote.Text = "Ajouter une note";
            this.btnAjouterNote.UseVisualStyleBackColor = false;
            this.btnAjouterNote.Click += new System.EventHandler(this.btnAjouterNote_Click);
            // 
            // pnlAjouterNote
            // 
            this.pnlAjouterNote.Controls.Add(this.lblNote);
            this.pnlAjouterNote.Controls.Add(this.textBox5);
            this.pnlAjouterNote.Controls.Add(this.btnAnnuler);
            this.pnlAjouterNote.Controls.Add(this.btnAjouter);
            this.pnlAjouterNote.Location = new System.Drawing.Point(75, 360);
            this.pnlAjouterNote.Name = "pnlAjouterNote";
            this.pnlAjouterNote.Size = new System.Drawing.Size(163, 81);
            this.pnlAjouterNote.TabIndex = 37;
            this.pnlAjouterNote.Visible = false;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(3, 5);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(39, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(84, 52);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(3, 52);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cbxMatiere
            // 
            this.cbxMatiere.FormattingEnabled = true;
            this.cbxMatiere.Items.AddRange(new object[] {
            "Français",
            "Anglais",
            "Mathématiques",
            "EPS"});
            this.cbxMatiere.Location = new System.Drawing.Point(110, 45);
            this.cbxMatiere.Name = "cbxMatiere";
            this.cbxMatiere.Size = new System.Drawing.Size(100, 21);
            this.cbxMatiere.TabIndex = 38;
            // 
            // frmMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionCollege.Properties.Resources.MatiereFond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 444);
            this.Controls.Add(this.cbxMatiere);
            this.Controls.Add(this.btnAjouterNote);
            this.Controls.Add(this.pnlAjouterNote);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblMoyenne);
            this.Controls.Add(this.btnEditerMatiere);
            this.Controls.Add(this.btnEditerDepartement);
            this.Controls.Add(this.btnFicheEtudiants);
            this.Controls.Add(this.btnFicheEnseignants);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lvlSalleDeCours);
            this.Controls.Add(this.lstEtudiants);
            this.Controls.Add(this.lstEnseignants);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEtudiants);
            this.Controls.Add(this.lblEnseignants);
            this.Controls.Add(this.lblMatiere);
            this.Controls.Add(this.lblDepartement);
            this.Name = "frmMatiere";
            this.Text = "Matiere";
            this.pnlAjouterNote.ResumeLayout(false);
            this.pnlAjouterNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.Button btnEditerMatiere;
        private System.Windows.Forms.Button btnEditerDepartement;
        private System.Windows.Forms.Button btnFicheEtudiants;
        private System.Windows.Forms.Button btnFicheEnseignants;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lvlSalleDeCours;
        private System.Windows.Forms.ListBox lstEtudiants;
        private System.Windows.Forms.ListBox lstEnseignants;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEtudiants;
        private System.Windows.Forms.Label lblEnseignants;
        private System.Windows.Forms.Label lblMatiere;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.Button btnAjouterNote;
        private System.Windows.Forms.Panel pnlAjouterNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cbxMatiere;
    }
}