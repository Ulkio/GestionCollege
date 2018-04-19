namespace GestionCollege
{
    partial class frmGestionEtudiant
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
            this.lstCloneMatiereEtudiante = new System.Windows.Forms.ListBox();
            this.btnSupprimeTout = new System.Windows.Forms.Button();
            this.btnSupprime = new System.Windows.Forms.Button();
            this.btnAjouteTout = new System.Windows.Forms.Button();
            this.btnAjoute = new System.Windows.Forms.Button();
            this.cbxMatieres = new System.Windows.Forms.ComboBox();
            this.lstMatiereEtudiant = new System.Windows.Forms.ListBox();
            this.lblMatieres = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblDateEntree = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlMatiereEtudiant = new System.Windows.Forms.Panel();
            this.btnValiderEtudiant = new System.Windows.Forms.Button();
            this.lblMatiereFiche = new System.Windows.Forms.Label();
            this.pnlMatiereEtudiant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCloneMatiereEtudiante
            // 
            this.lstCloneMatiereEtudiante.Enabled = false;
            this.lstCloneMatiereEtudiante.FormattingEnabled = true;
            this.lstCloneMatiereEtudiante.Items.AddRange(new object[] {
            "Français",
            "Anglais",
            "Mathématique",
            "EPS"});
            this.lstCloneMatiereEtudiante.Location = new System.Drawing.Point(346, 69);
            this.lstCloneMatiereEtudiante.Name = "lstCloneMatiereEtudiante";
            this.lstCloneMatiereEtudiante.Size = new System.Drawing.Size(120, 108);
            this.lstCloneMatiereEtudiante.TabIndex = 42;
            // 
            // btnSupprimeTout
            // 
            this.btnSupprimeTout.Enabled = false;
            this.btnSupprimeTout.Location = new System.Drawing.Point(238, 95);
            this.btnSupprimeTout.Name = "btnSupprimeTout";
            this.btnSupprimeTout.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimeTout.TabIndex = 41;
            this.btnSupprimeTout.Text = "<<";
            this.btnSupprimeTout.UseVisualStyleBackColor = true;
            this.btnSupprimeTout.Click += new System.EventHandler(this.btnSupprimeTout_Click);
            // 
            // btnSupprime
            // 
            this.btnSupprime.Enabled = false;
            this.btnSupprime.Location = new System.Drawing.Point(238, 66);
            this.btnSupprime.Name = "btnSupprime";
            this.btnSupprime.Size = new System.Drawing.Size(75, 23);
            this.btnSupprime.TabIndex = 40;
            this.btnSupprime.Text = "<";
            this.btnSupprime.UseVisualStyleBackColor = true;
            this.btnSupprime.Click += new System.EventHandler(this.btnSupprime_Click);
            // 
            // btnAjouteTout
            // 
            this.btnAjouteTout.Location = new System.Drawing.Point(238, 37);
            this.btnAjouteTout.Name = "btnAjouteTout";
            this.btnAjouteTout.Size = new System.Drawing.Size(75, 23);
            this.btnAjouteTout.TabIndex = 39;
            this.btnAjouteTout.Text = ">>";
            this.btnAjouteTout.UseVisualStyleBackColor = true;
            this.btnAjouteTout.Click += new System.EventHandler(this.btnAjouteTout_Click);
            // 
            // btnAjoute
            // 
            this.btnAjoute.Enabled = false;
            this.btnAjoute.Location = new System.Drawing.Point(238, 10);
            this.btnAjoute.Name = "btnAjoute";
            this.btnAjoute.Size = new System.Drawing.Size(75, 23);
            this.btnAjoute.TabIndex = 38;
            this.btnAjoute.Text = ">";
            this.btnAjoute.UseVisualStyleBackColor = true;
            this.btnAjoute.Click += new System.EventHandler(this.btnAjoute_Click);
            // 
            // cbxMatieres
            // 
            this.cbxMatieres.FormattingEnabled = true;
            this.cbxMatieres.Items.AddRange(new object[] {
            "Français",
            "Anglais",
            "Mathématique",
            "EPS"});
            this.cbxMatieres.Location = new System.Drawing.Point(111, 10);
            this.cbxMatieres.Name = "cbxMatieres";
            this.cbxMatieres.Size = new System.Drawing.Size(121, 21);
            this.cbxMatieres.TabIndex = 37;
            this.cbxMatieres.SelectedIndexChanged += new System.EventHandler(this.cbxMatieres_SelectedIndexChanged);
            // 
            // lstMatiereEtudiant
            // 
            this.lstMatiereEtudiant.FormattingEnabled = true;
            this.lstMatiereEtudiant.Location = new System.Drawing.Point(319, 10);
            this.lstMatiereEtudiant.Name = "lstMatiereEtudiant";
            this.lstMatiereEtudiant.Size = new System.Drawing.Size(120, 108);
            this.lstMatiereEtudiant.TabIndex = 36;
            this.lstMatiereEtudiant.SelectedIndexChanged += new System.EventHandler(this.lstMatiereEtudiant_SelectedIndexChanged);
            // 
            // lblMatieres
            // 
            this.lblMatieres.AutoSize = true;
            this.lblMatieres.BackColor = System.Drawing.Color.Black;
            this.lblMatieres.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatieres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMatieres.Location = new System.Drawing.Point(3, 13);
            this.lblMatieres.Name = "lblMatieres";
            this.lblMatieres.Size = new System.Drawing.Size(66, 17);
            this.lblMatieres.TabIndex = 35;
            this.lblMatieres.Text = "Matières :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(270, 426);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(337, 426);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 33;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(418, 426);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 32;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Visible = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblDateEntree
            // 
            this.lblDateEntree.AutoSize = true;
            this.lblDateEntree.BackColor = System.Drawing.Color.Black;
            this.lblDateEntree.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEntree.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateEntree.Location = new System.Drawing.Point(12, 205);
            this.lblDateEntree.Name = "lblDateEntree";
            this.lblDateEntree.Size = new System.Drawing.Size(94, 17);
            this.lblDateEntree.TabIndex = 31;
            this.lblDateEntree.Text = "Date d\'entrée :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Black;
            this.lblMail.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMail.Location = new System.Drawing.Point(12, 156);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(40, 17);
            this.lblMail.TabIndex = 30;
            this.lblMail.Text = "Mail :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.BackColor = System.Drawing.Color.Black;
            this.lblTelephone.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelephone.Location = new System.Drawing.Point(12, 104);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(70, 17);
            this.lblTelephone.TabIndex = 29;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Black;
            this.lblPrenom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrenom.Location = new System.Drawing.Point(12, 53);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(54, 17);
            this.lblPrenom.TabIndex = 28;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Black;
            this.lblNom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 17);
            this.lblNom.TabIndex = 27;
            this.lblNom.Text = "Nom :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 202);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 22;
            // 
            // pnlMatiereEtudiant
            // 
            this.pnlMatiereEtudiant.BackColor = System.Drawing.Color.Transparent;
            this.pnlMatiereEtudiant.Controls.Add(this.btnSupprimeTout);
            this.pnlMatiereEtudiant.Controls.Add(this.btnSupprime);
            this.pnlMatiereEtudiant.Controls.Add(this.btnAjouteTout);
            this.pnlMatiereEtudiant.Controls.Add(this.btnAjoute);
            this.pnlMatiereEtudiant.Controls.Add(this.cbxMatieres);
            this.pnlMatiereEtudiant.Controls.Add(this.lstMatiereEtudiant);
            this.pnlMatiereEtudiant.Controls.Add(this.lblMatieres);
            this.pnlMatiereEtudiant.Location = new System.Drawing.Point(12, 248);
            this.pnlMatiereEtudiant.Name = "pnlMatiereEtudiant";
            this.pnlMatiereEtudiant.Size = new System.Drawing.Size(454, 138);
            this.pnlMatiereEtudiant.TabIndex = 43;
            this.pnlMatiereEtudiant.Visible = false;
            // 
            // btnValiderEtudiant
            // 
            this.btnValiderEtudiant.Location = new System.Drawing.Point(325, 200);
            this.btnValiderEtudiant.Name = "btnValiderEtudiant";
            this.btnValiderEtudiant.Size = new System.Drawing.Size(96, 23);
            this.btnValiderEtudiant.TabIndex = 44;
            this.btnValiderEtudiant.Text = "Valider l\'étudiant";
            this.btnValiderEtudiant.UseVisualStyleBackColor = true;
            this.btnValiderEtudiant.Visible = false;
            this.btnValiderEtudiant.Click += new System.EventHandler(this.btnValiderEtudiant_Click);
            // 
            // lblMatiereFiche
            // 
            this.lblMatiereFiche.AutoSize = true;
            this.lblMatiereFiche.BackColor = System.Drawing.Color.Black;
            this.lblMatiereFiche.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatiereFiche.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMatiereFiche.Location = new System.Drawing.Point(343, 49);
            this.lblMatiereFiche.Name = "lblMatiereFiche";
            this.lblMatiereFiche.Size = new System.Drawing.Size(66, 17);
            this.lblMatiereFiche.TabIndex = 45;
            this.lblMatiereFiche.Text = "Matières :";
            // 
            // frmGestionEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionCollege.Properties.Resources.GestionEtudiantFond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 461);
            this.Controls.Add(this.lblMatiereFiche);
            this.Controls.Add(this.btnValiderEtudiant);
            this.Controls.Add(this.lstCloneMatiereEtudiante);
            this.Controls.Add(this.pnlMatiereEtudiant);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblDateEntree);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmGestionEtudiant";
            this.Text = "Gestion Etudiant";
            this.pnlMatiereEtudiant.ResumeLayout(false);
            this.pnlMatiereEtudiant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCloneMatiereEtudiante;
        private System.Windows.Forms.Button btnSupprimeTout;
        private System.Windows.Forms.Button btnSupprime;
        private System.Windows.Forms.Button btnAjouteTout;
        private System.Windows.Forms.Button btnAjoute;
        private System.Windows.Forms.ComboBox cbxMatieres;
        private System.Windows.Forms.ListBox lstMatiereEtudiant;
        private System.Windows.Forms.Label lblMatieres;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblDateEntree;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlMatiereEtudiant;
        private System.Windows.Forms.Button btnValiderEtudiant;
        private System.Windows.Forms.Label lblMatiereFiche;
    }
}